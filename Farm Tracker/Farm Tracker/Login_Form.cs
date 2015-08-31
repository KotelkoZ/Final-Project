using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Newtonsoft.Json.Linq;

namespace Farm_Tracker
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {

            if (operator_ID_Textbox.Text.ToString().Trim() == "" || password_TextBox.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Please enter an operator ID and password.");
                return;
            }

            var objects = JArray.Parse(API.retrieveOneOperator(operator_ID_Textbox.Text.ToString().Trim()));

            if (objects.Count > 0)
            {
                foreach (JObject root in objects)
                {
                    string password = Utility_Functions.Decrypt(root.GetValue("Password").ToString().Trim());
                    if (password == password_TextBox.Text.ToString().Trim())
                    {
                        MainApp mainWindow = new MainApp(root.GetValue("Position").ToString().Trim());
                        mainWindow.Visible = true;
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("The operator ID or password are incorrect.\nPlease try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("The operator ID or password are incorrect.\nPlease try again.");
            }
            
            return;
        }
        private void Login_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainApp mainWindow = new MainApp("Manager");
            mainWindow.Visible = true;
            this.Visible = false;
        }
    }
}
