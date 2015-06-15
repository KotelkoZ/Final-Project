using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Tracker
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            //Put some stuff here. Ok ill put some stuff here. ZK Zak
            InitializeComponent();
        }
//Test comment 06/14 ZK Addressed
        private void login_Button_Click(object sender, EventArgs e)
        {
            main_Menu mainWindow = new main_Menu();
            mainWindow.Owner = this;
            mainWindow.Visible = true;

            this.Visible = false;

            return;
        }
    }
}
