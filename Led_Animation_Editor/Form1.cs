using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Led_Animation_Editor
{
    public partial class Form1 : Form
    {
        // Struct for the slave
        [ Serializable ]
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
        private struct animation_file_descriptor_t
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
            animation_file_descriptor.number_of_lines = buffer[0];
            animation_file_descriptor.line_length = buffer[4];
            animation_file_descriptor.delay = buffer[8];
            animation_file_descriptor.repeat = buffer[9];
            animation_file_descriptor.pattern = buffer[10];

            return animation_file_descriptor;
        }

        List<slave_t> slaves = new List<slave_t>();
        Int32 selected_slave = -1;

        string animation_to_send = "";

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
            slaves_lv.View = View.Details;
            slaves_lv.Columns.Add( "ID", 50 );
            slaves_lv.Columns.Add( "IP", 147 );

            // Set the animations table
            animations_lv.View = View.Details;
            animations_lv.Columns.Add( "Name", 197 );

            // Set the phases table
            phases_lv.View = View.Details;
            phases_lv.Columns.Add( "N", 50 );
            phases_lv.Columns.Add( "Colors", 345 );

            // Set the colors table
            colors_lv.View = View.Details;
            colors_lv.Columns.Add( "From", 50 );
            colors_lv.Columns.Add( "To", 50 );
            colors_lv.Columns.Add( "Color ( R - G - B )", 295 );
        }

        private void get_slaves()
        {
            // Create a buffer
            byte[] buffer = new byte[1024];

            // Create the socket
            Socket socket = new Socket( SocketType.Stream, ProtocolType.Tcp );

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

                animation_file_descriptor_t animation_file_descriptor;

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

                        // Set the values on the form
                        phases_nud.Value = animation_file_descriptor.number_of_lines;
                        repetitions_tb.Value = animation_file_descriptor.repeat;
                        delay_nud.Value = animation_file_descriptor.delay;

                        // Clear the animations informations list views
                        phases_lv.Items.Clear();
                        colors_lv.Items.Clear();
                    }
                    else
                    {
                        // Add the animation informations
                        actual_animation.Add( buffer );

                        int_colors_lv( buffer );
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

        private void upload_animation()
        {}

        private void int_colors_lv( byte[] buffer, UInt32 number_of_colors )
        {
            for ( UInt32 i = 0; i < buffer.Length )
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
            // Check if a slave was selected
            if ( animations_lv.SelectedIndices.Count != 0 )
            {
                // Store the slave selected
                animation_to_send = animations_lv.SelectedItems[0].Text;

                // Enable the animation request
                update_animations_b.Enabled = true;
            }
            else // No slave selected
            {
                // No slave selected
                animation_to_send = "";

                // Disable slave animation request
                update_animations_b.Enabled = false;
            }
        }
    }
}