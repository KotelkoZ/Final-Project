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
    public partial class Field_UserControl : UserControl
    {
        private bool newFieldCheck = false;
        private bool updateFieldCheck = false;

        public Field_UserControl()
        {
            InitializeComponent();

            populate_Field_List();

            if (field_ListBox.Items.Count != 0)
            {
                field_ListBox.SelectedIndex = 0;
            }
            
        }
        private void clear_Text_Fields()
        {
            field_Name_TextBox.Clear();
            legal_Land_Description_TextBox.Clear();
            acres_TextBox.Clear();
            owned_ComboBox.SelectedIndex = 0;
            notes_RichTextBox.Clear();

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
            field_Name_TextBox.Enabled = value;
            legal_Land_Description_TextBox.Enabled = value;
            acres_TextBox.Enabled = value;
            owned_ComboBox.Enabled = value;
            notes_RichTextBox.Enabled = value;

            return;
        }
        private void set_Save_Cancel_Visibility(bool value)
        {
            save_Button.Visible = value;
            cancel_Button.Visible = value;

            return;
        }
        private void populate_Field_List()
        {
            field_ListBox.Items.Clear();

            var objects = JArray.Parse(API.retrieveAllFields());
            foreach (JObject root in objects)
            {
                StringBuilder fieldString = new StringBuilder();

                fieldString.Append(root.GetValue("Field_ID").ToString().Trim());
                fieldString.Append(" - ");
                fieldString.Append(root.GetValue("Field_Name").ToString().Trim());

                field_ListBox.Items.Add(fieldString);
            }
        }
        private void populate_Field_Info()
        {
            string cropID = "";
            string temp = this.field_ListBox.SelectedItem.ToString().Trim();

            cropID += temp.Split('-')[0].Trim();
            
            var objects = JArray.Parse(API.retrieveOneCrop(cropID));
            foreach (JObject root in objects)
            {
                field_ID_Label.Text = root.GetValue("Field_ID").ToString().Trim();
                field_Name_TextBox.Text = root.GetValue("Field_Name").ToString().Trim();
                legal_Land_Description_TextBox.Text = root.GetValue("Legal_Land_Description").ToString().Trim();
                acres_TextBox.Text = root.GetValue("Acres").ToString().Trim();
                if (Convert.ToBoolean(root.GetValue("Owned").ToString().Trim())){
                    owned_ComboBox.SelectedIndex = 1;
                }
                else
                {
                    owned_ComboBox.SelectedIndex = 2;
                }
                
                notes_RichTextBox.Text = root.GetValue("Notes").ToString().Trim();
            }
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            API.deleteCrop(Convert.ToInt16(this.field_ID_Label.Text.ToString().Trim()));

            populate_Field_List();

            set_Text_Enabled(false);
            set_Save_Cancel_Visibility(false);
            delete_Button.Visible = false;
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            field_ListBox.Enabled = true;

            return;
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
            if (field_Name_TextBox.Text.Trim().Equals("") ||
                legal_Land_Description_TextBox.Text.Trim().Equals("") ||
                acres_TextBox.Text.Trim().Equals("") ||
                owned_ComboBox.SelectedIndex.Equals(0)
                )
            {
                MessageBox.Show("Please enter the required information. (Field Name, Legal Land Description, Acres and Owned)");
                return;
            }

            API.farmField field = new API.farmField();

            if (field_Name_TextBox.Modified)
            {
                field.field_Name = field_Name_TextBox.Text.ToString().Trim();
            }
            if (legal_Land_Description_TextBox.Modified)
            {
                field.legalLandDescription = legal_Land_Description_TextBox.Text.ToString().Trim();
            }
            if (acres_TextBox.Modified)
            {
                field.acres = Convert.ToInt16(acres_TextBox.Text.ToString().Trim());
            }

            if (owned_ComboBox.Text.ToString().Trim() == "Owned")
            {
                field.owned = true;
            }
            else
            {
                field.owned = false;
            }
                
            if (notes_RichTextBox.Modified)
            {
                field.notes = notes_RichTextBox.Text.ToString().Trim();
            }

            if (newFieldCheck)
            {
                API.createField(field);
            }
            else if (updateFieldCheck)
            {
                API.updateField(field);
            }

            newFieldCheck = false;
            updateFieldCheck = false;

            set_Text_Enabled(false);
            set_Save_Cancel_Visibility(false);
            clear_Text_Fields();
            set_Main_Button_Visibility(true);
            delete_Button.Visible = false;

            field_ListBox.Enabled = true;

            populate_Field_List();

            field_ListBox.SelectedIndex = 0;

            populate_Field_Info();

            return;
        }
        private void update_Button_Click(object sender, EventArgs e)
        {
            updateFieldCheck = true;
            newFieldCheck = false;

            set_Text_Enabled(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);
            delete_Button.Visible = true;

            field_ListBox.Enabled = false;

            return;
        }
        private void new_Button_Click(object sender, EventArgs e)
        {
            newFieldCheck = true;
            updateFieldCheck = false;

            set_Text_Enabled(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);
            clear_Text_Fields();

            field_ListBox.Enabled = false;

            field_ID_Label.Text = "X";

            return;
        }
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            newFieldCheck = false;
            updateFieldCheck = false;

            clear_Text_Fields();
            set_Text_Enabled(false);
            set_Save_Cancel_Visibility(false);
            set_Main_Button_Visibility(true);
            delete_Button.Visible = false;

            field_ListBox.Enabled = true;

            if (field_ListBox.Items.Count != 0)
            {
                populate_Field_Info();
            }
            else
            {
                field_ID_Label.Text = "Field ID";
            }

            return;
        }
        private void field_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Field_Info();
        }

    }
}
