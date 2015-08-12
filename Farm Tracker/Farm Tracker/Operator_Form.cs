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
    public partial class Operator_Form : Form
    {
        public Operator_Form()
        {
            InitializeComponent();
            set_Text_Visibility(false);
            set_Label_Visibility(true);

            API.retrieveAllOperators();

            populate_Operator_List();

            if (this.operator_ListBox.Items.Count > 0)
            {
                this.operator_ListBox.SelectedIndex = 0;
            }
            
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
        private void set_Main_Button_Visibility(bool value)
        {
            this.update_Password_Button.Visible = value;
            this.update_Operator_Button.Visible = value;
            this.new_Operator_Button.Visible = value;

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
        private void populate_Operator_List()
        {
            this.operator_ListBox.Items.Clear();

            var objects = JArray.Parse(API.retrieveAllOperators());
            foreach (JObject root in objects)
            {

                StringBuilder operatorString = new StringBuilder();
                operatorString.Append(root.GetValue("Operator_ID").ToString().Trim());
                operatorString.Append("\t");
                operatorString.Append(root.GetValue("First_Name").ToString().Trim());
                operatorString.Append(" ");
                operatorString.Append(root.GetValue("Last_Name").ToString().Trim());

                this.operator_ListBox.Items.Add(operatorString);
                
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

            var objects = JArray.Parse(API.retrieveOperator(operatorID));
            foreach (JObject root in objects)
            {
                this.operator_ID_Label.Text = root.GetValue("Operator_ID").ToString().Trim();
                this.first_Name_Label.Text = root.GetValue("First_Name").ToString().Trim();
                this.last_Name_Label.Text = root.GetValue("Last_Name").ToString().Trim();
                this.position_Label.Text = root.GetValue("Position").ToString().Trim();
                this.language_Label.Text = root.GetValue("Language").ToString().Trim();
                this.email_Label.Text = root.GetValue("Email").ToString().Trim();
                this.phone_Number_Label.Text = root.GetValue("Phone_Number").ToString().Trim();
            }
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

                API.farmOperator newPerson = new API.farmOperator();

                newPerson.firstName = this.first_Name_TextBox.Text.ToString().Trim();
                newPerson.lastName = this.last_Name_TextBox.Text.ToString().Trim();
                newPerson.position = this.position_TextBox.Text.ToString().Trim();
                newPerson.language = this.language_TextBox.Text.ToString().Trim();
                
                if (this.email_TextBox.Text.ToString().Trim() != "")
                {
                    newPerson.email = this.email_TextBox.Text.ToString().Trim();    
                }
                if (this.phone_Number_TextBox.Text.ToString().Trim() != "") 
                {
                    newPerson.phoneNumber = this.phone_Number_TextBox.Text.ToString().Trim();
                }

                newPerson.password = Utility_Functions.Encrypt(this.password_TextBox.Text.ToString().Trim());
                
                API.createOperator(newPerson);
                
            }
            else
            {
                if (this.password_TextBox.Visible)
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
                }
                if (this.first_Name_TextBox.Visible)
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
                }

                API.farmOperator updatePerson = new API.farmOperator();
                updatePerson.ID = Convert.ToInt16(this.operator_ID_Label.Text.ToString().Trim());
                if (this.first_Name_TextBox.Modified)
                {
                    updatePerson.firstName = this.first_Name_TextBox.Text.ToString().Trim();
                }
                if (this.last_Name_TextBox.Modified)
                {
                updatePerson.lastName = this.last_Name_TextBox.Text.ToString().Trim();
                }
                if (this.position_TextBox.Modified)
                {
                updatePerson.position = this.position_TextBox.Text.ToString().Trim();
                }
                if (this.language_TextBox.Modified)
                {
                updatePerson.language = this.language_TextBox.Text.ToString().Trim();
                }
                if (this.email_TextBox.Modified)
                {
                    updatePerson.email = this.email_TextBox.Text.ToString().Trim();
                }
                if (this.phone_Number_TextBox.Modified)
                {
                    updatePerson.phoneNumber = this.phone_Number_TextBox.Text.ToString().Trim();
                }
                if (this.password_TextBox.Modified)
                {
                    updatePerson.password = this.password_TextBox.Text.ToString().Trim();
                }

                API.updateOperator(updatePerson);
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
        private void operator_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Operator_Info();
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            API.deleteOperator(Convert.ToInt16(this.operator_ID_Label.Text));

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
