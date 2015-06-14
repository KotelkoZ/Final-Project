namespace Farm_Tracker
{
    partial class main_Menu
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
            this.operators_Button = new System.Windows.Forms.Button();
            this.equipment_Button = new System.Windows.Forms.Button();
            this.logout_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operators_Button
            // 
            this.operators_Button.Location = new System.Drawing.Point(12, 57);
            this.operators_Button.Name = "operators_Button";
            this.operators_Button.Size = new System.Drawing.Size(430, 55);
            this.operators_Button.TabIndex = 0;
            this.operators_Button.Text = "Operators";
            this.operators_Button.UseVisualStyleBackColor = true;
            this.operators_Button.Click += new System.EventHandler(this.operators_Button_Click);
            // 
            // equipment_Button
            // 
            this.equipment_Button.Location = new System.Drawing.Point(12, 260);
            this.equipment_Button.Name = "equipment_Button";
            this.equipment_Button.Size = new System.Drawing.Size(430, 55);
            this.equipment_Button.TabIndex = 1;
            this.equipment_Button.Text = "Equipment";
            this.equipment_Button.UseVisualStyleBackColor = true;
            // 
            // logout_Button
            // 
            this.logout_Button.Location = new System.Drawing.Point(12, 492);
            this.logout_Button.Name = "logout_Button";
            this.logout_Button.Size = new System.Drawing.Size(430, 55);
            this.logout_Button.TabIndex = 2;
            this.logout_Button.Text = "Logout";
            this.logout_Button.UseVisualStyleBackColor = true;
            this.logout_Button.Click += new System.EventHandler(this.logout_Button_Click);
            // 
            // main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 559);
            this.Controls.Add(this.logout_Button);
            this.Controls.Add(this.equipment_Button);
            this.Controls.Add(this.operators_Button);
            this.Name = "main_Menu";
            this.Text = "main_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button operators_Button;
        private System.Windows.Forms.Button equipment_Button;
        private System.Windows.Forms.Button logout_Button;
    }
}