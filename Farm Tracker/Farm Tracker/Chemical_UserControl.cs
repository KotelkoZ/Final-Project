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
    public partial class Chemical_UserControl : UserControl
    {
        private bool newChemicalCheck = false;
        private bool updateChemicalCheck = false;

        public Chemical_UserControl()
        {
            InitializeComponent();
            populate_Chemical_List();
            if (this.chemical_ListBox.Items.Count != 0)
            {
                this.chemical_ListBox.SelectedIndex = 0;
            }
        }
        private void clear_Text_Fields()
        {
            chemical_Name_TextBox.Clear();
            type_TextBox.Clear();
            brand_TextBox.Clear();
            notes_RichTextBox.Clear();
            chemical_ID_Label.Text = "X";

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
            chemical_Name_TextBox.Enabled = value;
            type_TextBox.Enabled = value;
            brand_TextBox.Enabled = value;
            notes_RichTextBox.Enabled = value;

            return;
        }
        private void set_Save_Cancel_Delete_Visibility(bool value)
        {
            save_Button.Visible = value;
            cancel_Button.Visible = value;
            delete_Button.Visible = value;

            return;
        }
        private void populate_Chemical_List()
        {
            chemical_ListBox.Items.Clear();

            var objects = JArray.Parse(API.retrieveAllChemicals());
            foreach (JObject root in objects)
            {
                StringBuilder chemicalString = new StringBuilder();

                chemicalString.Append(root.GetValue("Chemical_ID"));
                chemicalString.Append("\t");
                chemicalString.Append(root.GetValue("Chemical_Name"));
                chemicalString.Append(" ");
                chemicalString.Append(root.GetValue("Chemical_Type"));

                chemical_ListBox.Items.Add(chemicalString);
            }
        }
        private void populate_Chemical_Info()
        {
            if (chemical_ListBox.SelectedIndex == -1)
            {
                clear_Text_Fields();
                return;
            }

            string chemicalID = "";
            string temp = chemical_ListBox.SelectedItem.ToString().Trim();

            for (int i = 0; temp[i] != '\t'; i++)
            {
                chemicalID += temp[i];
            }

            var objects = JArray.Parse(API.retrieveOneChemical(chemicalID));
            foreach (JObject root in objects)
            {
                chemical_ID_Label.Text = root.GetValue("Chemical_ID").ToString().Trim();
                chemical_Name_TextBox.Text = root.GetValue("Chemical_Name").ToString().Trim();
                type_TextBox.Text = root.GetValue("Chemical_Type").ToString().Trim();
                brand_TextBox.Text = root.GetValue("Brand").ToString().Trim();
                notes_RichTextBox.Text = root.GetValue("Notes").ToString().Trim();
            }
        }
        private void chemical_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Chemical_Info();
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
            if (chemical_Name_TextBox.Text.Trim().Equals("") ||
                type_TextBox.Text.Trim().Equals("") ||
                brand_TextBox.Text.Trim().Equals("")
                )
            {
                MessageBox.Show("Please enter the required information. (Chemical Name, Type, and Brand)");
                return;
            }

            API.farmChemical chemical = new API.farmChemical();

            chemical.ID = Convert.ToInt16(chemical_ID_Label.Text.ToString().Trim());

            if (chemical_Name_TextBox.Modified)
            {
                chemical.chemicalName = chemical_Name_TextBox.Text.ToString().Trim();
            }
            if (type_TextBox.Modified)
            {
                chemical.chemicalType = type_TextBox.Text.ToString().Trim();
            }
            if (brand_TextBox.Modified)
            {
                chemical.brand = brand_TextBox.Text.ToString().Trim();
            }
            if (notes_RichTextBox.Modified)
            {
                chemical.notes = notes_RichTextBox.Text.ToString().Trim();
            }

            if (newChemicalCheck)
            {
                API.createChemical(chemical);
            }
            else if (updateChemicalCheck)
            {
                API.updateChemical(chemical);
            }

            newChemicalCheck = false;
            updateChemicalCheck = false;

            set_Text_Enabled(false);
            set_Save_Cancel_Delete_Visibility(false);
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            chemical_ListBox.Enabled = true;

            populate_Chemical_List();

            if (chemical_ListBox.Items.Count != 0)
            {
                chemical_ListBox.SelectedIndex = 0;
            }
            
            populate_Chemical_Info();

            return;
        }
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            newChemicalCheck = false;
            updateChemicalCheck = false;

            clear_Text_Fields();
            set_Text_Enabled(false);
            set_Save_Cancel_Delete_Visibility(false);
            set_Main_Button_Visibility(true);

            chemical_ListBox.Enabled = true;

            if (chemical_ListBox.Items.Count != 0)
            {
                populate_Chemical_Info();
            }
            else
            {
                chemical_ID_Label.Text = "Chemical ID";
            }

            return;
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            API.deleteChemical(Convert.ToInt16(this.chemical_ID_Label.Text.ToString().Trim()));

            populate_Chemical_List();

            set_Text_Enabled(false);
            set_Save_Cancel_Delete_Visibility(false);
            delete_Button.Visible = false;
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            chemical_ListBox.Enabled = true;

            return;
        }
        private void update_Button_Click(object sender, EventArgs e)
        {
            if (chemical_ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a chemical to update.");
                return;
            }

            updateChemicalCheck = true;
            newChemicalCheck = false;

            set_Text_Enabled(true);
            set_Save_Cancel_Delete_Visibility(true);
            set_Main_Button_Visibility(false);

            this.chemical_ListBox.Enabled = false;

            return;
        }
        private void new_Button_Click(object sender, EventArgs e)
        {
            newChemicalCheck = true;
            updateChemicalCheck = false;

            set_Text_Enabled(true);
            set_Save_Cancel_Delete_Visibility(true);
            delete_Button.Visible = false;
            set_Main_Button_Visibility(false);
            clear_Text_Fields();

            this.chemical_ListBox.Enabled = false;

            this.chemical_ID_Label.Text = "X";

            return;
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_Button_Click(sender, e);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_Button_Click(sender, e);
        }
        private void chemical_ListBox_RightClick(object sender, MouseEventArgs e)
        {
            chemical_ListBox.SelectedIndex = chemical_ListBox.IndexFromPoint(e.X, e.Y);
        }
        private void chemical_ListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (chemical_ListBox.SelectedIndex == -1)
            {
                chemicals_ContextMenuStrip.Close();
            }
        }
    }
}
