namespace Farm_Tracker
{
    partial class Farming_Event_UserControl
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
            this.event_MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.delete_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.new_Button = new System.Windows.Forms.Button();
            this.update_Button = new System.Windows.Forms.Button();
            this.planned_Event_ListBox = new System.Windows.Forms.ListBox();
            this.actual_Event_ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crop_Checking_RadioButton = new System.Windows.Forms.RadioButton();
            this.spraying_RadioButton = new System.Windows.Forms.RadioButton();
            this.seeding_RadioButton = new System.Windows.Forms.RadioButton();
            this.disking_RadioButton = new System.Windows.Forms.RadioButton();
            this.harvesting_RadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // event_MonthCalendar
            // 
            this.event_MonthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.event_MonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_MonthCalendar.Location = new System.Drawing.Point(-1, 0);
            this.event_MonthCalendar.Name = "event_MonthCalendar";
            this.event_MonthCalendar.TabIndex = 0;
            // 
            // delete_Button
            // 
            this.delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Button.Location = new System.Drawing.Point(1307, 942);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(207, 50);
            this.delete_Button.TabIndex = 86;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Visible = false;
            // 
            // cancel_Button
            // 
            this.cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Button.Location = new System.Drawing.Point(1094, 942);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(207, 50);
            this.cancel_Button.TabIndex = 85;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Visible = false;
            // 
            // save_Button
            // 
            this.save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Button.Location = new System.Drawing.Point(880, 942);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(207, 50);
            this.save_Button.TabIndex = 84;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Visible = false;
            // 
            // new_Button
            // 
            this.new_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Button.Location = new System.Drawing.Point(454, 942);
            this.new_Button.Name = "new_Button";
            this.new_Button.Size = new System.Drawing.Size(207, 50);
            this.new_Button.TabIndex = 83;
            this.new_Button.Text = "New";
            this.new_Button.UseVisualStyleBackColor = true;
            // 
            // update_Button
            // 
            this.update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Button.Location = new System.Drawing.Point(667, 942);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(207, 50);
            this.update_Button.TabIndex = 82;
            this.update_Button.Text = "Update";
            this.update_Button.UseVisualStyleBackColor = true;
            // 
            // planned_Event_ListBox
            // 
            this.planned_Event_ListBox.FormattingEnabled = true;
            this.planned_Event_ListBox.ItemHeight = 25;
            this.planned_Event_ListBox.Location = new System.Drawing.Point(0, 352);
            this.planned_Event_ListBox.Name = "planned_Event_ListBox";
            this.planned_Event_ListBox.Size = new System.Drawing.Size(403, 579);
            this.planned_Event_ListBox.TabIndex = 87;
            // 
            // actual_Event_ListBox
            // 
            this.actual_Event_ListBox.FormattingEnabled = true;
            this.actual_Event_ListBox.ItemHeight = 25;
            this.actual_Event_ListBox.Location = new System.Drawing.Point(409, 352);
            this.actual_Event_ListBox.Name = "actual_Event_ListBox";
            this.actual_Event_ListBox.Size = new System.Drawing.Size(403, 579);
            this.actual_Event_ListBox.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "Planned";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 90;
            this.label2.Text = "Actual";
            // 
            // crop_Checking_RadioButton
            // 
            this.crop_Checking_RadioButton.AutoSize = true;
            this.crop_Checking_RadioButton.Location = new System.Drawing.Point(820, 4);
            this.crop_Checking_RadioButton.Name = "crop_Checking_RadioButton";
            this.crop_Checking_RadioButton.Size = new System.Drawing.Size(185, 29);
            this.crop_Checking_RadioButton.TabIndex = 92;
            this.crop_Checking_RadioButton.TabStop = true;
            this.crop_Checking_RadioButton.Text = "Crop Checking";
            this.crop_Checking_RadioButton.UseVisualStyleBackColor = true;
            // 
            // spraying_RadioButton
            // 
            this.spraying_RadioButton.AutoSize = true;
            this.spraying_RadioButton.Location = new System.Drawing.Point(820, 39);
            this.spraying_RadioButton.Name = "spraying_RadioButton";
            this.spraying_RadioButton.Size = new System.Drawing.Size(128, 29);
            this.spraying_RadioButton.TabIndex = 93;
            this.spraying_RadioButton.TabStop = true;
            this.spraying_RadioButton.Text = "Spraying";
            this.spraying_RadioButton.UseVisualStyleBackColor = true;
            // 
            // seeding_RadioButton
            // 
            this.seeding_RadioButton.AutoSize = true;
            this.seeding_RadioButton.Location = new System.Drawing.Point(1011, 4);
            this.seeding_RadioButton.Name = "seeding_RadioButton";
            this.seeding_RadioButton.Size = new System.Drawing.Size(122, 29);
            this.seeding_RadioButton.TabIndex = 94;
            this.seeding_RadioButton.TabStop = true;
            this.seeding_RadioButton.Text = "Seeding";
            this.seeding_RadioButton.UseVisualStyleBackColor = true;
            // 
            // disking_RadioButton
            // 
            this.disking_RadioButton.AutoSize = true;
            this.disking_RadioButton.Location = new System.Drawing.Point(1011, 39);
            this.disking_RadioButton.Name = "disking_RadioButton";
            this.disking_RadioButton.Size = new System.Drawing.Size(114, 29);
            this.disking_RadioButton.TabIndex = 97;
            this.disking_RadioButton.TabStop = true;
            this.disking_RadioButton.Text = "Disking";
            this.disking_RadioButton.UseVisualStyleBackColor = true;
            // 
            // harvesting_RadioButton
            // 
            this.harvesting_RadioButton.AutoSize = true;
            this.harvesting_RadioButton.Location = new System.Drawing.Point(1155, 4);
            this.harvesting_RadioButton.Name = "harvesting_RadioButton";
            this.harvesting_RadioButton.Size = new System.Drawing.Size(146, 29);
            this.harvesting_RadioButton.TabIndex = 96;
            this.harvesting_RadioButton.TabStop = true;
            this.harvesting_RadioButton.Text = "Harvesting";
            this.harvesting_RadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(820, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 841);
            this.panel1.TabIndex = 98;
            // 
            // Farming_Event_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.disking_RadioButton);
            this.Controls.Add(this.harvesting_RadioButton);
            this.Controls.Add(this.seeding_RadioButton);
            this.Controls.Add(this.spraying_RadioButton);
            this.Controls.Add(this.crop_Checking_RadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actual_Event_ListBox);
            this.Controls.Add(this.planned_Event_ListBox);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.new_Button);
            this.Controls.Add(this.update_Button);
            this.Controls.Add(this.event_MonthCalendar);
            this.Name = "Farming_Event_UserControl";
            this.Size = new System.Drawing.Size(1517, 1009);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar event_MonthCalendar;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button new_Button;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.ListBox planned_Event_ListBox;
        private System.Windows.Forms.ListBox actual_Event_ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton crop_Checking_RadioButton;
        private System.Windows.Forms.RadioButton spraying_RadioButton;
        private System.Windows.Forms.RadioButton seeding_RadioButton;
        private System.Windows.Forms.RadioButton disking_RadioButton;
        private System.Windows.Forms.RadioButton harvesting_RadioButton;
        private System.Windows.Forms.Panel panel1;
    }
}
