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
            this.components = new System.ComponentModel.Container();
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
            this.breakdown_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixed_Button = new System.Windows.Forms.Button();
            this.breakdown_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.breakdown_ContextMenuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_Repaired_Label
            // 
            this.date_Repaired_Label.AutoSize = true;
            this.date_Repaired_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Repaired_Label.Location = new System.Drawing.Point(586, 490);
            this.date_Repaired_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_Repaired_Label.Name = "date_Repaired_Label";
            this.date_Repaired_Label.Size = new System.Drawing.Size(38, 17);
            this.date_Repaired_Label.TabIndex = 80;
            this.date_Repaired_Label.Text = "Date";
            this.date_Repaired_Label.Visible = false;
            // 
            // operator_ComboBox
            // 
            this.operator_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operator_ComboBox.Enabled = false;
            this.operator_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operator_ComboBox.FormattingEnabled = true;
            this.operator_ComboBox.Location = new System.Drawing.Point(589, 87);
            this.operator_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.operator_ComboBox.Name = "operator_ComboBox";
            this.operator_ComboBox.Size = new System.Drawing.Size(335, 24);
            this.operator_ComboBox.TabIndex = 79;
            // 
            // equipment_ComboBox
            // 
            this.equipment_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipment_ComboBox.Enabled = false;
            this.equipment_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipment_ComboBox.FormattingEnabled = true;
            this.equipment_ComboBox.Location = new System.Drawing.Point(589, 49);
            this.equipment_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.equipment_ComboBox.Name = "equipment_ComboBox";
            this.equipment_ComboBox.Size = new System.Drawing.Size(335, 24);
            this.equipment_ComboBox.TabIndex = 78;
            // 
            // delete_Button
            // 
            this.delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Button.Location = new System.Drawing.Point(570, 2);
            this.delete_Button.Margin = new System.Windows.Forms.Padding(2);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(138, 32);
            this.delete_Button.TabIndex = 77;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Visible = false;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Button.Location = new System.Drawing.Point(428, 2);
            this.cancel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(138, 32);
            this.cancel_Button.TabIndex = 76;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Visible = false;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Button.Location = new System.Drawing.Point(286, 2);
            this.save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(138, 32);
            this.save_Button.TabIndex = 75;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Visible = false;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // new_Button
            // 
            this.new_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Button.Location = new System.Drawing.Point(2, 2);
            this.new_Button.Margin = new System.Windows.Forms.Padding(2);
            this.new_Button.Name = "new_Button";
            this.new_Button.Size = new System.Drawing.Size(138, 32);
            this.new_Button.TabIndex = 74;
            this.new_Button.Text = "New";
            this.new_Button.UseVisualStyleBackColor = true;
            this.new_Button.Click += new System.EventHandler(this.new_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Button.Location = new System.Drawing.Point(144, 2);
            this.update_Button.Margin = new System.Windows.Forms.Padding(2);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(138, 32);
            this.update_Button.TabIndex = 73;
            this.update_Button.Text = "Update";
            this.update_Button.UseVisualStyleBackColor = true;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // repaired_Label
            // 
            this.repaired_Label.AutoSize = true;
            this.repaired_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repaired_Label.Location = new System.Drawing.Point(459, 490);
            this.repaired_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.repaired_Label.Name = "repaired_Label";
            this.repaired_Label.Size = new System.Drawing.Size(85, 17);
            this.repaired_Label.TabIndex = 72;
            this.repaired_Label.Text = "not repaired";
            this.repaired_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // repair_Notes_RichTextBox
            // 
            this.repair_Notes_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repair_Notes_RichTextBox.Enabled = false;
            this.repair_Notes_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repair_Notes_RichTextBox.Location = new System.Drawing.Point(589, 311);
            this.repair_Notes_RichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.repair_Notes_RichTextBox.Name = "repair_Notes_RichTextBox";
            this.repair_Notes_RichTextBox.Size = new System.Drawing.Size(335, 145);
            this.repair_Notes_RichTextBox.TabIndex = 71;
            this.repair_Notes_RichTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(459, 316);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 70;
            this.label9.Text = "Notes";
            // 
            // breakdown_Description_RichTextBox
            // 
            this.breakdown_Description_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.breakdown_Description_RichTextBox.Enabled = false;
            this.breakdown_Description_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_Description_RichTextBox.Location = new System.Drawing.Point(589, 163);
            this.breakdown_Description_RichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.breakdown_Description_RichTextBox.Name = "breakdown_Description_RichTextBox";
            this.breakdown_Description_RichTextBox.Size = new System.Drawing.Size(335, 145);
            this.breakdown_Description_RichTextBox.TabIndex = 69;
            this.breakdown_Description_RichTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(459, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Operator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Equipment";
            // 
            // breakdown_ID_Label
            // 
            this.breakdown_ID_Label.AutoSize = true;
            this.breakdown_ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_ID_Label.Location = new System.Drawing.Point(584, 19);
            this.breakdown_ID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.breakdown_ID_Label.Name = "breakdown_ID_Label";
            this.breakdown_ID_Label.Size = new System.Drawing.Size(95, 17);
            this.breakdown_ID_Label.TabIndex = 63;
            this.breakdown_ID_Label.Text = "Breakdown ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Breakdown ID";
            // 
            // search_Button
            // 
            this.search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Button.Location = new System.Drawing.Point(303, 147);
            this.search_Button.Margin = new System.Windows.Forms.Padding(2);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(138, 32);
            this.search_Button.TabIndex = 61;
            this.search_Button.Text = "Search";
            this.search_Button.UseVisualStyleBackColor = true;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Search by equipment";
            // 
            // equipment_Search_ComboBox
            // 
            this.equipment_Search_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipment_Search_ComboBox.FormattingEnabled = true;
            this.equipment_Search_ComboBox.Location = new System.Drawing.Point(303, 118);
            this.equipment_Search_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.equipment_Search_ComboBox.Name = "equipment_Search_ComboBox";
            this.equipment_Search_ComboBox.Size = new System.Drawing.Size(139, 24);
            this.equipment_Search_ComboBox.TabIndex = 59;
            // 
            // all_Breakdown_Button
            // 
            this.all_Breakdown_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_Breakdown_Button.Location = new System.Drawing.Point(303, 55);
            this.all_Breakdown_Button.Margin = new System.Windows.Forms.Padding(2);
            this.all_Breakdown_Button.Name = "all_Breakdown_Button";
            this.all_Breakdown_Button.Size = new System.Drawing.Size(138, 32);
            this.all_Breakdown_Button.TabIndex = 58;
            this.all_Breakdown_Button.Text = "All";
            this.all_Breakdown_Button.UseVisualStyleBackColor = true;
            this.all_Breakdown_Button.Click += new System.EventHandler(this.all_Breakdown_Button_Click);
            // 
            // current_Breakdown_Button
            // 
            this.current_Breakdown_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_Breakdown_Button.Location = new System.Drawing.Point(303, 19);
            this.current_Breakdown_Button.Margin = new System.Windows.Forms.Padding(2);
            this.current_Breakdown_Button.Name = "current_Breakdown_Button";
            this.current_Breakdown_Button.Size = new System.Drawing.Size(138, 32);
            this.current_Breakdown_Button.TabIndex = 57;
            this.current_Breakdown_Button.Text = "Current";
            this.current_Breakdown_Button.UseVisualStyleBackColor = true;
            this.current_Breakdown_Button.Click += new System.EventHandler(this.current_Breakdown_Button_Click);
            // 
            // breakdown_ListBox
            // 
            this.breakdown_ListBox.ContextMenuStrip = this.breakdown_ContextMenuStrip;
            this.breakdown_ListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.breakdown_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_ListBox.FormattingEnabled = true;
            this.breakdown_ListBox.ItemHeight = 16;
            this.breakdown_ListBox.Location = new System.Drawing.Point(0, 0);
            this.breakdown_ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.breakdown_ListBox.Name = "breakdown_ListBox";
            this.breakdown_ListBox.Size = new System.Drawing.Size(301, 646);
            this.breakdown_ListBox.TabIndex = 56;
            this.breakdown_ListBox.SelectedIndexChanged += new System.EventHandler(this.breakdown_ListBox_SelectedIndexChanged);
            this.breakdown_ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.breakdown_ListBox_RightClick);
            this.breakdown_ListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.breakdown_ListBox_MouseUp);
            // 
            // breakdown_ContextMenuStrip
            // 
            this.breakdown_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.breakdown_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.fixToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.breakdown_ContextMenuStrip.Name = "breakdown_ContextMenuStrip";
            this.breakdown_ContextMenuStrip.Size = new System.Drawing.Size(128, 76);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // fixToolStripMenuItem
            // 
            this.fixToolStripMenuItem.Name = "fixToolStripMenuItem";
            this.fixToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.fixToolStripMenuItem.Text = "Fixed";
            this.fixToolStripMenuItem.Click += new System.EventHandler(this.fixToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // fixed_Button
            // 
            this.fixed_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fixed_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fixed_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixed_Button.Location = new System.Drawing.Point(587, 574);
            this.fixed_Button.Margin = new System.Windows.Forms.Padding(2);
            this.fixed_Button.Name = "fixed_Button";
            this.fixed_Button.Size = new System.Drawing.Size(138, 32);
            this.fixed_Button.TabIndex = 81;
            this.fixed_Button.Text = "Fixed";
            this.fixed_Button.UseVisualStyleBackColor = false;
            this.fixed_Button.Visible = false;
            this.fixed_Button.Click += new System.EventHandler(this.fixed_Button_Click);
            // 
            // breakdown_DateTimePicker
            // 
            this.breakdown_DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.breakdown_DateTimePicker.Enabled = false;
            this.breakdown_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.breakdown_DateTimePicker.Location = new System.Drawing.Point(589, 125);
            this.breakdown_DateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.breakdown_DateTimePicker.Name = "breakdown_DateTimePicker";
            this.breakdown_DateTimePicker.Size = new System.Drawing.Size(335, 22);
            this.breakdown_DateTimePicker.TabIndex = 82;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.new_Button);
            this.flowLayoutPanel1.Controls.Add(this.update_Button);
            this.flowLayoutPanel1.Controls.Add(this.save_Button);
            this.flowLayoutPanel1.Controls.Add(this.cancel_Button);
            this.flowLayoutPanel1.Controls.Add(this.delete_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(301, 608);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(710, 38);
            this.flowLayoutPanel1.TabIndex = 83;
            // 
            // Breakdown_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.fixed_Button);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.breakdown_DateTimePicker);
            this.Controls.Add(this.date_Repaired_Label);
            this.Controls.Add(this.operator_ComboBox);
            this.Controls.Add(this.equipment_ComboBox);
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
            this.Controls.Add(this.equipment_Search_ComboBox);
            this.Controls.Add(this.all_Breakdown_Button);
            this.Controls.Add(this.current_Breakdown_Button);
            this.Controls.Add(this.breakdown_ListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Breakdown_UserControl";
            this.Size = new System.Drawing.Size(1011, 646);
            this.breakdown_ContextMenuStrip.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip breakdown_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
