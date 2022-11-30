using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Led_Animation_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            get_slaves();
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
                    int bytes_recived = socket.Receive( buffer );

                    if ( bytes_recived <= 0 )
                        break;

                    for ( Int32 i = 0; i < buffer.Length; i += 20 ) // 20 = sizeof( slave_t )
                    {
                        if ( buffer[i] > 0 )
                            slaves_lv.Items.Add( new ListViewItem( buffer[i].ToString() ) );
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
    }
}