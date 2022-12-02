namespace Led_Animation_Editor
{
    partial class Informations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pattern_clb = new System.Windows.Forms.CheckedListBox();
            this.leds_l = new System.Windows.Forms.Label();
            this.phases_l = new System.Windows.Forms.Label();
            this.repetitions_l = new System.Windows.Forms.Label();
            this.force_to_play_l = new System.Windows.Forms.Label();
            this.delay_l = new System.Windows.Forms.Label();
            this.name_l = new System.Windows.Forms.Label();
            this.filename_tb = new System.Windows.Forms.TextBox();
            this.number_of_leds_nud = new System.Windows.Forms.NumericUpDown();
            this.phases_nud = new System.Windows.Forms.NumericUpDown();
            this.delay_nud = new System.Windows.Forms.NumericUpDown();
            this.force_cb = new System.Windows.Forms.CheckBox();
            this.repetitions_tb = new System.Windows.Forms.TrackBar();
            this.confirm_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_leds_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phases_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetitions_tb)).BeginInit();
            this.SuspendLayout();
            // 
            // pattern_clb
            // 
            this.pattern_clb.FormattingEnabled = true;
            this.pattern_clb.Location = new System.Drawing.Point(12, 219);
            this.pattern_clb.Name = "pattern_clb";
            this.pattern_clb.Size = new System.Drawing.Size(360, 130);
            this.pattern_clb.TabIndex = 0;
            this.pattern_clb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.change_pattern);
            // 
            // leds_l
            // 
            this.leds_l.AutoSize = true;
            this.leds_l.Location = new System.Drawing.Point(12, 9);
            this.leds_l.Name = "leds_l";
            this.leds_l.Size = new System.Drawing.Size(95, 15);
            this.leds_l.TabIndex = 1;
            this.leds_l.Text = "Number of Leds:";
            // 
            // phases_l
            // 
            this.phases_l.AutoSize = true;
            this.phases_l.Location = new System.Drawing.Point(12, 41);
            this.phases_l.Name = "phases_l";
            this.phases_l.Size = new System.Drawing.Size(107, 15);
            this.phases_l.TabIndex = 2;
            this.phases_l.Text = "Number of phases:";
            // 
            // repetitions_l
            // 
            this.repetitions_l.AutoSize = true;
            this.repetitions_l.Location = new System.Drawing.Point(12, 113);
            this.repetitions_l.Name = "repetitions_l";
            this.repetitions_l.Size = new System.Drawing.Size(69, 15);
            this.repetitions_l.TabIndex = 3;
            this.repetitions_l.Text = "Repetitions:";
            // 
            // force_to_play_l
            // 
            this.force_to_play_l.AutoSize = true;
            this.force_to_play_l.Location = new System.Drawing.Point(12, 140);
            this.force_to_play_l.Name = "force_to_play_l";
            this.force_to_play_l.Size = new System.Drawing.Size(78, 15);
            this.force_to_play_l.TabIndex = 4;
            this.force_to_play_l.Text = "Force to Play:";
            // 
            // delay_l
            // 
            this.delay_l.AutoSize = true;
            this.delay_l.Location = new System.Drawing.Point(12, 81);
            this.delay_l.Name = "delay_l";
            this.delay_l.Size = new System.Drawing.Size(72, 15);
            this.delay_l.TabIndex = 5;
            this.delay_l.Text = "Delay ( ms ):";
            // 
            // name_l
            // 
            this.name_l.AutoSize = true;
            this.name_l.Location = new System.Drawing.Point(12, 174);
            this.name_l.Name = "name_l";
            this.name_l.Size = new System.Drawing.Size(42, 15);
            this.name_l.TabIndex = 6;
            this.name_l.Text = "Name:";
            // 
            // filename_tb
            // 
            this.filename_tb.Location = new System.Drawing.Point(85, 174);
            this.filename_tb.MaxLength = 16;
            this.filename_tb.Name = "filename_tb";
            this.filename_tb.Size = new System.Drawing.Size(287, 23);
            this.filename_tb.TabIndex = 7;
            // 
            // number_of_leds_nud
            // 
            this.number_of_leds_nud.Location = new System.Drawing.Point(252, 7);
            this.number_of_leds_nud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_of_leds_nud.Name = "number_of_leds_nud";
            this.number_of_leds_nud.Size = new System.Drawing.Size(120, 23);
            this.number_of_leds_nud.TabIndex = 8;
            this.number_of_leds_nud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // phases_nud
            // 
            this.phases_nud.Location = new System.Drawing.Point(252, 39);
            this.phases_nud.Name = "phases_nud";
            this.phases_nud.Size = new System.Drawing.Size(120, 23);
            this.phases_nud.TabIndex = 9;
            this.phases_nud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // delay_nud
            // 
            this.delay_nud.Location = new System.Drawing.Point(252, 79);
            this.delay_nud.Name = "delay_nud";
            this.delay_nud.Size = new System.Drawing.Size(120, 23);
            this.delay_nud.TabIndex = 11;
            this.delay_nud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // force_cb
            // 
            this.force_cb.AutoSize = true;
            this.force_cb.Location = new System.Drawing.Point(117, 141);
            this.force_cb.Name = "force_cb";
            this.force_cb.Size = new System.Drawing.Size(15, 14);
            this.force_cb.TabIndex = 12;
            this.force_cb.UseVisualStyleBackColor = true;
            // 
            // repetitions_tb
            // 
            this.repetitions_tb.Location = new System.Drawing.Point(268, 110);
            this.repetitions_tb.Maximum = 255;
            this.repetitions_tb.Name = "repetitions_tb";
            this.repetitions_tb.Size = new System.Drawing.Size(104, 45);
            this.repetitions_tb.TabIndex = 13;
            // 
            // confirm_b
            // 
            this.confirm_b.Location = new System.Drawing.Point(150, 358);
            this.confirm_b.Name = "confirm_b";
            this.confirm_b.Size = new System.Drawing.Size(100, 31);
            this.confirm_b.TabIndex = 14;
            this.confirm_b.Text = "Confirm";
            this.confirm_b.UseVisualStyleBackColor = true;
            this.confirm_b.Click += new System.EventHandler(this.confirm);
            // 
            // Informations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.confirm_b);
            this.Controls.Add(this.repetitions_tb);
            this.Controls.Add(this.force_cb);
            this.Controls.Add(this.delay_nud);
            this.Controls.Add(this.phases_nud);
            this.Controls.Add(this.number_of_leds_nud);
            this.Controls.Add(this.filename_tb);
            this.Controls.Add(this.name_l);
            this.Controls.Add(this.delay_l);
            this.Controls.Add(this.force_to_play_l);
            this.Controls.Add(this.repetitions_l);
            this.Controls.Add(this.phases_l);
            this.Controls.Add(this.leds_l);
            this.Controls.Add(this.pattern_clb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Informations";
            this.Text = "Informations";
            ((System.ComponentModel.ISupportInitialize)(this.number_of_leds_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phases_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetitions_tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox pattern_clb;
        private Label leds_l;
        private Label phases_l;
        private Label repetitions_l;
        private Label force_to_play_l;
        private Label delay_l;
        private Label name_l;
        private TextBox filename_tb;
        private NumericUpDown number_of_leds_nud;
        private NumericUpDown phases_nud;
        private NumericUpDown delay_nud;
        private CheckBox force_cb;
        private TrackBar repetitions_tb;
        private Button confirm_b;
    }
}