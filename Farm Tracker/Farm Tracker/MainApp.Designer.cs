namespace Farm_Tracker
{
    partial class MainApp
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.farming_Events_Button = new System.Windows.Forms.Button();
            this.reports_Button = new System.Windows.Forms.Button();
            this.logout_Button = new System.Windows.Forms.Button();
            this.chemical_Button = new System.Windows.Forms.Button();
            this.crops_Button = new System.Windows.Forms.Button();
            this.fields_Button = new System.Windows.Forms.Button();
            this.equipment_Button = new System.Windows.Forms.Button();
            this.operators_Button = new System.Windows.Forms.Button();
            this.breakdown_Button = new System.Windows.Forms.Button();
            this.overview_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.farming_Events_Button);
            this.splitContainer.Panel1.Controls.Add(this.reports_Button);
            this.splitContainer.Panel1.Controls.Add(this.logout_Button);
            this.splitContainer.Panel1.Controls.Add(this.chemical_Button);
            this.splitContainer.Panel1.Controls.Add(this.crops_Button);
            this.splitContainer.Panel1.Controls.Add(this.fields_Button);
            this.splitContainer.Panel1.Controls.Add(this.equipment_Button);
            this.splitContainer.Panel1.Controls.Add(this.operators_Button);
            this.splitContainer.Panel1.Controls.Add(this.breakdown_Button);
            this.splitContainer.Panel1.Controls.Add(this.overview_Button);
            this.splitContainer.Panel1MinSize = 373;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2MinSize = 1517;
            this.splitContainer.Size = new System.Drawing.Size(1263, 646);
            this.splitContainer.SplitterDistance = 373;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 0;
            // 
            // farming_Events_Button
            // 
            this.farming_Events_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.farming_Events_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farming_Events_Button.Location = new System.Drawing.Point(0, 408);
            this.farming_Events_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.farming_Events_Button.Name = "farming_Events_Button";
            this.farming_Events_Button.Size = new System.Drawing.Size(249, 51);
            this.farming_Events_Button.TabIndex = 16;
            this.farming_Events_Button.Text = "Farming Events";
            this.farming_Events_Button.UseVisualStyleBackColor = true;
            // 
            // reports_Button
            // 
            this.reports_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.reports_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports_Button.Location = new System.Drawing.Point(0, 357);
            this.reports_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reports_Button.Name = "reports_Button";
            this.reports_Button.Size = new System.Drawing.Size(249, 51);
            this.reports_Button.TabIndex = 15;
            this.reports_Button.Text = "Reports";
            this.reports_Button.UseVisualStyleBackColor = true;
            this.reports_Button.Click += new System.EventHandler(this.reports_Button_Click);
            // 
            // logout_Button
            // 
            this.logout_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_Button.Location = new System.Drawing.Point(0, 595);
            this.logout_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_Button.Name = "logout_Button";
            this.logout_Button.Size = new System.Drawing.Size(249, 51);
            this.logout_Button.TabIndex = 14;
            this.logout_Button.Text = "Logout";
            this.logout_Button.UseVisualStyleBackColor = true;
            // 
            // chemical_Button
            // 
            this.chemical_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.chemical_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemical_Button.Location = new System.Drawing.Point(0, 306);
            this.chemical_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chemical_Button.Name = "chemical_Button";
            this.chemical_Button.Size = new System.Drawing.Size(249, 51);
            this.chemical_Button.TabIndex = 13;
            this.chemical_Button.Text = "Chemicals";
            this.chemical_Button.UseVisualStyleBackColor = true;
            this.chemical_Button.Click += new System.EventHandler(this.chemical_Button_Click);
            // 
            // crops_Button
            // 
            this.crops_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.crops_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crops_Button.Location = new System.Drawing.Point(0, 255);
            this.crops_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crops_Button.Name = "crops_Button";
            this.crops_Button.Size = new System.Drawing.Size(249, 51);
            this.crops_Button.TabIndex = 12;
            this.crops_Button.Text = "Crops";
            this.crops_Button.UseVisualStyleBackColor = true;
            this.crops_Button.Click += new System.EventHandler(this.crops_Button_Click);
            // 
            // fields_Button
            // 
            this.fields_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.fields_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fields_Button.Location = new System.Drawing.Point(0, 204);
            this.fields_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fields_Button.Name = "fields_Button";
            this.fields_Button.Size = new System.Drawing.Size(249, 51);
            this.fields_Button.TabIndex = 11;
            this.fields_Button.Text = "Fields";
            this.fields_Button.UseVisualStyleBackColor = true;
            this.fields_Button.Click += new System.EventHandler(this.fields_Button_Click);
            // 
            // equipment_Button
            // 
            this.equipment_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.equipment_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipment_Button.Location = new System.Drawing.Point(0, 153);
            this.equipment_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.equipment_Button.Name = "equipment_Button";
            this.equipment_Button.Size = new System.Drawing.Size(249, 51);
            this.equipment_Button.TabIndex = 10;
            this.equipment_Button.Text = "Equipment";
            this.equipment_Button.UseVisualStyleBackColor = true;
            this.equipment_Button.Click += new System.EventHandler(this.equipment_Button_Click);
            // 
            // operators_Button
            // 
            this.operators_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.operators_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operators_Button.Location = new System.Drawing.Point(0, 102);
            this.operators_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.operators_Button.Name = "operators_Button";
            this.operators_Button.Size = new System.Drawing.Size(249, 51);
            this.operators_Button.TabIndex = 9;
            this.operators_Button.Text = "Operators";
            this.operators_Button.UseVisualStyleBackColor = true;
            this.operators_Button.Click += new System.EventHandler(this.operators_Button_Click);
            // 
            // breakdown_Button
            // 
            this.breakdown_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.breakdown_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_Button.Location = new System.Drawing.Point(0, 51);
            this.breakdown_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.breakdown_Button.Name = "breakdown_Button";
            this.breakdown_Button.Size = new System.Drawing.Size(249, 51);
            this.breakdown_Button.TabIndex = 8;
            this.breakdown_Button.Text = "Breakdown";
            this.breakdown_Button.UseVisualStyleBackColor = true;
            this.breakdown_Button.Click += new System.EventHandler(this.breakdown_Button_Click);
            // 
            // overview_Button
            // 
            this.overview_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.overview_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_Button.Location = new System.Drawing.Point(0, 0);
            this.overview_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.overview_Button.Name = "overview_Button";
            this.overview_Button.Size = new System.Drawing.Size(249, 51);
            this.overview_Button.TabIndex = 4;
            this.overview_Button.Text = "Overview";
            this.overview_Button.UseVisualStyleBackColor = true;
            this.overview_Button.Click += new System.EventHandler(this.overview_Button_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 646);
            this.panel1.TabIndex = 0;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 646);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainApp";
            this.Text = "MainApp";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button overview_Button;
        private System.Windows.Forms.Button breakdown_Button;
        private System.Windows.Forms.Button operators_Button;
        private System.Windows.Forms.Button equipment_Button;
        private System.Windows.Forms.Button fields_Button;
        private System.Windows.Forms.Button crops_Button;
        private System.Windows.Forms.Button chemical_Button;
        private System.Windows.Forms.Button logout_Button;
        private System.Windows.Forms.Button reports_Button;
        private System.Windows.Forms.Button farming_Events_Button;
        private System.Windows.Forms.Panel panel1;
    }
}