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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipment_ID_Label = new System.Windows.Forms.Label();
            this.repairs_ListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // equipment_ListBox
            // 
            this.equipment_ListBox.FormattingEnabled = true;
            this.equipment_ListBox.ItemHeight = 25;
            this.equipment_ListBox.Location = new System.Drawing.Point(13, 13);
            this.equipment_ListBox.Name = "equipment_ListBox";
            this.equipment_ListBox.Size = new System.Drawing.Size(332, 704);
            this.equipment_ListBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(351, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 240);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipment ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // equipment_ID_Label
            // 
            this.equipment_ID_Label.AutoSize = true;
            this.equipment_ID_Label.Location = new System.Drawing.Point(810, 26);
            this.equipment_ID_Label.Name = "equipment_ID_Label";
            this.equipment_ID_Label.Size = new System.Drawing.Size(140, 25);
            this.equipment_ID_Label.TabIndex = 3;
            this.equipment_ID_Label.Text = "Equipment ID";
            // 
            // repairs_ListBox
            // 
            this.repairs_ListBox.FormattingEnabled = true;
            this.repairs_ListBox.ItemHeight = 25;
            this.repairs_ListBox.Location = new System.Drawing.Point(351, 259);
            this.repairs_ListBox.Name = "repairs_ListBox";
            this.repairs_ListBox.Size = new System.Drawing.Size(290, 454);
            this.repairs_ListBox.TabIndex = 4;
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 757);
            this.Controls.Add(this.repairs_ListBox);
            this.Controls.Add(this.equipment_ID_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.equipment_ListBox);
            this.Name = "Equipment";
            this.Text = "Equipment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox equipment_ListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label equipment_ID_Label;
        private System.Windows.Forms.ListBox repairs_ListBox;
    }
}