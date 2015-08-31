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
    public partial class Crop_UserControl : UserControl
    {
        private bool newCropCheck = false;
        private bool updateCropCheck = false;

        public Crop_UserControl()
        {
            InitializeComponent();

            populate_Crop_List();

            if (this.crop_ListBox.Items.Count != 0)
            {
                this.crop_ListBox.SelectedIndex = 0;
            }
            
        }
        private void clear_Text_Fields()
        {
            crop_Name_TextBox.Clear();
            species_TextBox.Clear();
            variety_TextBox.Clear();
            brand_TextBox.Clear();
            notes_RichTextBox.Clear();
            crop_ID_Label.Text = "X";

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
            crop_Name_TextBox.Enabled = value;
            species_TextBox.Enabled = value;
            variety_TextBox.Enabled = value;
            brand_TextBox.Enabled = value;
            notes_RichTextBox.Enabled = value;

            return;
        }
        private void set_Save_Cancel_Visibility(bool value)
        {
            save_Button.Visible = value;
            cancel_Button.Visible = value;

            return;
        }
        private void populate_Crop_List()
        {
            crop_ListBox.Items.Clear();

            var objects = JArray.Parse(API.retrieveAllCrops());
            foreach (JObject root in objects)
            {
                StringBuilder cropString = new StringBuilder();

                cropString.Append(root.GetValue("Crop_ID").ToString().Trim());
                cropString.Append(" - ");
                cropString.Append(root.GetValue("Crop_Name").ToString().Trim());
                cropString.Append(" - ");
                cropString.Append(root.GetValue("Brand").ToString().Trim());

                crop_ListBox.Items.Add(cropString);
            }
            if (crop_ListBox.Items.Count != 0)
            {
                crop_ListBox.SelectedIndex = 0;
            }
        }
        private void populate_Crop_Info()
        {
            if (crop_ListBox.SelectedIndex == -1)
            {
                clear_Text_Fields();
                return;
            }

            string cropID = "";
            string temp = crop_ListBox.SelectedItem.ToString().Trim();

            cropID += temp.Split('-')[0].Trim();
            
            var objects = JArray.Parse(API.retrieveOneCrop(cropID));
            foreach (JObject root in objects)
            {
                crop_ID_Label.Text = root.GetValue("Crop_ID").ToString().Trim();
                crop_Name_TextBox.Text = root.GetValue("Crop_Name").ToString().Trim();
                species_TextBox.Text = root.GetValue("Species").ToString().Trim();
                variety_TextBox.Text = root.GetValue("Variety").ToString().Trim();
                brand_TextBox.Text = root.GetValue("Brand").ToString().Trim();
                notes_RichTextBox.Text = root.GetValue("Notes").ToString().Trim();
            }
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            API.deleteCrop(Convert.ToInt16(this.crop_ID_Label.Text.ToString().Trim()));

            populate_Crop_List();

            set_Text_Enabled(false);
            set_Save_Cancel_Visibility(false);
            delete_Button.Visible = false;
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            crop_ListBox.Enabled = true;

            return;
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
            if (crop_Name_TextBox.Text.Trim().Equals("") ||
                species_TextBox.Text.Trim().Equals("") ||
                variety_TextBox.Text.Trim().Equals("") ||
                brand_TextBox.Text.Trim().Equals("")
                )
            {
                MessageBox.Show("Please enter the required information. (Crop Name, Species, Variety and Brand)");
                return;
            }
            
            API.farmCrop crop = new API.farmCrop();

            if (crop_Name_TextBox.Modified)
            {
                crop.cropName = crop_Name_TextBox.Text.ToString().Trim();
            }
            if (species_TextBox.Modified)
            {
                crop.species = species_TextBox.Text.ToString().Trim();
            }
            if (variety_TextBox.Modified)
            {
                crop.variety = variety_TextBox.Text.ToString().Trim();
            }
            if (brand_TextBox.Modified)
            {
                crop.brand = brand_TextBox.Text.ToString().Trim();
            }
            if (notes_RichTextBox.Modified)
            {
                crop.notes = notes_RichTextBox.Text.ToString().Trim();
            }

            if (newCropCheck)
            {
                API.createCrop(crop);
            }
            else if (updateCropCheck)
            {
                API.updateCrop(crop);
            }

            newCropCheck = false;
            updateCropCheck = false;

            set_Text_Enabled(false);
            set_Save_Cancel_Visibility(false);
            clear_Text_Fields();
            set_Main_Button_Visibility(true);
            delete_Button.Visible = false;

            crop_ListBox.Enabled = true;

            populate_Crop_List();

            crop_ListBox.SelectedIndex = 0;

            populate_Crop_Info();

            return;
        }
        private void update_Button_Click(object sender, EventArgs e)
        {
            if (crop_ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a crop to update.");
                return;
            }

            updateCropCheck = true;
            newCropCheck = false;

            set_Text_Enabled(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);
            delete_Button.Visible = true;

            crop_ListBox.Enabled = false;

            return;
        }
        private void new_Button_Click(object sender, EventArgs e)
        {
            newCropCheck = true;
            updateCropCheck = false;

            set_Text_Enabled(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);
            clear_Text_Fields();

            crop_ListBox.Enabled = false;

            crop_ID_Label.Text = "X";

            return;
        }
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            newCropCheck = false;
            updateCropCheck = false;

            clear_Text_Fields();
            set_Text_Enabled(false);
            set_Save_Cancel_Visibility(false);
            set_Main_Button_Visibility(true);
            delete_Button.Visible = false;

            crop_ListBox.Enabled = true;

            if (crop_ListBox.Items.Count != 0)
            {
                populate_Crop_Info();
            }
            else
            {
                crop_ID_Label.Text = "Crop ID";
            }

            return;
        }
        private void crop_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Crop_Info();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_Button_Click(sender, e);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_Button_Click(sender, e);
        }
        private void crop_ListBox_RightClick(object sender, MouseEventArgs e)
        {
            crop_ListBox.SelectedIndex = crop_ListBox.IndexFromPoint(e.X, e.Y);
        }
        private void crop_ListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (crop_ListBox.SelectedIndex == -1)
            {
                crop_ContextMenuStrip.Close();
            }
        }
    }
}
