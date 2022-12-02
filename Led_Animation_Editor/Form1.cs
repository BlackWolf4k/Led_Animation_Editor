using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

using System.Linq;

namespace Led_Animation_Editor
{
    public partial class Form1 : Form
    {
        // Struct for the slave
        private struct slave_t
        {
            public byte id;
            public byte[] ip_address;
            public byte status;
            public byte animation_list;
            public byte actual_animation;
        }

        // Given a buffer decode the slave inside
        // Requires as argument the buffer and the offset of the slave
        // Return the decoded slave
        private slave_t decode_slave( byte[] buffer, int number )
        {
            slave_t slave = new slave_t();

            byte size = 20; // sizeof( slave_t );

            // Decode the slave
            slave.id = buffer[ number * size + 0 ];
            slave.ip_address = new byte[16];
            for ( int i = 0; i < 16; i++ )
                slave.ip_address[ i ] = buffer[ number * size + i + 1 ];
            slave.status = buffer[number * size + 17 ];
            slave.animation_list = buffer[number * size + 18 ];
            slave.actual_animation = buffer[number * size + 19 ];

            return slave;
        }

        // Struct for the animation file descriptor
        public struct animation_file_descriptor_t
        {
            public UInt32 number_of_lines;
            public UInt32 line_length;
            public byte delay;
            public byte repeat;
            public byte pattern;
        }

        // Given a buffer decodes the animation file descriptor inside
        // Requires as argument the buffer
        // Returns the decoded animation file descriptor
        private animation_file_descriptor_t decode_animation_file_descriptor( byte[] buffer )
        {
            animation_file_descriptor_t animation_file_descriptor = new animation_file_descriptor_t();
            
            // Decode the buffer
            animation_file_descriptor.number_of_lines = BitConverter.ToUInt32( buffer, 0 );
            animation_file_descriptor.line_length = BitConverter.ToUInt32( buffer, 4 );
            animation_file_descriptor.delay = buffer[8];
            animation_file_descriptor.repeat = buffer[9];
            animation_file_descriptor.pattern = buffer[10];

            return animation_file_descriptor;
        }

        List<slave_t> slaves = new List<slave_t>();
        Int32 selected_slave = -1;

        string animation_to_send = "";
        public static string file_name;
        public static byte forced = 0;

        public static animation_file_descriptor_t animation_file_descriptor;
        List<byte[]> actual_animation = new List<byte[]>();

        public Form1()
        {
            InitializeComponent();
            set_tables();
            get_slaves();
        }

        private void set_tables()
        {
            // Ste the slaves table
            slaves_lv.Items.Clear();
            slaves_lv.Columns.Clear();
            slaves_lv.View = View.Details;
            slaves_lv.Columns.Add( "ID", 50 );
            slaves_lv.Columns.Add( "IP", 147 );

            // Set the animations table
            animations_lv.Items.Clear();
            animations_lv.Columns.Clear();
            animations_lv.View = View.Details;
            animations_lv.Columns.Add( "Name", 197 );

            // Set the phases table
            phases_lv.Items.Clear();
            phases_lv.Columns.Clear();
            phases_lv.View = View.Details;
            phases_lv.Columns.Add( "Phase", 96 );

            // Set the colors table
            colors_lv.Items.Clear();
            colors_lv.Columns.Clear();
            colors_lv.View = View.Details;
            colors_lv.Columns.Add( "Number", 100 );
            colors_lv.Columns.Add( "Color ( R - G - B )", 352 );
        }

        private void get_slaves()
        {
            // Create a buffer
            byte[] buffer = new byte[1024];

            // Create the socket
            Socket socket = new Socket( SocketType.Stream, ProtocolType.Tcp );

            // Recive timeout
            socket.ReceiveTimeout = 1000;

            // Connect to the server
            try
            {
                // Clear the slaves list view
                slaves_lv.Items.Clear();

                // Connect to the server
                IPEndPoint end_point = new IPEndPoint( IPAddress.Parse( "192.136.60.133" ), ( int )( 1235 ) );
                socket.Connect( end_point );

                // Ask for the slaves
                socket.Send( Encoding.ASCII.GetBytes( "get_slaves" ) );

                // Recive slaves
                while ( true )
                {
                    // Recive the data from the server
                    int bytes_recived = socket.Receive( buffer );

                    // Check that something was recived
                    if ( bytes_recived <= 0 )
                        break; // Nothing recived, exit

                    // Put the slaves informations in the slaves listview
                    for ( Int32 i = 0; i < buffer.Length && buffer[ i * 20 ] > 0; i++ )
                    {
                        slave_t slave = decode_slave( buffer, i );

                        // Save the slave
                        slaves.Add( slave );

                        // Check that a slave was found
                        slaves_lv.Items.Add( new ListViewItem( new[] { slave.id.ToString(), Encoding.ASCII.GetString( slave.ip_address ) } ) );
                    }
                }

                // Close the connection
                socket.Shutdown( SocketShutdown.Both );
                socket.Close();
            }
            catch ( Exception e )
            {
                MessageBox.Show( "Error while connecting" );
            }
        }

