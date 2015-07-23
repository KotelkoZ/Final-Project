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
    public partial class Operator_Form : Form
    {
        public Operator_Form()
        {
            InitializeComponent();
            set_Text_Visibility(false);
            set_Label_Visibility(true);

           

            populate_Operator_List();

            this.operator_ListBox.SelectedIndex = 0;
        }

        private void update_Password_Button_Click(object sender, EventArgs e)
        {
            set_Password_Visibility(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);

            this.operator_ListBox.Enabled = false;

            return;
        }

        private void update_Operator_Button_Click(object sender, EventArgs e)
        {
            set_Label_Visibility(false);
            set_Text_Visibility(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);
            this.delete_Button.Visible = true;

            this.first_Name_TextBox.Text = this.first_Name_Label.Text;
            this.last_Name_TextBox.Text = this.last_Name_Label.Text;
            this.position_TextBox.Text = this.position_Label.Text;
            this.language_TextBox.Text = this.language_Label.Text;
            this.email_TextBox.Text = this.email_Label.Text;
            this.phone_Number_TextBox.Text = this.phone_Number_Label.Text;

            this.operator_ListBox.Enabled = false;

            return;
        }


        private void new_Operator_Button_Click(object sender, EventArgs e)
        {
            set_Label_Visibility(false);
            set_Text_Visibility(true);
            set_Password_Visibility(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);

            this.operator_ListBox.Enabled = false;

            this.operator_ID_Label.Text = "X";

            return;
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            clear_Text_Fields();
            set_Label_Visibility(true);
            set_Text_Visibility(false);
            set_Password_Visibility(false);
            set_Save_Cancel_Visibility(false);
            set_Main_Button_Visibility(true);
            this.delete_Button.Visible = false;

            this.operator_ListBox.Enabled = true;

            if (this.operator_ListBox.Items.Count != 0)
            {
                populate_Operator_Info();
            }
            else
            {
                this.operator_ID_Label.Text = "Operator ID";
            }

            return;
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            
            //NEW OPERATOR
            if (this.first_Name_TextBox.Visible == true && this.password_TextBox.Visible == true)
            {
                if (this.password_TextBox.Text.Trim().Equals("") || 
                    this.first_Name_TextBox.Text.Trim().Equals("") || 
                    this.last_Name_TextBox.Text.Trim().Equals("") || 
                    this.position_TextBox.Text.Trim().Equals("") ||
                    this.language_TextBox.Text.Trim().Equals("")
                    )
                {
                    MessageBox.Show("Please enter the required information. (First Name, Last Name, Position, Language and Password)");
                    return;
                }
                if (this.password_TextBox.Text.Trim().ToString() != this.confirm_Password_TextBox.Text.Trim().ToString())
                {
                    MessageBox.Show("The passwords entered did not match.");
                    this.password_TextBox.Clear();
                    this.confirm_Password_TextBox.Clear();
                    return;
                }

                string queryString = "insert into Operators (Operators.First_Name, Operators.Last_Name, Operators.Position, Operators.Language, ";
                
                if (this.email_TextBox.Text.ToString().Trim() != "")
                {
                    queryString += "Operators.Email, ";
                }
                if (this.phone_Number_TextBox.Text.ToString().Trim() != "") 
                {
                    queryString += "Operators.Phone_Number, ";
                }

                queryString += "Operators.Password) " +
                    "values ('" + this.first_Name_TextBox.Text.ToString().Trim() + "', '" +
                                    this.last_Name_TextBox.Text.ToString().Trim() + "', '" +
                                    this.position_TextBox.Text.ToString().Trim() + "', '" +
                                    this.language_TextBox.Text.ToString().Trim() + "', '";
                                    
                if (this.email_TextBox.Text.ToString().Trim() != "")
                {
                    queryString += this.email_TextBox.Text.ToString().Trim() + "', '";
                }
                if (this.phone_Number_TextBox.Text.ToString().Trim() != "") 
                {
                    queryString += this.phone_Number_TextBox.Text.ToString().Trim() + "', '";
                }
                
                queryString += myFunctions.Encrypt(this.password_TextBox.Text.ToString().Trim()) + "')";

                MessageBox.Show(queryString);

                string queryMessage = "Insert operator";
                string querySuccess = "Operator has been created.";
                string queryFail = "There was a problem, the operator was not created.";

                myFunctions.queryExecute(queryString, queryMessage, querySuccess, queryFail);
                
            }
            //UPDATE PASSWORD
            else if (this.password_TextBox.Visible == true && this.first_Name_TextBox.Visible == false)
            {

                if (this.password_TextBox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("No password has been entered.");
                    return;
                }
                if (this.password_TextBox.Text.Trim().ToString() != this.confirm_Password_TextBox.Text.Trim().ToString())
                {
                    MessageBox.Show("The passwords entered do not match.");
                    return;
                }
                
                string queryString = "update Operators set Operators.Password = '" +
                                    myFunctions.Encrypt(this.password_TextBox.Text.ToString().Trim()) +
                                    "' where Operators.Operator_ID = '" + this.operator_ID_Label.Text.ToString().Trim() + "'";

                string queryMessage = "Update operator password";
                string querySuccess = "Operator password has been updated.";
                string queryFail = "There was a problem, the operator password was not updated.";

                myFunctions.queryExecute(queryString, queryMessage, querySuccess, queryFail);
            }
            //UPDATE OPERATOR
            else
            {

                if (this.first_Name_TextBox.Text.Trim().Equals("") ||
                    this.last_Name_TextBox.Text.Trim().Equals("") ||
                    this.position_TextBox.Text.Trim().Equals("") ||
                    this.language_TextBox.Text.Trim().Equals("")
                    )
                {
                    MessageBox.Show("Please enter the required information. (First Name, Last Name, Position and Language)");
                    return;
                }

                string queryString = "update Operators set Operators.First_Name = '" + this.first_Name_TextBox.Text.ToString().Trim() +
                                            "', Operators.Last_Name = '" + this.last_Name_TextBox.Text.ToString().Trim() +
                                            "', Operators.Position = '" + this.position_TextBox.Text.ToString().Trim() +
                                            "', Operators.Language = '" + this.language_TextBox.Text.ToString().Trim() + "'";

                if (this.email_TextBox.Text.ToString().Trim() != "")
                {
                    queryString += ", Operators.Email = '" + this.email_TextBox.Text.ToString().Trim() + "'";
                }
                if (this.phone_Number_TextBox.Text.ToString().Trim() != "")
                {
                    queryString += ", Operators.Phone_Number = '" + this.phone_Number_TextBox.Text.ToString().Trim() + "'";
                }

               queryString += " Where Operators.Operator_ID = " + this.operator_ID_Label.Text.ToString().Trim(); 

                string queryMessage = "Update operator";
                string querySuccess = "Operator has been updated.";
                string queryFail = "There was a problem, the operator was not updated.";

                myFunctions.queryExecute(queryString, queryMessage, querySuccess, queryFail);

            }

            set_Text_Visibility(false);
            set_Label_Visibility(true);
            set_Password_Visibility(false);
            set_Save_Cancel_Visibility(false);
            clear_Text_Fields();
            set_Main_Button_Visibility(true);
            this.delete_Button.Visible = false;

            this.operator_ListBox.Enabled = true;

            populate_Operator_List();
            
            this.operator_ListBox.SelectedIndex = 0;

            populate_Operator_Info();

            return;
        }

        private void set_Main_Button_Visibility(bool value)
        {
            this.update_Password_Button.Visible = value;
            this.update_Operator_Button.Visible = value;
            this.new_Operator_Button.Visible = value;

            return;
        }

        private void clear_Text_Fields()
        {
            this.first_Name_TextBox.Clear();
            this.last_Name_TextBox.Clear();
            this.position_TextBox.Clear();
            this.language_TextBox.Clear();
            this.email_TextBox.Clear();
            this.phone_Number_TextBox.Clear();
            this.password_TextBox.Clear();
            this.confirm_Password_TextBox.Clear();

            return;
        }

        private void set_Text_Visibility(bool value)
        {
            this.first_Name_TextBox.Visible = value;
            this.last_Name_TextBox.Visible = value;
            this.position_TextBox.Visible = value;
            this.language_TextBox.Visible = value;
            this.email_TextBox.Visible = value;
            this.phone_Number_TextBox.Visible = value;

            return;
        }

        private void set_Password_Visibility(bool value)
        {
            this.password_Label.Visible = value;
            this.password_TextBox.Visible = value;
            this.confirm_Password_Label.Visible = value;
            this.confirm_Password_TextBox.Visible = value;

            return;
        }

        private void set_Save_Cancel_Visibility(bool value)
        {
            this.save_Button.Visible = value;
            this.cancel_Button.Visible = value;

            return;
        }

        private void set_Label_Visibility(bool value)
        {
            this.first_Name_Label.Visible = value;
            this.last_Name_Label.Visible = value;
            this.language_Label.Visible = value;

            return;
        }

        private void operator_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Operator_Info();
        }

        private void populate_Operator_List()
        {
            this.operator_ListBox.Items.Clear();
           
            String queryString = "select Operators.Operator_ID, Operators.First_Name, Operators.Last_Name from Operators ";


            using (SqlConnection connection = new SqlConnection(Variables.CONNECTIONSTRING))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.operator_ListBox.Items.Add(reader[0].ToString().Trim() + "\t" +
                                                            reader[1].ToString().Trim() + "\t" +
                                                            reader[2].ToString().Trim());
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }
        }

        private void populate_Operator_Info()
        {

            string operatorID = "";
            string temp = this.operator_ListBox.SelectedItem.ToString().Trim();

            for (int i = 0; temp[i] != '\t'; i++)
            {
                operatorID += temp[i];
            }

            String queryString = "select * from Operators where Operators.Operator_ID = " + operatorID;

            using (SqlConnection connection = new SqlConnection(Variables.CONNECTIONSTRING))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                            this.operator_ID_Label.Text = reader[0].ToString().Trim();
                            this.first_Name_Label.Text = reader[1].ToString().Trim();
                            this.last_Name_Label.Text = reader[2].ToString().Trim();
                            this.position_Label.Text = reader[3].ToString().Trim();
                            this.language_Label.Text = reader[4].ToString().Trim();
                            this.email_Label.Text = reader[5].ToString().Trim();
                            this.phone_Number_Label.Text = reader[6].ToString().Trim();
                    
                        reader.Close();
                    }
                }
                connection.Close();
            }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            API_Functions.deleteOperator(Convert.ToInt16(this.operator_ID_Label.Text));

            populate_Operator_List();

            set_Text_Visibility(false);
            set_Label_Visibility(true);
            set_Password_Visibility(false);
            set_Save_Cancel_Visibility(false);
            this.delete_Button.Visible = false;
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            this.operator_ListBox.Enabled = true;

            return;
        }

    }
}
