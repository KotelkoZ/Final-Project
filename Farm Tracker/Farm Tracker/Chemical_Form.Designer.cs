namespace Farm_Tracker
{
    partial class Chemical_Form
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
            this.chemical_ListBox = new System.Windows.Forms.ListBox();
            this.chemical_Name_TextBox = new System.Windows.Forms.TextBox();
            this.chemical_Name_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.notes_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_Button = new System.Windows.Forms.Button();
            this.brand_TextBox = new System.Windows.Forms.TextBox();
            this.brand_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.new_Chemical_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.update_Chemical_Button = new System.Windows.Forms.Button();
            this.type_TextBox = new System.Windows.Forms.TextBox();
            this.type_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chemical_ID_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chemical_ListBox
            // 
            this.chemical_ListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.chemical_ListBox.FormattingEnabled = true;
            this.chemical_ListBox.ItemHeight = 25;
            this.chemical_ListBox.Location = new System.Drawing.Point(0, 0);
            this.chemical_ListBox.Name = "chemical_ListBox";
            this.chemical_ListBox.Size = new System.Drawing.Size(640, 665);
            this.chemical_ListBox.TabIndex = 0;
            this.chemical_ListBox.SelectedIndexChanged += new System.EventHandler(this.chemical_ListBox_SelectedIndexChanged);
            // 
            // chemical_Name_TextBox
            // 
            this.chemical_Name_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.chemical_Name_TextBox.Location = new System.Drawing.Point(875, 83);
            this.chemical_Name_TextBox.Name = "chemical_Name_TextBox";
            this.chemical_Name_TextBox.Size = new System.Drawing.Size(345, 31);
            this.chemical_Name_TextBox.TabIndex = 86;
            this.chemical_Name_TextBox.Visible = false;
            // 
            // chemical_Name_Label
            // 
            this.chemical_Name_Label.AutoSize = true;
            this.chemical_Name_Label.Location = new System.Drawing.Point(870, 86);
            this.chemical_Name_Label.Name = "chemical_Name_Label";
            this.chemical_Name_Label.Size = new System.Drawing.Size(120, 25);
            this.chemical_Name_Label.TabIndex = 88;
            this.chemical_Name_Label.Text = "Crop Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(796, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 87;
            this.label6.Text = "Name";
            // 
            // notes_RichTextBox
            // 
            this.notes_RichTextBox.BackColor = System.Drawing.Color.LightYellow;
            this.notes_RichTextBox.Enabled = false;
            this.notes_RichTextBox.Location = new System.Drawing.Point(875, 195);
            this.notes_RichTextBox.Name = "notes_RichTextBox";
            this.notes_RichTextBox.Size = new System.Drawing.Size(345, 195);
            this.notes_RichTextBox.TabIndex = 85;
            this.notes_RichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(796, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 84;
            this.label4.Text = "Notes";
            // 
            // delete_Button
            // 
            this.delete_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.delete_Button.Location = new System.Drawing.Point(875, 512);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(345, 43);
            this.delete_Button.TabIndex = 83;
            this.delete_Button.TabStop = false;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = false;
            this.delete_Button.Visible = false;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // brand_TextBox
            // 
            this.brand_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.brand_TextBox.Location = new System.Drawing.Point(875, 158);
            this.brand_TextBox.Name = "brand_TextBox";
            this.brand_TextBox.Size = new System.Drawing.Size(345, 31);
            this.brand_TextBox.TabIndex = 72;
            this.brand_TextBox.Visible = false;
            // 
            // brand_Label
            // 
            this.brand_Label.AutoSize = true;
            this.brand_Label.Location = new System.Drawing.Point(870, 160);
            this.brand_Label.Name = "brand_Label";
            this.brand_Label.Size = new System.Drawing.Size(69, 25);
            this.brand_Label.TabIndex = 82;
            this.brand_Label.Text = "Brand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(795, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 81;
            this.label8.Text = "Brand";
            // 
            // cancel_Button
            // 
            this.cancel_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.cancel_Button.Location = new System.Drawing.Point(875, 463);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(345, 43);
            this.cancel_Button.TabIndex = 78;
            this.cancel_Button.TabStop = false;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = false;
            this.cancel_Button.Visible = false;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // new_Chemical_Button
            // 
            this.new_Chemical_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.new_Chemical_Button.Location = new System.Drawing.Point(1051, 576);
            this.new_Chemical_Button.Name = "new_Chemical_Button";
            this.new_Chemical_Button.Size = new System.Drawing.Size(170, 75);
            this.new_Chemical_Button.TabIndex = 80;
            this.new_Chemical_Button.Text = "New Chemical";
            this.new_Chemical_Button.UseVisualStyleBackColor = false;
            this.new_Chemical_Button.Click += new System.EventHandler(this.new_Chemical_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.save_Button.Location = new System.Drawing.Point(875, 414);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(345, 43);
            this.save_Button.TabIndex = 77;
            this.save_Button.TabStop = false;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = false;
            this.save_Button.Visible = false;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // update_Chemical_Button
            // 
            this.update_Chemical_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.update_Chemical_Button.Location = new System.Drawing.Point(875, 576);
            this.update_Chemical_Button.Name = "update_Chemical_Button";
            this.update_Chemical_Button.Size = new System.Drawing.Size(170, 75);
            this.update_Chemical_Button.TabIndex = 79;
            this.update_Chemical_Button.Text = "Update Chemical";
            this.update_Chemical_Button.UseVisualStyleBackColor = false;
            this.update_Chemical_Button.Click += new System.EventHandler(this.update_Chemical_Button_Click);
            // 
            // type_TextBox
            // 
            this.type_TextBox.BackColor = System.Drawing.Color.LightYellow;
            this.type_TextBox.Location = new System.Drawing.Point(876, 121);
            this.type_TextBox.Name = "type_TextBox";
            this.type_TextBox.Size = new System.Drawing.Size(345, 31);
            this.type_TextBox.TabIndex = 68;
            this.type_TextBox.Visible = false;
            // 
            // type_Label
            // 
            this.type_Label.AutoSize = true;
            this.type_Label.Location = new System.Drawing.Point(870, 123);
            this.type_Label.Name = "type_Label";
            this.type_Label.Size = new System.Drawing.Size(60, 25);
            this.type_Label.TabIndex = 75;
            this.type_Label.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "Type";
            // 
            // chemical_ID_Label
            // 
            this.chemical_ID_Label.AutoSize = true;
            this.chemical_ID_Label.Location = new System.Drawing.Point(870, 25);
            this.chemical_ID_Label.Name = "chemical_ID_Label";
            this.chemical_ID_Label.Size = new System.Drawing.Size(127, 25);
            this.chemical_ID_Label.TabIndex = 71;
            this.chemical_ID_Label.Text = "Chemical ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Chemical ID";
            // 
            // Chemical_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 665);
            this.Controls.Add(this.chemical_Name_TextBox);
            this.Controls.Add(this.chemical_Name_Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.notes_RichTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.brand_TextBox);
            this.Controls.Add(this.brand_Label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.new_Chemical_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.update_Chemical_Button);
            this.Controls.Add(this.type_TextBox);
            this.Controls.Add(this.type_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chemical_ID_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chemical_ListBox);
            this.Name = "Chemical_Form";
            this.ShowIcon = false;
            this.Text = "Chemical_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chemical_ListBox;
        private System.Windows.Forms.TextBox chemical_Name_TextBox;
        private System.Windows.Forms.Label chemical_Name_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox notes_RichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.TextBox brand_TextBox;
        private System.Windows.Forms.Label brand_Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button new_Chemical_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button update_Chemical_Button;
        private System.Windows.Forms.TextBox type_TextBox;
        private System.Windows.Forms.Label type_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chemical_ID_Label;
        private System.Windows.Forms.Label label1;
    }
}