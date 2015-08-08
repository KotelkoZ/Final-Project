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

namespace Farm_Tracker
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            //Put some stuff here. Ok ill put some stuff here. ZK Zak
            InitializeComponent();

        }

        private void login_Button_Click(object sender, EventArgs e)
        {

            main_Menu mainWindow = new main_Menu();
            mainWindow.Owner = this;
            mainWindow.Visible = true;

            this.Visible = false;

            return;

            //String password

            String queryString = "select Operators.Operator_ID, Operators.Password, Operators.Position from Operators where Operators.Operator_ID = '" + this.operator_ID_Textbox.Text.ToString().Trim() + "'";

            using (SqlConnection connection = new SqlConnection(Global_Variables.CONNECTIONSTRING))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();

                            MessageBox.Show(reader[2].ToString().Trim() + "\n" + reader[0].ToString());

                            if (Utility_Functions.Decrypt(reader[1].ToString().Trim()) == this.password_TextBox.Text.ToString().Trim())
                            {

                                //MessageBox.Show(reader[2].ToString().Trim() + "\n" + reader[2].ToString().Equals("Manager"));

                                if (reader[2].ToString().Trim() == "Manager")
                                {

                                    //main_Menu mainWindow = new main_Menu();
                                    //mainWindow.Owner = this;
                                    //mainWindow.Visible = true;

                                    //this.Visible = false;
                                    //Management_Form managementForm = new Management_Form();
                                    //managementForm.Visible = true;
                                }
                                if (reader[2].ToString().Trim() == "Operator")
                                {
                                    //Check_InOut_Form checkInWindow = new Check_InOut_Form();
                                    //checkInWindow.Visible = true;
                                }
                                if (reader[2].ToString().Trim() == "Mechanic")
                                {
                                    //Maid_Service_Form newMaidForm = new Maid_Service_Form();
                                    //newMaidForm.Visible = true;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password. Please try again.");
                            }

                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The username or password are not correct.");
                    }

                }
                connection.Close();
            }






            

            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            API.retrieveOperator();
        }
    }
}
