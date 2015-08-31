namespace Farm_Tracker
{
    partial class Login_Form
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
            this.login_Button = new System.Windows.Forms.Button();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.operator_ID_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(254, 202);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(136, 47);
            this.login_Button.TabIndex = 8;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(200, 145);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.PasswordChar = '*';
            this.password_TextBox.Size = new System.Drawing.Size(190, 31);
            this.password_TextBox.TabIndex = 7;
            // 
            // operator_ID_Textbox
            // 
            this.operator_ID_Textbox.Location = new System.Drawing.Point(200, 98);
            this.operator_ID_Textbox.Name = "operator_ID_Textbox";
            this.operator_ID_Textbox.Size = new System.Drawing.Size(190, 31);
            this.operator_ID_Textbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operator ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 83);
            this.button1.TabIndex = 9;
            this.button1.Text = "Testing Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "2008";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "jborne";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 303);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.operator_ID_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login_Form";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TextBox operator_ID_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