        private void get_animations_names()
        {
            // Create a buffer
            byte[] buffer = new byte[1024];

            // Create the socket
            Socket socket = new Socket( SocketType.Stream, ProtocolType.Tcp );

            // Recive timeout
            socket.ReceiveTimeout = 1000;

            // Connect to the server
            try
            {
                // Clear the animations listview
                animations_lv.Items.Clear();

                // Connect to the server
                IPEndPoint end_point = new IPEndPoint( IPAddress.Parse( "192.136.60.133" ), ( int )( 1235 ) );
                socket.Connect( end_point );

                // Ask for the animations of a slave
                socket.Send( Encoding.ASCII.GetBytes( "get_animations_names" ) );

                // Send the id of the slave wich to get the animation playlist
                socket.Send( new[] { slaves[selected_slave].id, ( byte )0 } );

                // Recive animations
                while ( true )
                {
                    // Recive the data from the server
                    int bytes_recived = socket.Receive( buffer );

                    // Check that something was recived
                    if ( bytes_recived <= 0 )
                        break; // Nothing recived, exit
                    
                    // The animations are ";" separeted
                    string[] animations = Encoding.ASCII.GetString( buffer ).Split( ";" );

                    // Add the animation to the animations list view
                    for ( Int32 i = 0; i < animations.Length - 1; i++ )
                        animations_lv.Items.Add( new ListViewItem( animations[i] ) );
                }

                // Close the connection
                socket.Shutdown( SocketShutdown.Both );
                socket.Close();
            }
            catch ( Exception e )
            {
                MessageBox.Show( "Error while connecting" );
            }
        }

        private void get_animation()
        {
            // Create a buffer
            byte[] buffer = new byte[1024];

            // Create the socket
            Socket socket = new Socket( SocketType.Stream, ProtocolType.Tcp );

            // Recive timeout
            socket.ReceiveTimeout = 1000;

            // Connect to the server
            try
            {
                // Connect to the server
                IPEndPoint end_point = new IPEndPoint( IPAddress.Parse( "192.136.60.133" ), ( int )( 1235 ) );
                socket.Connect( end_point );

                // Ask for the animations's informations
                socket.Send( Encoding.ASCII.GetBytes( "get_animation" ) );

                // Send the animation filename
                socket.Send( Encoding.ASCII.GetBytes( animation_to_send ) );

                // Keep track of the piece of animation recived
                Int32 piece = 0;

                // Clear the animation buffer
                actual_animation.Clear();

                byte[] animation = new byte[0];

                // Recive animatio's informations
                while ( true )
                {
                    // Recive the data from the server
                    int bytes_recived = socket.Receive( buffer );

                    // Check that something was recived
                    if ( bytes_recived <= 0 )
                        break; // Nothing recived, exit

                    if ( piece == 0 )
                    {
                        animation_file_descriptor = decode_animation_file_descriptor( buffer );

                        // Clear the animations informations list views
                        phases_lv.Items.Clear();
                        colors_lv.Items.Clear();

                        piece += 1;
                    }
                    else
                    {
                        animation = animation.Concat( buffer ).ToArray();
                    }
                }

                // Close the connection
                socket.Shutdown( SocketShutdown.Both );
                socket.Close();

                decode_animation_body( animation, animation_file_descriptor );

                for ( UInt32 i = 0; i < animation_file_descriptor.number_of_lines; i++ )
                    phases_lv.Items.Add( new ListViewItem( i.ToString() ) );
            }
            catch ( Exception e )
            {
                MessageBox.Show( "Error while connecting" );
            }
        }

        private void decode_animation_body( byte[] animation, animation_file_descriptor_t descriptor )
        {
            byte[] piece = new byte[ descriptor.line_length ];

            for ( UInt32 i = 0; i < descriptor.number_of_lines; i++ )
            {
                for ( UInt32 j = 0; j < descriptor.line_length; j++ )
                {
                    piece[j] = animation[ i * descriptor.line_length + j ];
                }
                actual_animation.Add( piece );
            }
        }

