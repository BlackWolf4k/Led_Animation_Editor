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
            this.animation_maker_p = new System.Windows.Forms.Panel();
            this.clear_b = new System.Windows.Forms.Button();
            this.colors_lv = new System.Windows.Forms.ListView();
            this.phases_lv = new System.Windows.Forms.ListView();
            this.color_b = new System.Windows.Forms.Button();
            this.to_l = new System.Windows.Forms.Label();
            this.from_l = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.upload_b = new System.Windows.Forms.Button();
            this.get_animation_b = new System.Windows.Forms.Button();
            this.devices_p = new System.Windows.Forms.Panel();
            this.update_animations_b = new System.Windows.Forms.Button();
            this.animations_lv = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.new_b = new System.Windows.Forms.Button();
            this.animations_p.SuspendLayout();
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
            // animation_maker_p
            // 
            this.animation_maker_p.Controls.Add(this.new_b);
            this.animation_maker_p.Controls.Add(this.clear_b);
            this.animation_maker_p.Controls.Add(this.colors_lv);
            this.animation_maker_p.Controls.Add(this.phases_lv);
            this.animation_maker_p.Controls.Add(this.color_b);
            this.animation_maker_p.Controls.Add(this.to_l);
            this.animation_maker_p.Controls.Add(this.from_l);
            this.animation_maker_p.Controls.Add(this.numericUpDown5);
            this.animation_maker_p.Controls.Add(this.numericUpDown4);
            this.animation_maker_p.Controls.Add(this.upload_b);
            this.animation_maker_p.Location = new System.Drawing.Point(12, 12);
            this.animation_maker_p.Name = "animation_maker_p";
            this.animation_maker_p.Size = new System.Drawing.Size(554, 437);
            this.animation_maker_p.TabIndex = 2;
            // 
            // clear_b
            // 
            this.clear_b.Location = new System.Drawing.Point(406, 402);
            this.clear_b.Name = "clear_b";
            this.clear_b.Size = new System.Drawing.Size(71, 35);
            this.clear_b.TabIndex = 17;
            this.clear_b.Text = "Clear";
            this.clear_b.UseVisualStyleBackColor = true;
            this.clear_b.Click += new System.EventHandler(this.force_set_tables);
            // 
            // colors_lv
            // 
            this.colors_lv.Location = new System.Drawing.Point(102, 0);
            this.colors_lv.Name = "colors_lv";
            this.colors_lv.Size = new System.Drawing.Size(452, 180);
            this.colors_lv.TabIndex = 15;
            this.colors_lv.UseCompatibleStateImageBehavior = false;
            // 
            // phases_lv
            // 
            this.phases_lv.Location = new System.Drawing.Point(0, 0);
            this.phases_lv.Name = "phases_lv";
            this.phases_lv.Size = new System.Drawing.Size(96, 180);
            this.phases_lv.TabIndex = 14;
            this.phases_lv.UseCompatibleStateImageBehavior = false;
            this.phases_lv.SelectedIndexChanged += new System.EventHandler(this.change_displayed_colors);
            // 
            // color_b
            // 
            this.color_b.Location = new System.Drawing.Point(167, 210);
            this.color_b.Name = "color_b";
            this.color_b.Size = new System.Drawing.Size(90, 30);
            this.color_b.TabIndex = 12;
            this.color_b.Text = "Color";
            this.color_b.UseVisualStyleBackColor = true;
            // 
            // to_l
            // 
            this.to_l.AutoSize = true;
            this.to_l.Location = new System.Drawing.Point(38, 248);
            this.to_l.Name = "to_l";
            this.to_l.Size = new System.Drawing.Size(19, 15);
            this.to_l.TabIndex = 11;
            this.to_l.Text = "To";
            // 
            // from_l
            // 
            this.from_l.AutoSize = true;
            this.from_l.Location = new System.Drawing.Point(22, 218);
            this.from_l.Name = "from_l";
            this.from_l.Size = new System.Drawing.Size(35, 15);
            this.from_l.TabIndex = 10;
            this.from_l.Text = "From";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(63, 246);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown5.TabIndex = 6;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(63, 216);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown4.TabIndex = 5;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // upload_b
            // 
            this.upload_b.Location = new System.Drawing.Point(483, 402);
            this.upload_b.Name = "upload_b";
            this.upload_b.Size = new System.Drawing.Size(71, 35);
            this.upload_b.TabIndex = 1;
            this.upload_b.Text = "Upload";
            this.upload_b.UseVisualStyleBackColor = true;
            this.upload_b.Click += new System.EventHandler(this.force_animation_upload);
            // 
            // get_animation_b
            // 
            this.get_animation_b.Location = new System.Drawing.Point(3, 192);
            this.get_animation_b.Name = "get_animation_b";
            this.get_animation_b.Size = new System.Drawing.Size(194, 23);
            this.get_animation_b.TabIndex = 16;
            this.get_animation_b.Text = "Get";
            this.get_animation_b.UseVisualStyleBackColor = true;
            this.get_animation_b.Click += new System.EventHandler(this.force_get_animation);
            // 
            // devices_p
            // 
            this.devices_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.devices_p.Controls.Add(this.update_animations_b);
            this.devices_p.Controls.Add(this.get_animation_b);
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
            this.animations_lv.Size = new System.Drawing.Size(197, 157);
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
            // new_b
            // 
            this.new_b.Location = new System.Drawing.Point(0, 402);
            this.new_b.Name = "new_b";
            this.new_b.Size = new System.Drawing.Size(71, 35);
            this.new_b.TabIndex = 18;
            this.new_b.Text = "New";
            this.new_b.UseVisualStyleBackColor = true;
            this.new_b.Click += new System.EventHandler(this.make_new_animation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.devices_p);
            this.Controls.Add(this.animation_maker_p);
            this.Controls.Add(this.animations_p);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.animations_p.ResumeLayout(false);
            this.animations_p.PerformLayout();
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
        private Panel animation_maker_p;
        private Label to_l;
        private Label from_l;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private Button upload_b;
        private Panel devices_p;
        private ListView animations_lv;
        private TextBox textBox2;
        private Button color_b;
        private ColorDialog colorDialog1;
        private Button update_b;
        private Button update_animations_b;
        private ListView colors_lv;
        private ListView phases_lv;
        private Button get_animation_b;
        private Button clear_b;
        private Button new_b;
    }
}