namespace Farm_Tracker
{
    partial class Equipment
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
            this.equipment_ListBox = new System.Windows.Forms.ListBox();
            this.equipment_PictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipment_ID_Label = new System.Windows.Forms.Label();
            this.repairs_ListBox = new System.Windows.Forms.ListBox();
            this.breakdownsTableAdapter1 = new Farm_Tracker.Farm_TrackerDataSetTableAdapters.BreakdownsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.year_Label = new System.Windows.Forms.Label();
            this.year_TextBox = new System.Windows.Forms.TextBox();
            this.equipment_Type_Label = new System.Windows.Forms.Label();
            this.equipment_Type_TextBox = new System.Windows.Forms.TextBox();
            this.brand_Label = new System.Windows.Forms.Label();
            this.brand_TextBox = new System.Windows.Forms.TextBox();
            this.serial_Number_Label = new System.Windows.Forms.Label();
            this.serial_Number_Textbox = new System.Windows.Forms.TextBox();
            this.model_Number_Label = new System.Windows.Forms.Label();
            this.model_Number_TextBox = new System.Windows.Forms.TextBox();
            this.hours_Label = new System.Windows.Forms.Label();
            this.hours_TextBox = new System.Windows.Forms.TextBox();
            this.horsepower_Label = new System.Windows.Forms.Label();
            this.horsepower_TextBox = new System.Windows.Forms.TextBox();
            this.width_Label = new System.Windows.Forms.Label();
            this.width_TextBox = new System.Windows.Forms.TextBox();
            this.number_Of_Tanks_Label = new System.Windows.Forms.Label();
            this.number_Of_Tanks_TextBox = new System.Windows.Forms.TextBox();
            this.tank_Size_Label = new System.Windows.Forms.Label();
            this.tank_Size_TextBox = new System.Windows.Forms.TextBox();
            this.shank_Spacing_Label = new System.Windows.Forms.Label();
            this.shank_Spacing_TextBox = new System.Windows.Forms.TextBox();
            this.save_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.update_Equipment_Button = new System.Windows.Forms.Button();
            this.new_Equipment_Button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.add_Image_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.equipment_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // equipment_ListBox
            // 
            this.equipment_ListBox.BackColor = System.Drawing.Color.LightYellow;
            this.equipment_ListBox.FormattingEnabled = true;
            this.equipment_ListBox.ItemHeight = 25;
            this.equipment_ListBox.Location = new System.Drawing.Point(13, 13);
            this.equipment_ListBox.Name = "equipment_ListBox";
            this.equipment_ListBox.Size = new System.Drawing.Size(332, 704);
            this.equipment_ListBox.TabIndex = 0;
            this.equipment_ListBox.SelectedIndexChanged += new System.EventHandler(this.equipment_ListBox_SelectedIndexChanged);
            // 
            // equipment_PictureBox
            // 
            this.equipment_PictureBox.Location = new System.Drawing.Point(351, 13);
            this.equipment_PictureBox.Name = "equipment_PictureBox";
            this.equipment_PictureBox.Size = new System.Drawing.Size(286, 244);
            this.equipment_PictureBox.TabIndex = 1;
            this.equipment_PictureBox.TabStop = false;
            this.equipment_PictureBox.Click += new System.EventHandler(this.equipment_PictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipment ID";
            // 
            // equipment_ID_Label
            // 
            this.equipment_ID_Label.AutoSize = true;
            this.equipment_ID_Label.Location = new System.Drawing.Point(846, 26);
            this.equipment_ID_Label.Name = "equipment_ID_Label";
            this.equipment_ID_Label.Size = new System.Drawing.Size(140, 25);
            this.equipment_ID_Label.TabIndex = 3;
            this.equipment_ID_Label.Text = "Equipment ID";
            // 
            // repairs_ListBox
            // 
            this.repairs_ListBox.BackColor = System.Drawing.Color.LightYellow;
            this.repairs_ListBox.FormattingEnabled = true;
            this.repairs_ListBox.ItemHeight = 25;
            this.repairs_ListBox.Location = new System.Drawing.Point(347, 313);
            this.repairs_ListBox.Name = "repairs_ListBox";
            this.repairs_ListBox.Size = new System.Drawing.Size(290, 404);
            this.repairs_ListBox.TabIndex = 4;
            // 
            // breakdownsTableAdapter1
            // 
            this.breakdownsTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Equipment Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(761, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Serial Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Model Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(750, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(692, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Horsepower";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(752, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Width";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(643, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Number of Tanks";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(711, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tank Size";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(662, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Shank Spacing";
            // 
            // year_Label
            // 
            this.year_Label.AutoSize = true;
            this.year_Label.Location = new System.Drawing.Point(846, 102);
            this.year_Label.Name = "year_Label";
            this.year_Label.Size = new System.Drawing.Size(58, 25);
            this.year_Label.TabIndex = 16;
            this.year_Label.Text = "Year";
            // 
            // year_TextBox
            // 
            this.year_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.year_TextBox.Location = new System.Drawing.Point(851, 102);
            this.year_TextBox.Name = "year_TextBox";
            this.year_TextBox.Size = new System.Drawing.Size(163, 31);
            this.year_TextBox.TabIndex = 2;
            this.year_TextBox.Visible = false;
            // 
            // equipment_Type_Label
            // 
            this.equipment_Type_Label.AutoSize = true;
            this.equipment_Type_Label.Location = new System.Drawing.Point(846, 65);
            this.equipment_Type_Label.Name = "equipment_Type_Label";
            this.equipment_Type_Label.Size = new System.Drawing.Size(168, 25);
            this.equipment_Type_Label.TabIndex = 18;
            this.equipment_Type_Label.Text = "Equipment Type";
            // 
            // equipment_Type_TextBox
            // 
            this.equipment_Type_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.equipment_Type_TextBox.Location = new System.Drawing.Point(851, 65);
            this.equipment_Type_TextBox.Name = "equipment_Type_TextBox";
            this.equipment_Type_TextBox.Size = new System.Drawing.Size(163, 31);
            this.equipment_Type_TextBox.TabIndex = 1;
            this.equipment_Type_TextBox.Visible = false;
            // 
            // brand_Label
            // 
            this.brand_Label.AutoSize = true;
            this.brand_Label.Location = new System.Drawing.Point(846, 142);
            this.brand_Label.Name = "brand_Label";
            this.brand_Label.Size = new System.Drawing.Size(69, 25);
            this.brand_Label.TabIndex = 20;
            this.brand_Label.Text = "Brand";
            // 
            // brand_TextBox
            // 
            this.brand_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.brand_TextBox.Location = new System.Drawing.Point(851, 139);
            this.brand_TextBox.Name = "brand_TextBox";
            this.brand_TextBox.Size = new System.Drawing.Size(163, 31);
            this.brand_TextBox.TabIndex = 3;
            this.brand_TextBox.Visible = false;
            // 
            // serial_Number_Label
            // 
            this.serial_Number_Label.AutoSize = true;
            this.serial_Number_Label.Location = new System.Drawing.Point(846, 179);
            this.serial_Number_Label.Name = "serial_Number_Label";
            this.serial_Number_Label.Size = new System.Drawing.Size(148, 25);
            this.serial_Number_Label.TabIndex = 22;
            this.serial_Number_Label.Text = "Serial Number";
            // 
            // serial_Number_Textbox
            // 
            this.serial_Number_Textbox.BackColor = System.Drawing.Color.LightYellow;
            this.serial_Number_Textbox.Location = new System.Drawing.Point(851, 176);
            this.serial_Number_Textbox.Name = "serial_Number_Textbox";
            this.serial_Number_Textbox.Size = new System.Drawing.Size(163, 31);
            this.serial_Number_Textbox.TabIndex = 4;
            this.serial_Number_Textbox.Visible = false;
            // 
            // model_Number_Label
            // 
            this.model_Number_Label.AutoSize = true;
            this.model_Number_Label.Location = new System.Drawing.Point(846, 216);
            this.model_Number_Label.Name = "model_Number_Label";
            this.model_Number_Label.Size = new System.Drawing.Size(152, 25);
            this.model_Number_Label.TabIndex = 24;
            this.model_Number_Label.Text = "Model Number";
            // 
            // model_Number_TextBox
            // 
            this.model_Number_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.model_Number_TextBox.Location = new System.Drawing.Point(851, 213);
            this.model_Number_TextBox.Name = "model_Number_TextBox";
            this.model_Number_TextBox.Size = new System.Drawing.Size(163, 31);
            this.model_Number_TextBox.TabIndex = 5;
            this.model_Number_TextBox.Visible = false;
            // 
            // hours_Label
            // 
            this.hours_Label.AutoSize = true;
            this.hours_Label.Location = new System.Drawing.Point(855, 253);
            this.hours_Label.Name = "hours_Label";
            this.hours_Label.Size = new System.Drawing.Size(69, 25);
            this.hours_Label.TabIndex = 26;
            this.hours_Label.Text = "Hours";
            // 
            // hours_TextBox
            // 
            this.hours_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.hours_TextBox.Location = new System.Drawing.Point(851, 250);
            this.hours_TextBox.Name = "hours_TextBox";
            this.hours_TextBox.Size = new System.Drawing.Size(163, 31);
            this.hours_TextBox.TabIndex = 6;
            this.hours_TextBox.Visible = false;
            // 
            // horsepower_Label
            // 
            this.horsepower_Label.AutoSize = true;
            this.horsepower_Label.Location = new System.Drawing.Point(846, 287);
            this.horsepower_Label.Name = "horsepower_Label";
            this.horsepower_Label.Size = new System.Drawing.Size(127, 25);
            this.horsepower_Label.TabIndex = 28;
            this.horsepower_Label.Text = "Horsepower";
            // 
            // horsepower_TextBox
            // 
            this.horsepower_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.horsepower_TextBox.Location = new System.Drawing.Point(851, 287);
            this.horsepower_TextBox.Name = "horsepower_TextBox";
            this.horsepower_TextBox.Size = new System.Drawing.Size(163, 31);
            this.horsepower_TextBox.TabIndex = 7;
            this.horsepower_TextBox.Visible = false;
            // 
            // width_Label
            // 
            this.width_Label.AutoSize = true;
            this.width_Label.Location = new System.Drawing.Point(846, 327);
            this.width_Label.Name = "width_Label";
            this.width_Label.Size = new System.Drawing.Size(67, 25);
            this.width_Label.TabIndex = 30;
            this.width_Label.Text = "Width";
            // 
            // width_TextBox
            // 
            this.width_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.width_TextBox.Location = new System.Drawing.Point(851, 324);
            this.width_TextBox.Name = "width_TextBox";
            this.width_TextBox.Size = new System.Drawing.Size(163, 31);
            this.width_TextBox.TabIndex = 8;
            this.width_TextBox.Visible = false;
            // 
            // number_Of_Tanks_Label
            // 
            this.number_Of_Tanks_Label.AutoSize = true;
            this.number_Of_Tanks_Label.Location = new System.Drawing.Point(846, 364);
            this.number_Of_Tanks_Label.Name = "number_Of_Tanks_Label";
            this.number_Of_Tanks_Label.Size = new System.Drawing.Size(176, 25);
            this.number_Of_Tanks_Label.TabIndex = 32;
            this.number_Of_Tanks_Label.Text = "Number of Tanks";
            // 
            // number_Of_Tanks_TextBox
            // 
            this.number_Of_Tanks_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.number_Of_Tanks_TextBox.Location = new System.Drawing.Point(851, 361);
            this.number_Of_Tanks_TextBox.Name = "number_Of_Tanks_TextBox";
            this.number_Of_Tanks_TextBox.Size = new System.Drawing.Size(163, 31);
            this.number_Of_Tanks_TextBox.TabIndex = 9;
            this.number_Of_Tanks_TextBox.Visible = false;
            // 
            // tank_Size_Label
            // 
            this.tank_Size_Label.AutoSize = true;
            this.tank_Size_Label.Location = new System.Drawing.Point(846, 404);
            this.tank_Size_Label.Name = "tank_Size_Label";
            this.tank_Size_Label.Size = new System.Drawing.Size(108, 25);
            this.tank_Size_Label.TabIndex = 34;
            this.tank_Size_Label.Text = "Tank Size";
            // 
            // tank_Size_TextBox
            // 
            this.tank_Size_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.tank_Size_TextBox.Location = new System.Drawing.Point(851, 398);
            this.tank_Size_TextBox.Name = "tank_Size_TextBox";
            this.tank_Size_TextBox.Size = new System.Drawing.Size(163, 31);
            this.tank_Size_TextBox.TabIndex = 10;
            this.tank_Size_TextBox.Visible = false;
            // 
            // shank_Spacing_Label
            // 
            this.shank_Spacing_Label.AutoSize = true;
            this.shank_Spacing_Label.Location = new System.Drawing.Point(846, 441);
            this.shank_Spacing_Label.Name = "shank_Spacing_Label";
            this.shank_Spacing_Label.Size = new System.Drawing.Size(157, 25);
            this.shank_Spacing_Label.TabIndex = 36;
            this.shank_Spacing_Label.Text = "Shank Spacing";
            // 
            // shank_Spacing_TextBox
            // 
            this.shank_Spacing_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.shank_Spacing_TextBox.Location = new System.Drawing.Point(851, 435);
            this.shank_Spacing_TextBox.Name = "shank_Spacing_TextBox";
            this.shank_Spacing_TextBox.Size = new System.Drawing.Size(163, 31);
            this.shank_Spacing_TextBox.TabIndex = 11;
            this.shank_Spacing_TextBox.Visible = false;
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.save_Button.Location = new System.Drawing.Point(851, 481);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(163, 39);
            this.save_Button.TabIndex = 12;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = false;
            this.save_Button.Visible = false;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.cancel_Button.Location = new System.Drawing.Point(851, 526);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(163, 39);
            this.cancel_Button.TabIndex = 13;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = false;
            this.cancel_Button.Visible = false;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.delete_Button.Location = new System.Drawing.Point(851, 571);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(163, 39);
            this.delete_Button.TabIndex = 14;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = false;
            this.delete_Button.Visible = false;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // update_Equipment_Button
            // 
            this.update_Equipment_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.update_Equipment_Button.Location = new System.Drawing.Point(656, 678);
            this.update_Equipment_Button.Name = "update_Equipment_Button";
            this.update_Equipment_Button.Size = new System.Drawing.Size(163, 39);
            this.update_Equipment_Button.TabIndex = 16;
            this.update_Equipment_Button.Text = "Update";
            this.update_Equipment_Button.UseVisualStyleBackColor = false;
            this.update_Equipment_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // new_Equipment_Button
            // 
            this.new_Equipment_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.new_Equipment_Button.Location = new System.Drawing.Point(851, 678);
            this.new_Equipment_Button.Name = "new_Equipment_Button";
            this.new_Equipment_Button.Size = new System.Drawing.Size(163, 39);
            this.new_Equipment_Button.TabIndex = 15;
            this.new_Equipment_Button.Text = "New";
            this.new_Equipment_Button.UseVisualStyleBackColor = false;
            this.new_Equipment_Button.Click += new System.EventHandler(this.new_Equipment_Button_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 25);
            this.label13.TabIndex = 37;
            this.label13.Text = "Repair History";
            // 
            // add_Image_Button
            // 
            this.add_Image_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.add_Image_Button.Location = new System.Drawing.Point(656, 481);
            this.add_Image_Button.Name = "add_Image_Button";
            this.add_Image_Button.Size = new System.Drawing.Size(145, 39);
            this.add_Image_Button.TabIndex = 38;
            this.add_Image_Button.Text = "Add Image";
            this.add_Image_Button.UseVisualStyleBackColor = false;
            this.add_Image_Button.Visible = false;
            this.add_Image_Button.Click += new System.EventHandler(this.add_Image_Button_Click);
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1026, 757);
            this.Controls.Add(this.add_Image_Button);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.new_Equipment_Button);
            this.Controls.Add(this.update_Equipment_Button);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.shank_Spacing_TextBox);
            this.Controls.Add(this.shank_Spacing_Label);
            this.Controls.Add(this.tank_Size_TextBox);
            this.Controls.Add(this.tank_Size_Label);
            this.Controls.Add(this.number_Of_Tanks_TextBox);
            this.Controls.Add(this.number_Of_Tanks_Label);
            this.Controls.Add(this.width_TextBox);
            this.Controls.Add(this.width_Label);
            this.Controls.Add(this.horsepower_TextBox);
            this.Controls.Add(this.horsepower_Label);
            this.Controls.Add(this.hours_TextBox);
            this.Controls.Add(this.hours_Label);
            this.Controls.Add(this.model_Number_TextBox);
            this.Controls.Add(this.model_Number_Label);
            this.Controls.Add(this.serial_Number_Textbox);
            this.Controls.Add(this.serial_Number_Label);
            this.Controls.Add(this.brand_TextBox);
            this.Controls.Add(this.brand_Label);
            this.Controls.Add(this.equipment_Type_TextBox);
            this.Controls.Add(this.equipment_Type_Label);
            this.Controls.Add(this.year_TextBox);
            this.Controls.Add(this.year_Label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.repairs_ListBox);
            this.Controls.Add(this.equipment_ID_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipment_PictureBox);
            this.Controls.Add(this.equipment_ListBox);
            this.Controls.Add(this.label10);
            this.Name = "Equipment";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipment_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox equipment_ListBox;
        private System.Windows.Forms.PictureBox equipment_PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label equipment_ID_Label;
        private System.Windows.Forms.ListBox repairs_ListBox;
        private Farm_TrackerDataSetTableAdapters.BreakdownsTableAdapter breakdownsTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label year_Label;
        private System.Windows.Forms.TextBox year_TextBox;
        private System.Windows.Forms.Label equipment_Type_Label;
        private System.Windows.Forms.TextBox equipment_Type_TextBox;
        private System.Windows.Forms.Label brand_Label;
        private System.Windows.Forms.TextBox brand_TextBox;
        private System.Windows.Forms.Label serial_Number_Label;
        private System.Windows.Forms.TextBox serial_Number_Textbox;
        private System.Windows.Forms.Label model_Number_Label;
        private System.Windows.Forms.TextBox model_Number_TextBox;
        private System.Windows.Forms.Label hours_Label;
        private System.Windows.Forms.TextBox hours_TextBox;
        private System.Windows.Forms.Label horsepower_Label;
        private System.Windows.Forms.TextBox horsepower_TextBox;
        private System.Windows.Forms.Label width_Label;
        private System.Windows.Forms.TextBox width_TextBox;
        private System.Windows.Forms.Label number_Of_Tanks_Label;
        private System.Windows.Forms.TextBox number_Of_Tanks_TextBox;
        private System.Windows.Forms.Label tank_Size_Label;
        private System.Windows.Forms.TextBox tank_Size_TextBox;
        private System.Windows.Forms.Label shank_Spacing_Label;
        private System.Windows.Forms.TextBox shank_Spacing_TextBox;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button update_Equipment_Button;
        private System.Windows.Forms.Button new_Equipment_Button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button add_Image_Button;
    }
}