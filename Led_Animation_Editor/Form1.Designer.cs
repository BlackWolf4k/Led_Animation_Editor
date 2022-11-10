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
            this.animation_settings_p = new System.Windows.Forms.Panel();
            this.animation_maker_p = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.devices_p = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.delay_nud = new System.Windows.Forms.NumericUpDown();
            this.repetitions_nud = new System.Windows.Forms.NumericUpDown();
            this.phases_nud = new System.Windows.Forms.NumericUpDown();
            this.delay_l = new System.Windows.Forms.Label();
            this.phases_l = new System.Windows.Forms.Label();
            this.repetitions_l = new System.Windows.Forms.Label();
            this.save_b = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.color_red_l = new System.Windows.Forms.Label();
            this.color_green_l = new System.Windows.Forms.Label();
            this.color_blue_l = new System.Windows.Forms.Label();
            this.from_l = new System.Windows.Forms.Label();
            this.to_l = new System.Windows.Forms.Label();
            this.animations_p.SuspendLayout();
            this.animation_settings_p.SuspendLayout();
            this.animation_maker_p.SuspendLayout();
            this.devices_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetitions_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phases_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // animations_p
            // 
            this.animations_p.Controls.Add(this.textBox1);
            this.animations_p.Controls.Add(this.listView1);
            this.animations_p.Location = new System.Drawing.Point(572, 12);
            this.animations_p.Name = "animations_p";
            this.animations_p.Size = new System.Drawing.Size(200, 215);
            this.animations_p.TabIndex = 0;
            // 
            // animation_settings_p
            // 
            this.animation_settings_p.Controls.Add(this.repetitions_l);
            this.animation_settings_p.Controls.Add(this.phases_l);
            this.animation_settings_p.Controls.Add(this.delay_l);
            this.animation_settings_p.Controls.Add(this.phases_nud);
            this.animation_settings_p.Controls.Add(this.delay_nud);
            this.animation_settings_p.Controls.Add(this.repetitions_nud);
            this.animation_settings_p.Location = new System.Drawing.Point(12, 12);
            this.animation_settings_p.Name = "animation_settings_p";
            this.animation_settings_p.Size = new System.Drawing.Size(554, 48);
            this.animation_settings_p.TabIndex = 1;
            // 
            // animation_maker_p
            // 
            this.animation_maker_p.Controls.Add(this.to_l);
            this.animation_maker_p.Controls.Add(this.from_l);
            this.animation_maker_p.Controls.Add(this.color_blue_l);
            this.animation_maker_p.Controls.Add(this.color_green_l);
            this.animation_maker_p.Controls.Add(this.color_red_l);
            this.animation_maker_p.Controls.Add(this.numericUpDown5);
            this.animation_maker_p.Controls.Add(this.numericUpDown4);
            this.animation_maker_p.Controls.Add(this.numericUpDown3);
            this.animation_maker_p.Controls.Add(this.numericUpDown2);
            this.animation_maker_p.Controls.Add(this.numericUpDown1);
            this.animation_maker_p.Controls.Add(this.save_b);
            this.animation_maker_p.Controls.Add(this.listBox1);
            this.animation_maker_p.Location = new System.Drawing.Point(12, 66);
            this.animation_maker_p.Name = "animation_maker_p";
            this.animation_maker_p.Size = new System.Drawing.Size(554, 383);
            this.animation_maker_p.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 214);
            this.listBox1.TabIndex = 0;
            // 
            // devices_p
            // 
            this.devices_p.Controls.Add(this.listView2);
            this.devices_p.Controls.Add(this.textBox2);
            this.devices_p.Location = new System.Drawing.Point(572, 233);
            this.devices_p.Name = "devices_p";
            this.devices_p.Size = new System.Drawing.Size(200, 215);
            this.devices_p.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(197, 183);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 23);
            this.textBox2.TabIndex = 0;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(3, 29);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(194, 187);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // delay_nud
            // 
            this.delay_nud.Location = new System.Drawing.Point(438, 12);
            this.delay_nud.Name = "delay_nud";
            this.delay_nud.Size = new System.Drawing.Size(70, 23);
            this.delay_nud.TabIndex = 0;
            // 
            // repetitions_nud
            // 
            this.repetitions_nud.Location = new System.Drawing.Point(283, 12);
            this.repetitions_nud.Name = "repetitions_nud";
            this.repetitions_nud.Size = new System.Drawing.Size(70, 23);
            this.repetitions_nud.TabIndex = 1;
            // 
            // phases_nud
            // 
            this.phases_nud.Location = new System.Drawing.Point(107, 12);
            this.phases_nud.Name = "phases_nud";
            this.phases_nud.Size = new System.Drawing.Size(70, 23);
            this.phases_nud.TabIndex = 2;
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
            // phases_l
            // 
            this.phases_l.AutoSize = true;
            this.phases_l.Location = new System.Drawing.Point(38, 14);
            this.phases_l.Name = "phases_l";
            this.phases_l.Size = new System.Drawing.Size(43, 15);
            this.phases_l.TabIndex = 4;
            this.phases_l.Text = "Phases";
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
            // save_b
            // 
            this.save_b.Location = new System.Drawing.Point(465, 344);
            this.save_b.Name = "save_b";
            this.save_b.Size = new System.Drawing.Size(89, 39);
            this.save_b.TabIndex = 1;
            this.save_b.Text = "Save";
            this.save_b.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(211, 246);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(211, 276);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(211, 305);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown3.TabIndex = 4;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(70, 246);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown4.TabIndex = 5;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(70, 276);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown5.TabIndex = 6;
            // 
            // color_red_l
            // 
            this.color_red_l.AutoSize = true;
            this.color_red_l.Location = new System.Drawing.Point(178, 246);
            this.color_red_l.Name = "color_red_l";
            this.color_red_l.Size = new System.Drawing.Size(27, 15);
            this.color_red_l.TabIndex = 7;
            this.color_red_l.Text = "Red";
            // 
            // color_green_l
            // 
            this.color_green_l.AutoSize = true;
            this.color_green_l.Location = new System.Drawing.Point(167, 276);
            this.color_green_l.Name = "color_green_l";
            this.color_green_l.Size = new System.Drawing.Size(38, 15);
            this.color_green_l.TabIndex = 8;
            this.color_green_l.Text = "Green";
            // 
            // color_blue_l
            // 
            this.color_blue_l.AutoSize = true;
            this.color_blue_l.Location = new System.Drawing.Point(175, 305);
            this.color_blue_l.Name = "color_blue_l";
            this.color_blue_l.Size = new System.Drawing.Size(30, 15);
            this.color_blue_l.TabIndex = 9;
            this.color_blue_l.Text = "Blue";
            // 
            // from_l
            // 
            this.from_l.AutoSize = true;
            this.from_l.Location = new System.Drawing.Point(29, 248);
            this.from_l.Name = "from_l";
            this.from_l.Size = new System.Drawing.Size(35, 15);
            this.from_l.TabIndex = 10;
            this.from_l.Text = "From";
            // 
            // to_l
            // 
            this.to_l.AutoSize = true;
            this.to_l.Location = new System.Drawing.Point(45, 278);
            this.to_l.Name = "to_l";
            this.to_l.Size = new System.Drawing.Size(19, 15);
            this.to_l.TabIndex = 11;
            this.to_l.Text = "To";
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.animations_p.ResumeLayout(false);
            this.animations_p.PerformLayout();
            this.animation_settings_p.ResumeLayout(false);
            this.animation_settings_p.PerformLayout();
            this.animation_maker_p.ResumeLayout(false);
            this.animation_maker_p.PerformLayout();
            this.devices_p.ResumeLayout(false);
            this.devices_p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetitions_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phases_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel animations_p;
        private TextBox textBox1;
        private ListView listView1;
        private Panel animation_settings_p;
        private Label repetitions_l;
        private Label phases_l;
        private Label delay_l;
        private NumericUpDown phases_nud;
        private NumericUpDown delay_nud;
        private NumericUpDown repetitions_nud;
        private Panel animation_maker_p;
        private Label to_l;
        private Label from_l;
        private Label color_blue_l;
        private Label color_green_l;
        private Label color_red_l;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button save_b;
        private ListBox listBox1;
        private Panel devices_p;
        private ListView listView2;
        private TextBox textBox2;
    }
}