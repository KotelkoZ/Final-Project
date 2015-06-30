namespace Farm_Tracker
{
    partial class managementOverview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.maps_WebBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maps_WebBrowser);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 582);
            this.panel1.TabIndex = 0;
            // 
            // maps_WebBrowser
            // 
            this.maps_WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maps_WebBrowser.Location = new System.Drawing.Point(0, 0);
            this.maps_WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.maps_WebBrowser.Name = "maps_WebBrowser";
            this.maps_WebBrowser.ScrollBarsEnabled = false;
            this.maps_WebBrowser.Size = new System.Drawing.Size(706, 582);
            this.maps_WebBrowser.TabIndex = 0;
            // 
            // managementOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 1196);
            this.Controls.Add(this.panel1);
            this.Name = "managementOverview";
            this.Text = "managementOverview";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser maps_WebBrowser;
    }
}