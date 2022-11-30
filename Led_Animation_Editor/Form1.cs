using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Led_Animation_Editor
{
    public partial class Form1 : Form
    {
        // Create a serializable struct for the slave
        [Serializable]
        private struct slave_t
        {
            public byte id;
            public byte[] ip_address;
            public byte status;
            public byte animation_list;
            public byte actual_animation;
        }

        private slave_t decode_slave( byte[] buffer, int number )
        {
            slave_t slave = new slave_t();

            byte size = 20; // sizeof( slave_t );

            slave.id = buffer[ number * size + 0 ];
            slave.ip_address = new byte[16];
            for ( int i = 0; i < 16; i++ )
                slave.ip_address[ i ] = buffer[ number * size + i + 1 ];
            slave.status = buffer[number * size + 17 ];
            slave.animation_list = buffer[number * size + 18 ];
            slave.actual_animation = buffer[number * size + 19 ];

            return slave;
        }

        List<slave_t> slaves = new List<slave_t>();
        Int32 selected_slave = -1;

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
            animations_lv.Columns.Add( "Name", 130 );
            animations_lv.Columns.Add( "Pattern", 67 );

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
                // Connect to the server
                IPEndPoint end_point = new IPEndPoint( IPAddress.Parse( "192.136.60.133" ), ( int )( 1235 ) );
                socket.Connect( end_point );

                // Ask for the slaves
                socket.Send( Encoding.ASCII.GetBytes( "get_animations_names" ) );

                // Recive slaves
                while ( socket.Receive( buffer ) > 0 )
                {
                    MessageBox.Show("aaa");
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
        {}

        private void force_slave_update( object sender, EventArgs e )
        {
            get_slaves();
        }

        private void force_animations_update( object sender, EventArgs e )
        {
            get_animations_names();
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
    }
}