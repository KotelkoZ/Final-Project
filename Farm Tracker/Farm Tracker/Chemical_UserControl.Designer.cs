namespace Farm_Tracker
{
    partial class Chemical_UserControl
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
            this.components = new System.ComponentModel.Container();
            this.chemical_Name_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.notes_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_Button = new System.Windows.Forms.Button();
            this.brand_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.new_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.update_Button = new System.Windows.Forms.Button();
            this.type_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chemical_ID_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chemical_ListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chemicals_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.chemicals_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chemical_Name_TextBox
            // 
            this.chemical_Name_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chemical_Name_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.chemical_Name_TextBox.Enabled = false;
            this.chemical_Name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemical_Name_TextBox.Location = new System.Drawing.Point(447, 55);
            this.chemical_Name_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.chemical_Name_TextBox.Name = "chemical_Name_TextBox";
            this.chemical_Name_TextBox.Size = new System.Drawing.Size(263, 22);
            this.chemical_Name_TextBox.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 106;
            this.label6.Text = "Name";
            // 
            // notes_RichTextBox
            // 
            this.notes_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notes_RichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.notes_RichTextBox.Enabled = false;
            this.notes_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_RichTextBox.Location = new System.Drawing.Point(447, 170);
            this.notes_RichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.notes_RichTextBox.Name = "notes_RichTextBox";
            this.notes_RichTextBox.Size = new System.Drawing.Size(263, 126);
            this.notes_RichTextBox.TabIndex = 104;
            this.notes_RichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 103;
            this.label4.Text = "Notes";
            // 
            // delete_Button
            // 
            this.delete_Button.BackColor = System.Drawing.SystemColors.Control;
            this.delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Button.Location = new System.Drawing.Point(570, 2);
            this.delete_Button.Margin = new System.Windows.Forms.Padding(2);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(138, 32);
            this.delete_Button.TabIndex = 102;
            this.delete_Button.TabStop = false;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = false;
            this.delete_Button.Visible = false;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // brand_TextBox
            // 
            this.brand_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brand_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.brand_TextBox.Enabled = false;
            this.brand_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_TextBox.Location = new System.Drawing.Point(447, 131);
            this.brand_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.brand_TextBox.Name = "brand_TextBox";
            this.brand_TextBox.Size = new System.Drawing.Size(263, 22);
            this.brand_TextBox.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(296, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 100;
            this.label8.Text = "Brand";
            // 
            // cancel_Button
            // 
            this.cancel_Button.BackColor = System.Drawing.SystemColors.Control;
            this.cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Button.Location = new System.Drawing.Point(428, 2);
            this.cancel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(138, 32);
            this.cancel_Button.TabIndex = 97;
            this.cancel_Button.TabStop = false;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = false;
            this.cancel_Button.Visible = false;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // new_Button
            // 
            this.new_Button.BackColor = System.Drawing.SystemColors.Control;
            this.new_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Button.Location = new System.Drawing.Point(2, 2);
            this.new_Button.Margin = new System.Windows.Forms.Padding(2);
            this.new_Button.Name = "new_Button";
            this.new_Button.Size = new System.Drawing.Size(138, 32);
            this.new_Button.TabIndex = 99;
            this.new_Button.Text = "New";
            this.new_Button.UseVisualStyleBackColor = false;
            this.new_Button.Click += new System.EventHandler(this.new_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.SystemColors.Control;
            this.save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Button.Location = new System.Drawing.Point(286, 2);
            this.save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(138, 32);
            this.save_Button.TabIndex = 96;
            this.save_Button.TabStop = false;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = false;
            this.save_Button.Visible = false;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.BackColor = System.Drawing.SystemColors.Control;
            this.update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Button.Location = new System.Drawing.Point(144, 2);
            this.update_Button.Margin = new System.Windows.Forms.Padding(2);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(138, 32);
            this.update_Button.TabIndex = 98;
            this.update_Button.Text = "Update";
            this.update_Button.UseVisualStyleBackColor = false;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // type_TextBox
            // 
            this.type_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.type_TextBox.Enabled = false;
            this.type_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_TextBox.Location = new System.Drawing.Point(447, 93);
            this.type_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.type_TextBox.Name = "type_TextBox";
            this.type_TextBox.Size = new System.Drawing.Size(263, 22);
            this.type_TextBox.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Type";
            // 
            // chemical_ID_Label
            // 
            this.chemical_ID_Label.AutoSize = true;
            this.chemical_ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemical_ID_Label.Location = new System.Drawing.Point(442, 21);
            this.chemical_ID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chemical_ID_Label.Name = "chemical_ID_Label";
            this.chemical_ID_Label.Size = new System.Drawing.Size(82, 17);
            this.chemical_ID_Label.TabIndex = 92;
            this.chemical_ID_Label.Text = "Chemical ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 91;
            this.label1.Text = "Chemical ID";
            // 
            // chemical_ListBox
            // 
            this.chemical_ListBox.ContextMenuStrip = this.chemicals_ContextMenuStrip;
            this.chemical_ListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.chemical_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemical_ListBox.FormattingEnabled = true;
            this.chemical_ListBox.ItemHeight = 16;
            this.chemical_ListBox.Location = new System.Drawing.Point(0, 0);
            this.chemical_ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.chemical_ListBox.Name = "chemical_ListBox";
            this.chemical_ListBox.Size = new System.Drawing.Size(292, 646);
            this.chemical_ListBox.TabIndex = 89;
            this.chemical_ListBox.SelectedIndexChanged += new System.EventHandler(this.chemical_ListBox_SelectedIndexChanged);
            this.chemical_ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chemical_ListBox_RightClick);
            this.chemical_ListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chemical_ListBox_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.new_Button);
            this.flowLayoutPanel1.Controls.Add(this.update_Button);
            this.flowLayoutPanel1.Controls.Add(this.save_Button);
            this.flowLayoutPanel1.Controls.Add(this.cancel_Button);
            this.flowLayoutPanel1.Controls.Add(this.delete_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(292, 607);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(719, 39);
            this.flowLayoutPanel1.TabIndex = 107;
            // 
            // chemicals_ContextMenuStrip
            // 
            this.chemicals_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.chemicals_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.chemicals_ContextMenuStrip.Name = "chemicals_ContextMenuStrip";
            this.chemicals_ContextMenuStrip.Size = new System.Drawing.Size(128, 52);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Chemical_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chemical_Name_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.notes_RichTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brand_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.type_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chemical_ID_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chemical_ListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chemical_UserControl";
            this.Size = new System.Drawing.Size(1011, 646);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.chemicals_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chemical_Name_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox notes_RichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.TextBox brand_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button new_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.TextBox type_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chemical_ID_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox chemical_ListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip chemicals_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
