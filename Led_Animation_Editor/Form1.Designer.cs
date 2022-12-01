namespace Led_Animation_Editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animations_p = new System.Windows.Forms.Panel();
            this.update_b = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.slaves_lv = new System.Windows.Forms.ListView();
            this.animation_settings_p = new System.Windows.Forms.Panel();
            this.repetitions_tb = new System.Windows.Forms.TrackBar();
            this.repetitions_l = new System.Windows.Forms.Label();
            this.phases_l = new System.Windows.Forms.Label();
            this.delay_l = new System.Windows.Forms.Label();
            this.phases_nud = new System.Windows.Forms.NumericUpDown();
            this.delay_nud = new System.Windows.Forms.NumericUpDown();
            this.animation_maker_p = new System.Windows.Forms.Panel();
            this.colors_lv = new System.Windows.Forms.ListView();
            this.phases_lv = new System.Windows.Forms.ListView();
            this.color_b = new System.Windows.Forms.Button();
            this.to_l = new System.Windows.Forms.Label();
            this.from_l = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.save_b = new System.Windows.Forms.Button();
            this.devices_p = new System.Windows.Forms.Panel();
            this.update_animations_b = new System.Windows.Forms.Button();
            this.animations_lv = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.get_animation_b = new System.Windows.Forms.Button();
            this.animations_p.SuspendLayout();
            this.animation_settings_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repetitions_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phases_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_nud)).BeginInit();
            this.animation_maker_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.devices_p.SuspendLayout();
            this.SuspendLayout();
            // 
            // animations_p
            // 
            this.animations_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animations_p.Controls.Add(this.update_b);
            this.animations_p.Controls.Add(this.textBox1);
            this.animations_p.Controls.Add(this.slaves_lv);
            this.animations_p.Location = new System.Drawing.Point(572, 12);
            this.animations_p.Name = "animations_p";
            this.animations_p.Size = new System.Drawing.Size(200, 215);
            this.animations_p.TabIndex = 0;
            // 
            // update_b
            // 
            this.update_b.Location = new System.Drawing.Point(142, 0);
            this.update_b.Name = "update_b";
            this.update_b.Size = new System.Drawing.Size(58, 23);
            this.update_b.TabIndex = 4;
            this.update_b.Text = "Update";
            this.update_b.UseVisualStyleBackColor = true;
            this.update_b.Click += new System.EventHandler(this.force_slave_update);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 23);
            this.textBox1.TabIndex = 1;
            // 
            // slaves_lv
            // 
            this.slaves_lv.FullRowSelect = true;
            this.slaves_lv.Location = new System.Drawing.Point(0, 29);
            this.slaves_lv.Name = "slaves_lv";
            this.slaves_lv.Size = new System.Drawing.Size(197, 186);
            this.slaves_lv.TabIndex = 0;
            this.slaves_lv.UseCompatibleStateImageBehavior = false;
            this.slaves_lv.SelectedIndexChanged += new System.EventHandler(this.select_slave);
            // 
            // animation_settings_p
            // 
            this.animation_settings_p.Controls.Add(this.repetitions_tb);
            this.animation_settings_p.Controls.Add(this.repetitions_l);
            this.animation_settings_p.Controls.Add(this.phases_l);
            this.animation_settings_p.Controls.Add(this.delay_l);
            this.animation_settings_p.Controls.Add(this.phases_nud);
            this.animation_settings_p.Controls.Add(this.delay_nud);
            this.animation_settings_p.Location = new System.Drawing.Point(12, 12);
            this.animation_settings_p.Name = "animation_settings_p";
            this.animation_settings_p.Size = new System.Drawing.Size(554, 48);
            this.animation_settings_p.TabIndex = 1;
            // 
            // repetitions_tb
            // 
            this.repetitions_tb.Location = new System.Drawing.Point(294, 3);
            this.repetitions_tb.Maximum = 255;
            this.repetitions_tb.Name = "repetitions_tb";
            this.repetitions_tb.Size = new System.Drawing.Size(74, 45);
            this.repetitions_tb.TabIndex = 6;
            // 
            // repetitions_l
            // 
            this.repetitions_l.AutoSize = true;
            this.repetitions_l.Location = new System.Drawing.Point(208, 14);
            this.repetitions_l.Name = "repetitions_l";
            this.repetitions_l.Size = new System.Drawing.Size(69, 15);
            this.repetitions_l.TabIndex = 5;
            this.repetitions_l.Text = "Repetitions:";
            // 
            // phases_l
            // 
            this.phases_l.AutoSize = true;
            this.phases_l.Location = new System.Drawing.Point(38, 14);
            this.phases_l.Name = "phases_l";
            this.phases_l.Size = new System.Drawing.Size(43, 15);
            this.phases_l.TabIndex = 4;
            this.phases_l.Text = "Phases";
            // 
            // delay_l
            // 
            this.delay_l.AutoSize = true;
            this.delay_l.Location = new System.Drawing.Point(396, 14);
            this.delay_l.Name = "delay_l";
            this.delay_l.Size = new System.Drawing.Size(36, 15);
            this.delay_l.TabIndex = 3;
            this.delay_l.Text = "Delay";
            // 
            // phases_nud
            // 
            this.phases_nud.Location = new System.Drawing.Point(107, 12);
            this.phases_nud.Name = "phases_nud";
            this.phases_nud.Size = new System.Drawing.Size(70, 23);
            this.phases_nud.TabIndex = 2;
            this.phases_nud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // delay_nud
            // 
            this.delay_nud.Location = new System.Drawing.Point(438, 12);
            this.delay_nud.Name = "delay_nud";
            this.delay_nud.Size = new System.Drawing.Size(70, 23);
            this.delay_nud.TabIndex = 0;
            this.delay_nud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // animation_maker_p
            // 
            this.animation_maker_p.Controls.Add(this.get_animation_b);
            this.animation_maker_p.Controls.Add(this.colors_lv);
            this.animation_maker_p.Controls.Add(this.phases_lv);
            this.animation_maker_p.Controls.Add(this.color_b);
            this.animation_maker_p.Controls.Add(this.to_l);
            this.animation_maker_p.Controls.Add(this.from_l);
            this.animation_maker_p.Controls.Add(this.numericUpDown5);
            this.animation_maker_p.Controls.Add(this.numericUpDown4);
            this.animation_maker_p.Controls.Add(this.save_b);
            this.animation_maker_p.Location = new System.Drawing.Point(12, 66);
            this.animation_maker_p.Name = "animation_maker_p";
            this.animation_maker_p.Size = new System.Drawing.Size(554, 383);
            this.animation_maker_p.TabIndex = 2;
            // 
            // colors_lv
            // 
            this.colors_lv.Location = new System.Drawing.Point(0, 199);
            this.colors_lv.Name = "colors_lv";
            this.colors_lv.Size = new System.Drawing.Size(395, 184);
            this.colors_lv.TabIndex = 15;
            this.colors_lv.UseCompatibleStateImageBehavior = false;
            // 
            // phases_lv
            // 
            this.phases_lv.Location = new System.Drawing.Point(0, 0);
            this.phases_lv.Name = "phases_lv";
            this.phases_lv.Size = new System.Drawing.Size(395, 184);
            this.phases_lv.TabIndex = 14;
            this.phases_lv.UseCompatibleStateImageBehavior = false;
            // 
            // color_b
            // 
            this.color_b.Location = new System.Drawing.Point(441, 103);
            this.color_b.Name = "color_b";
            this.color_b.Size = new System.Drawing.Size(90, 30);
            this.color_b.TabIndex = 12;
            this.color_b.Text = "Color";
            this.color_b.UseVisualStyleBackColor = true;
            // 
            // to_l
            // 
            this.to_l.AutoSize = true;
            this.to_l.Location = new System.Drawing.Point(440, 58);
            this.to_l.Name = "to_l";
            this.to_l.Size = new System.Drawing.Size(19, 15);
            this.to_l.TabIndex = 11;
            this.to_l.Text = "To";
            // 
            // from_l
            // 
            this.from_l.AutoSize = true;
            this.from_l.Location = new System.Drawing.Point(424, 28);
            this.from_l.Name = "from_l";
            this.from_l.Size = new System.Drawing.Size(35, 15);
            this.from_l.TabIndex = 10;
            this.from_l.Text = "From";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(465, 56);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown5.TabIndex = 6;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(465, 26);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown4.TabIndex = 5;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // save_b
            // 
            this.save_b.Location = new System.Drawing.Point(465, 344);
            this.save_b.Name = "save_b";
            this.save_b.Size = new System.Drawing.Size(89, 39);
            this.save_b.TabIndex = 1;
            this.save_b.Text = "Save";
            this.save_b.UseVisualStyleBackColor = true;
            // 
            // devices_p
            // 
            this.devices_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.devices_p.Controls.Add(this.update_animations_b);
            this.devices_p.Controls.Add(this.animations_lv);
            this.devices_p.Controls.Add(this.textBox2);
            this.devices_p.Location = new System.Drawing.Point(572, 233);
            this.devices_p.Name = "devices_p";
            this.devices_p.Size = new System.Drawing.Size(200, 215);
            this.devices_p.TabIndex = 3;
            // 
            // update_animations_b
            // 
            this.update_animations_b.Enabled = false;
            this.update_animations_b.Location = new System.Drawing.Point(142, 0);
            this.update_animations_b.Name = "update_animations_b";
            this.update_animations_b.Size = new System.Drawing.Size(58, 23);
            this.update_animations_b.TabIndex = 14;
            this.update_animations_b.Text = "Update";
            this.update_animations_b.UseVisualStyleBackColor = true;
            this.update_animations_b.Click += new System.EventHandler(this.force_animations_update);
            // 
            // animations_lv
            // 
            this.animations_lv.FullRowSelect = true;
            this.animations_lv.Location = new System.Drawing.Point(0, 29);
            this.animations_lv.Name = "animations_lv";
            this.animations_lv.Size = new System.Drawing.Size(197, 187);
            this.animations_lv.TabIndex = 1;
            this.animations_lv.UseCompatibleStateImageBehavior = false;
            this.animations_lv.SelectedIndexChanged += new System.EventHandler(this.select_animation);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 23);
            this.textBox2.TabIndex = 0;
            // 
            // get_animation_b
            // 
            this.get_animation_b.Location = new System.Drawing.Point(453, 167);
            this.get_animation_b.Name = "get_animation_b";
            this.get_animation_b.Size = new System.Drawing.Size(98, 45);
            this.get_animation_b.TabIndex = 16;
            this.get_animation_b.Text = "Get";
            this.get_animation_b.UseVisualStyleBackColor = true;
            this.get_animation_b.Click += new System.EventHandler(this.force_get_animation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.devices_p);
            this.Controls.Add(this.animation_maker_p);
            this.Controls.Add(this.animation_settings_p);
            this.Controls.Add(this.animations_p);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.animations_p.ResumeLayout(false);
            this.animations_p.PerformLayout();
            this.animation_settings_p.ResumeLayout(false);
            this.animation_settings_p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repetitions_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phases_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_nud)).EndInit();
            this.animation_maker_p.ResumeLayout(false);
            this.animation_maker_p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.devices_p.ResumeLayout(false);
            this.devices_p.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel animations_p;
        private TextBox textBox1;
        private ListView slaves_lv;
        private Panel animation_settings_p;
        private Label repetitions_l;
        private Label phases_l;
        private Label delay_l;
        private NumericUpDown phases_nud;
        private NumericUpDown delay_nud;
        private Panel animation_maker_p;
        private Label to_l;
        private Label from_l;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private Button save_b;
        private Panel devices_p;
        private ListView animations_lv;
        private TextBox textBox2;
        private TrackBar repetitions_tb;
        private Button color_b;
        private ColorDialog colorDialog1;
        private Button update_b;
        private Button update_animations_b;
        private ListView colors_lv;
        private ListView phases_lv;
        private Button get_animation_b;
    }
}