using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Led_Animation_Editor
{
    public partial class Informations : Form
    {
        public Informations()
        {
            InitializeComponent();
            initialize_pattern_clb();
        }

        private void initialize_pattern_clb()
        {
            pattern_clb.Items.Add( "Normal", CheckState.Unchecked );
            pattern_clb.Items.Add( "Rainbow", CheckState.Unchecked );
        }

        private void confirm(object sender, EventArgs e)
        {
            Form1.animation_file_descriptor.number_of_lines = byte.Parse( phases_nud.Value.ToString() );
            Form1.animation_file_descriptor.line_length = UInt32.Parse( number_of_leds_nud.Value.ToString() ) * 3;
            Form1.animation_file_descriptor.delay = byte.Parse( delay_nud.Value.ToString() );
            Form1.animation_file_descriptor.repeat = byte.Parse( repetitions_tb.Value.ToString() );
            for ( Int32 i = 0; i < pattern_clb.Items.Count; i++ )
                if ( pattern_clb.GetItemChecked( i ) )
                    Form1.animation_file_descriptor.pattern = byte.Parse( i.ToString() );
            
            // Save the filename
            if ( filename_tb.Text == "" )
                Form1.file_name = "untitled.dat";
            else
                Form1.file_name = filename_tb.Text + ".dat";

            if ( force_cb.Checked )
                Form1.forced = 1;
            else
                Form1.forced = 0;

            this.Close();
        }

        private void change_pattern(object sender, ItemCheckEventArgs e)
        {
            if ( e.NewValue == CheckState.Checked )
                for ( Int32 i = 0; i < pattern_clb.Items.Count; i++ )
                    if ( e.Index != i )
                        pattern_clb.SetItemChecked( i, false );
        }
    }
}