        private void upload_animation()
        {
            // Create a buffer
            byte[] buffer = new byte[1024];

            // Create the socket
            Socket socket = new Socket( SocketType.Stream, ProtocolType.Tcp );

            // Recive timeout
            socket.ReceiveTimeout = 1000;

            // Connect to the server
            try
            {
                // Connect to the server
                IPEndPoint end_point = new IPEndPoint( IPAddress.Parse( "192.136.60.133" ), ( int )( 1235 ) );
                socket.Connect( end_point );

                // Copy the descriptor in the buffer
                Array.Copy(BitConverter.GetBytes(animation_file_descriptor.number_of_lines), buffer, 4);
                Array.Copy(BitConverter.GetBytes(animation_file_descriptor.line_length), 0, buffer, 4, 4);
                buffer[8] = animation_file_descriptor.delay;
                buffer[9] = animation_file_descriptor.repeat;
                buffer[10] = animation_file_descriptor.pattern;
                buffer[11] = Convert.ToByte( slaves_lv.SelectedItems[0].Index );
                buffer[12] = forced;
                actual_animation[0][1] = Convert.ToByte( 252 );

                // Ask for uploading an animation
                socket.Send( Encoding.ASCII.GetBytes( "upload_animation" ) );

                socket.Send( Encoding.ASCII.GetBytes( file_name + "\0" ) );

                // Send the descriptor
                socket.Send( buffer );
                socket.Send(actual_animation[0]);

                // Send the body

                // Recive slaves
                for ( Int32 i = 0; i < animation_file_descriptor.number_of_lines; i++ )
                {
                    socket.Send( actual_animation[i] );
                }

                // Close the connection
                socket.Shutdown( SocketShutdown.Both );
                socket.Close();
            }
            catch ( Exception e )
            {
                MessageBox.Show( "Error while connecting" );
            }
        }

        private void into_colors_lv( byte[] buffer )
        {
            colors_lv.Items.Clear();

            for ( UInt32 i = 0; i < animation_file_descriptor.line_length / 3; i++ )
            {
                colors_lv.Items.Add( new ListViewItem( new[] { i.ToString(), buffer[ i * 3 + 0 ].ToString() + ", " + buffer[ i * 3 + 1 ].ToString() + ", " + buffer[ i * 3 + 2 ].ToString() } ) );
            }
        }

        private void force_slave_update( object sender, EventArgs e )
        {
            get_slaves();
        }

        private void force_animations_update( object sender, EventArgs e )
        {
            get_animations_names();
        }

        private void force_get_animation(object sender, EventArgs e)
        {
            get_animation();
        }

        private void force_animation_upload(object sender, EventArgs e)
        {
            upload_animation();
        }

        private void force_set_tables(object sender, EventArgs e)
        {
            set_tables();
        }

        private void select_slave( object sender, EventArgs e )
        {
            // Check if a slave was selected
            if ( slaves_lv.SelectedIndices.Count != 0 )
            {
                // Store the slave selected
                selected_slave = slaves_lv.SelectedItems[0].Index;

                // Enable the animation request
                update_animations_b.Enabled = true;
            }
            else // No slave selected
            {
                // No slave selected
                selected_slave = -1;

                // Disable slave animation request
                update_animations_b.Enabled = false;
            }
        }

        private void select_animation( object sender, EventArgs e )
        {
            // Check if a animation was selected
            if ( animations_lv.SelectedIndices.Count != 0 )
            {
                // Store the animation selected
                animation_to_send = animations_lv.SelectedItems[0].Text;

                // Enable the get request
                get_animation_b.Enabled = true;
            }
            else // No animation selected
            {
                // No animation selected
                animation_to_send = "";

                // Disable get animation request
                get_animation_b.Enabled = false;
            }
        }

        private void change_displayed_colors( object sender, EventArgs e )
        {
            // Check if a line was selected
            if ( phases_lv.SelectedIndices.Count != 0 )
            {
                // Store the line selected
                into_colors_lv( actual_animation[ phases_lv.SelectedItems[0].Index ] );
            }
            else // No line selected
            {
                //colors_lv.Items.Clear();
            }
        }

        private void make_new_animation( object sender, EventArgs e )
        {
            Informations informations_form = new Informations();
            informations_form.ShowDialog();

            byte[] buffer = new byte[ animation_file_descriptor.line_length ];

            // Clear the list view and the animation buffer
            colors_lv.Items.Clear();
            actual_animation.Clear();

            // Store the phases
            for ( UInt32 i = 0; i < animation_file_descriptor.number_of_lines; i++ )
            {
                phases_lv.Items.Add( new ListViewItem( i.ToString() ) );
                actual_animation.Add( buffer );
            }

            from_nud.Maximum = ( animation_file_descriptor.line_length / 3 ) - 1;
            to_nud.Maximum = ( animation_file_descriptor.line_length / 3 );
        }

        private void add_color( object sender, EventArgs e )
        {
            byte[] buffer = actual_animation[ phases_lv.SelectedItems[0].Index ];
            for ( UInt32 i = UInt32.Parse( from_nud.Value.ToString() ) * 3; i < UInt32.Parse( to_nud.Value.ToString() ) * 3;  i += 3 )
            {
                buffer[ i + 0 ] = color_dialog_cd.Color.R;
                buffer[ i + 1 ] = color_dialog_cd.Color.G;
                buffer[ i + 2 ] = color_dialog_cd.Color.B;
            }
            into_colors_lv( actual_animation[ phases_lv.SelectedItems[0].Index ] );
        }

        private void choose_color(object sender, EventArgs e)
        {
            color_dialog_cd.ShowDialog();
        }
    }
}