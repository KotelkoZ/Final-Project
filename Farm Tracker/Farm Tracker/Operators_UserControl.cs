using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Farm_Tracker
{
    public partial class Operators_UserControl : UserControl
    {
        private bool newOperatorCheck = false;
        private bool updateOperatorCheck = false;

        public Operators_UserControl()
        {
            InitializeComponent();
            set_Text_Enabled(false);

            API.retrieveAllOperators();

            populate_Operator_List();

            if (operator_ListBox.Items.Count > 0)
            {
                operator_ListBox.SelectedIndex = 0;
            }
            
        }
        private void clear_Text_Fields()
        {
            first_Name_TextBox.Clear();
            last_Name_TextBox.Clear();
            position_TextBox.Clear();
            language_TextBox.Clear();
            email_TextBox.Clear();
            phone_Number_TextBox.Clear();
            password_TextBox.Clear();
            confirm_Password_TextBox.Clear();

            return;
        }
        private void set_Main_Button_Visibility(bool value)
        {
            update_Button.Visible = value;
            new_Button.Visible = value;

            return;
        }
        private void set_Text_Enabled(bool value)
        {
            first_Name_TextBox.Enabled = value;
            last_Name_TextBox.Enabled = value;
            position_TextBox.Enabled = value;
            language_TextBox.Enabled = value;
            email_TextBox.Enabled = value;
            phone_Number_TextBox.Enabled = value;

            return;
        }
        private void set_Password_Visibility(bool value)
        {
            password_Label.Visible = value;
            password_TextBox.Visible = value;
            confirm_Password_Label.Visible = value;
            confirm_Password_TextBox.Visible = value;

            return;
        }
        private void set_Save_Cancel_Delete_Visibility(bool value)
        {
            save_Button.Visible = value;
            cancel_Button.Visible = value;
            delete_Button.Visible = value;

            return;
        }
        private void populate_Operator_List()
        {
            operator_ListBox.Items.Clear();

            var objects = JArray.Parse(API.retrieveAllOperators());
            foreach (JObject root in objects)
            {

                StringBuilder operatorString = new StringBuilder();
                operatorString.Append(root.GetValue("Operator_ID").ToString().Trim());
                operatorString.Append(" - ");
                operatorString.Append(root.GetValue("First_Name").ToString().Trim());
                operatorString.Append(" ");
                operatorString.Append(root.GetValue("Last_Name").ToString().Trim());

                operator_ListBox.Items.Add(operatorString);
                
            }
        }
        private void populate_Operator_Info()
        {
            string operatorID = "";
            if (operator_ListBox.SelectedItems.Count == 0)
            {
                operator_ListBox.SelectedIndex = 0;
            }
            string temp = operator_ListBox.SelectedItem.ToString().Trim();

            operatorID += temp.Split('-')[0].ToString().Trim();            

            var objects = JArray.Parse(API.retrieveOneOperator(operatorID));
            foreach (JObject root in objects)
            {
                operator_ID_Label.Text = root.GetValue("Operator_ID").ToString().Trim();
                first_Name_TextBox.Text = root.GetValue("First_Name").ToString().Trim();
                last_Name_TextBox.Text = root.GetValue("Last_Name").ToString().Trim();
                position_TextBox.Text = root.GetValue("Position").ToString().Trim();
                language_TextBox.Text = root.GetValue("Language").ToString().Trim();
                email_TextBox.Text = root.GetValue("Email").ToString().Trim();
                phone_Number_TextBox.Text = root.GetValue("Phone_Number").ToString().Trim();
            }
        }        
        private void update_Password_Button_Click(object sender, EventArgs e)
        {
            set_Password_Visibility(true);
            set_Save_Cancel_Delete_Visibility(true);
            set_Main_Button_Visibility(false);

            delete_Button.Visible = false;

            operator_ListBox.Enabled = false;

            return;
        }
        private void update_Button_Click(object sender, EventArgs e)
        {
            updateOperatorCheck = true;
            newOperatorCheck = false;

            set_Text_Enabled(true);
            set_Save_Cancel_Delete_Visibility(true);
            set_Main_Button_Visibility(false);
            delete_Button.Visible = true;

            operator_ListBox.Enabled = false;

            return;
        }
        private void new_Button_Click(object sender, EventArgs e)
        {
            newOperatorCheck = true;
            updateOperatorCheck = false;

            set_Text_Enabled(true);
            set_Password_Visibility(true);
            set_Save_Cancel_Delete_Visibility(true);
            set_Main_Button_Visibility(false);

            delete_Button.Visible = false;

            operator_ListBox.Enabled = false;

            operator_ID_Label.Text = "X";

            return;
        }
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            newOperatorCheck = false;
            updateOperatorCheck = false;

            clear_Text_Fields();
            set_Text_Enabled(false);
            set_Password_Visibility(false);
            set_Save_Cancel_Delete_Visibility(false);
            set_Main_Button_Visibility(true);
            delete_Button.Visible = false;

            operator_ListBox.Enabled = true;

            if (operator_ListBox.Items.Count != 0)
            {
                populate_Operator_Info();
            }
            else
            {
                operator_ID_Label.Text = "Operator ID";
            }

            return;
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
            if (password_TextBox.Visible)
            {
                if (password_TextBox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("No password has been entered.");
                    return;
                }
                if (password_TextBox.Text.Trim().ToString() != confirm_Password_TextBox.Text.Trim().ToString())
                {
                    MessageBox.Show("The passwords entered do not match.");
                    return;
                }
            }
            if (first_Name_TextBox.Visible)
            {
                if (first_Name_TextBox.Text.Trim().Equals("") ||
                    last_Name_TextBox.Text.Trim().Equals("") ||
                    position_TextBox.Text.Trim().Equals("") ||
                    language_TextBox.Text.Trim().Equals("")
                    )
                {
                    MessageBox.Show("Please enter the required information. (First Name, Last Name, Position and Language)");
                    return;
                }
            }

            API.farmOperator person = new API.farmOperator();
            
            if (first_Name_TextBox.Modified)
            {
                person.firstName = first_Name_TextBox.Text.ToString().Trim();
            }
            if (last_Name_TextBox.Modified)
            {
            person.lastName = last_Name_TextBox.Text.ToString().Trim();
            }
            if (position_TextBox.Modified)
            {
            person.position = position_TextBox.Text.ToString().Trim();
            }
            if (language_TextBox.Modified)
            {
            person.language = language_TextBox.Text.ToString().Trim();
            }
            if (email_TextBox.Modified)
            {
                person.email = email_TextBox.Text.ToString().Trim();
            }
            if (phone_Number_TextBox.Modified)
            {
                person.phoneNumber = phone_Number_TextBox.Text.ToString().Trim();
            }
            if (password_TextBox.Modified)
            {
                person.password = password_TextBox.Text.ToString().Trim();
            }
            if (newOperatorCheck)
            {
                API.createOperator(person);
            }
            else if (updateOperatorCheck)
            {
                person.ID = Convert.ToInt16(operator_ID_Label.Text.ToString().Trim());
                API.updateOperator(person);
            }
                
            newOperatorCheck = false;
            updateOperatorCheck = false;

            set_Text_Enabled(false);
            set_Password_Visibility(false);
            set_Save_Cancel_Delete_Visibility(false);
            clear_Text_Fields();
            set_Main_Button_Visibility(true);
            delete_Button.Visible = false;

            operator_ListBox.Enabled = true;

            populate_Operator_List();
            
            operator_ListBox.SelectedIndex = 0;

            populate_Operator_Info();

            return;
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            API.deleteOperator(Convert.ToInt16(this.operator_ID_Label.Text));

            populate_Operator_List();

            set_Text_Enabled(false);
            set_Password_Visibility(false);
            set_Save_Cancel_Delete_Visibility(false);
            delete_Button.Visible = false;
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            operator_ListBox.Enabled = true;

            return;
        }
        private void operator_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Operator_Info();
        }
    }
}
