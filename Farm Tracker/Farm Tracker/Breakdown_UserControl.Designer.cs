namespace Farm_Tracker
{
    partial class Breakdown_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.date_Repaired_Label = new System.Windows.Forms.Label();
            this.operator_ComboBox = new System.Windows.Forms.ComboBox();
            this.equipment_ComboBox = new System.Windows.Forms.ComboBox();
            this.delete_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.new_Button = new System.Windows.Forms.Button();
            this.update_Button = new System.Windows.Forms.Button();
            this.repaired_Label = new System.Windows.Forms.Label();
            this.repair_Notes_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.breakdown_Description_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.breakdown_ID_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.equipment_Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.all_Breakdown_Button = new System.Windows.Forms.Button();
            this.current_Breakdown_Button = new System.Windows.Forms.Button();
            this.breakdown_ListBox = new System.Windows.Forms.ListBox();
            this.fixed_Button = new System.Windows.Forms.Button();
            this.breakdown_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // date_Repaired_Label
            // 
            this.date_Repaired_Label.AutoSize = true;
            this.date_Repaired_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Repaired_Label.Location = new System.Drawing.Point(1096, 765);
            this.date_Repaired_Label.Name = "date_Repaired_Label";
            this.date_Repaired_Label.Size = new System.Drawing.Size(104, 46);
            this.date_Repaired_Label.TabIndex = 80;
            this.date_Repaired_Label.Text = "Date";
            this.date_Repaired_Label.Visible = false;
            // 
            // operator_ComboBox
            // 
            this.operator_ComboBox.Enabled = false;
            this.operator_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operator_ComboBox.FormattingEnabled = true;
            this.operator_ComboBox.Location = new System.Drawing.Point(1104, 139);
            this.operator_ComboBox.Name = "operator_ComboBox";
            this.operator_ComboBox.Size = new System.Drawing.Size(392, 54);
            this.operator_ComboBox.TabIndex = 79;
            // 
            // equipment_ComboBox
            // 
            this.equipment_ComboBox.Enabled = false;
            this.equipment_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipment_ComboBox.FormattingEnabled = true;
            this.equipment_ComboBox.Location = new System.Drawing.Point(1104, 79);
            this.equipment_ComboBox.Name = "equipment_ComboBox";
            this.equipment_ComboBox.Size = new System.Drawing.Size(392, 54);
            this.equipment_ComboBox.TabIndex = 78;
            // 
            // delete_Button
            // 
            this.delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Button.Location = new System.Drawing.Point(1307, 942);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(207, 50);
            this.delete_Button.TabIndex = 77;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Visible = false;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Button.Location = new System.Drawing.Point(1094, 942);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(207, 50);
            this.cancel_Button.TabIndex = 76;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Visible = false;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Button.Location = new System.Drawing.Point(880, 942);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(207, 50);
            this.save_Button.TabIndex = 75;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Visible = false;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // new_Button
            // 
            this.new_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Button.Location = new System.Drawing.Point(454, 942);
            this.new_Button.Name = "new_Button";
            this.new_Button.Size = new System.Drawing.Size(207, 50);
            this.new_Button.TabIndex = 74;
            this.new_Button.Text = "New";
            this.new_Button.UseVisualStyleBackColor = true;
            this.new_Button.Click += new System.EventHandler(this.new_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Button.Location = new System.Drawing.Point(667, 942);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(207, 50);
            this.update_Button.TabIndex = 73;
            this.update_Button.Text = "Update";
            this.update_Button.UseVisualStyleBackColor = true;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // repaired_Label
            // 
            this.repaired_Label.AutoSize = true;
            this.repaired_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repaired_Label.Location = new System.Drawing.Point(850, 765);
            this.repaired_Label.Name = "repaired_Label";
            this.repaired_Label.Size = new System.Drawing.Size(232, 46);
            this.repaired_Label.TabIndex = 72;
            this.repaired_Label.Text = "not repaired";
            this.repaired_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // repair_Notes_RichTextBox
            // 
            this.repair_Notes_RichTextBox.Enabled = false;
            this.repair_Notes_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repair_Notes_RichTextBox.Location = new System.Drawing.Point(1104, 489);
            this.repair_Notes_RichTextBox.Name = "repair_Notes_RichTextBox";
            this.repair_Notes_RichTextBox.Size = new System.Drawing.Size(392, 225);
            this.repair_Notes_RichTextBox.TabIndex = 71;
            this.repair_Notes_RichTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(957, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 46);
            this.label9.TabIndex = 70;
            this.label9.Text = "Notes";
            // 
            // breakdown_Description_RichTextBox
            // 
            this.breakdown_Description_RichTextBox.Enabled = false;
            this.breakdown_Description_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_Description_RichTextBox.Location = new System.Drawing.Point(1104, 258);
            this.breakdown_Description_RichTextBox.Name = "breakdown_Description_RichTextBox";
            this.breakdown_Description_RichTextBox.Size = new System.Drawing.Size(392, 225);
            this.breakdown_Description_RichTextBox.TabIndex = 69;
            this.breakdown_Description_RichTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(978, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 46);
            this.label8.TabIndex = 67;
            this.label8.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(861, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 46);
            this.label7.TabIndex = 66;
            this.label7.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(905, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 46);
            this.label3.TabIndex = 65;
            this.label3.Text = "Operator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(872, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 46);
            this.label4.TabIndex = 64;
            this.label4.Text = "Equipment";
            // 
            // breakdown_ID_Label
            // 
            this.breakdown_ID_Label.AutoSize = true;
            this.breakdown_ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_ID_Label.Location = new System.Drawing.Point(1096, 33);
            this.breakdown_ID_Label.Name = "breakdown_ID_Label";
            this.breakdown_ID_Label.Size = new System.Drawing.Size(270, 46);
            this.breakdown_ID_Label.TabIndex = 63;
            this.breakdown_ID_Label.Text = "Breakdown ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(812, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 46);
            this.label2.TabIndex = 62;
            this.label2.Text = "Breakdown ID";
            // 
            // search_Button
            // 
            this.search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Button.Location = new System.Drawing.Point(455, 230);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(207, 50);
            this.search_Button.TabIndex = 61;
            this.search_Button.Text = "Search";
            this.search_Button.UseVisualStyleBackColor = true;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 60;
            this.label1.Text = "Search by equipment";
            // 
            // equipment_Search_ComboBox
            // 
            this.equipment_Search_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipment_Search_ComboBox.FormattingEnabled = true;
            this.equipment_Search_ComboBox.Location = new System.Drawing.Point(455, 185);
            this.equipment_Search_ComboBox.Name = "equipment_Search_ComboBox";
            this.equipment_Search_ComboBox.Size = new System.Drawing.Size(207, 39);
            this.equipment_Search_ComboBox.TabIndex = 59;
            // 
            // all_Breakdown_Button
            // 
            this.all_Breakdown_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_Breakdown_Button.Location = new System.Drawing.Point(455, 86);
            this.all_Breakdown_Button.Name = "all_Breakdown_Button";
            this.all_Breakdown_Button.Size = new System.Drawing.Size(207, 50);
            this.all_Breakdown_Button.TabIndex = 58;
            this.all_Breakdown_Button.Text = "All";
            this.all_Breakdown_Button.UseVisualStyleBackColor = true;
            this.all_Breakdown_Button.Click += new System.EventHandler(this.all_Breakdown_Button_Click);
            // 
            // current_Breakdown_Button
            // 
            this.current_Breakdown_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_Breakdown_Button.Location = new System.Drawing.Point(455, 29);
            this.current_Breakdown_Button.Name = "current_Breakdown_Button";
            this.current_Breakdown_Button.Size = new System.Drawing.Size(207, 50);
            this.current_Breakdown_Button.TabIndex = 57;
            this.current_Breakdown_Button.Text = "Current";
            this.current_Breakdown_Button.UseVisualStyleBackColor = true;
            this.current_Breakdown_Button.Click += new System.EventHandler(this.current_Breakdown_Button_Click);
            // 
            // breakdown_ListBox
            // 
            this.breakdown_ListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.breakdown_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_ListBox.FormattingEnabled = true;
            this.breakdown_ListBox.ItemHeight = 31;
            this.breakdown_ListBox.Location = new System.Drawing.Point(0, 0);
            this.breakdown_ListBox.Name = "breakdown_ListBox";
            this.breakdown_ListBox.Size = new System.Drawing.Size(449, 1009);
            this.breakdown_ListBox.TabIndex = 56;
            this.breakdown_ListBox.SelectedIndexChanged += new System.EventHandler(this.breakdown_ListBox_SelectedIndexChanged);
            // 
            // fixed_Button
            // 
            this.fixed_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fixed_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixed_Button.Location = new System.Drawing.Point(667, 886);
            this.fixed_Button.Name = "fixed_Button";
            this.fixed_Button.Size = new System.Drawing.Size(207, 50);
            this.fixed_Button.TabIndex = 81;
            this.fixed_Button.Text = "Fixed";
            this.fixed_Button.UseVisualStyleBackColor = false;
            this.fixed_Button.Visible = false;
            this.fixed_Button.Click += new System.EventHandler(this.fixed_Button_Click);
            // 
            // breakdown_DateTimePicker
            // 
            this.breakdown_DateTimePicker.Enabled = false;
            this.breakdown_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.breakdown_DateTimePicker.Location = new System.Drawing.Point(1104, 199);
            this.breakdown_DateTimePicker.Name = "breakdown_DateTimePicker";
            this.breakdown_DateTimePicker.Size = new System.Drawing.Size(392, 53);
            this.breakdown_DateTimePicker.TabIndex = 82;
            // 
            // Breakdown_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.breakdown_DateTimePicker);
            this.Controls.Add(this.fixed_Button);
            this.Controls.Add(this.date_Repaired_Label);
            this.Controls.Add(this.operator_ComboBox);
            this.Controls.Add(this.equipment_ComboBox);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.new_Button);
            this.Controls.Add(this.update_Button);
            this.Controls.Add(this.repaired_Label);
            this.Controls.Add(this.repair_Notes_RichTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.breakdown_Description_RichTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.breakdown_ID_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipment_Search_ComboBox);
            this.Controls.Add(this.all_Breakdown_Button);
            this.Controls.Add(this.current_Breakdown_Button);
            this.Controls.Add(this.breakdown_ListBox);
            this.Name = "Breakdown_UserControl";
            this.Size = new System.Drawing.Size(1517, 1009);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date_Repaired_Label;
        private System.Windows.Forms.ComboBox operator_ComboBox;
        private System.Windows.Forms.ComboBox equipment_ComboBox;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button new_Button;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.Label repaired_Label;
        private System.Windows.Forms.RichTextBox repair_Notes_RichTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox breakdown_Description_RichTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label breakdown_ID_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equipment_Search_ComboBox;
        private System.Windows.Forms.Button all_Breakdown_Button;
        private System.Windows.Forms.Button current_Breakdown_Button;
        private System.Windows.Forms.ListBox breakdown_ListBox;
        private System.Windows.Forms.Button fixed_Button;
        private System.Windows.Forms.DateTimePicker breakdown_DateTimePicker;
    }
}
