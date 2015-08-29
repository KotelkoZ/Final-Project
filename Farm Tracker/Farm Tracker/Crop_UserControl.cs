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
            this.crop_Name_TextBox.Clear();
            this.species_TextBox.Clear();
            this.variety_TextBox.Clear();
            this.brand_TextBox.Clear();
            this.notes_RichTextBox.Clear();

            return;
        }
        private void set_Main_Button_Visibility(bool value)
        {
            this.update_Button.Visible = value;
            this.new_Button.Visible = value;

            return;
        }
        private void set_Text_Enabled(bool value)
        {
            this.crop_Name_TextBox.Enabled = value;
            this.species_TextBox.Enabled = value;
            this.variety_TextBox.Enabled = value;
            this.brand_TextBox.Enabled = value;
            this.notes_RichTextBox.Enabled = value;

            return;
        }
        private void set_Save_Cancel_Visibility(bool value)
        {
            this.save_Button.Visible = value;
            this.cancel_Button.Visible = value;

            return;
        }
        private void populate_Crop_List()
        {
            this.crop_ListBox.Items.Clear();

            var objects = JArray.Parse(API.retrieveAllCrops());
            foreach (JObject root in objects)
            {
                StringBuilder cropString = new StringBuilder();

                cropString.Append(root.GetValue("Crop_ID").ToString().Trim());
                cropString.Append(" - ");
                cropString.Append(root.GetValue("Crop_Name").ToString().Trim());
                cropString.Append(" - ");
                cropString.Append(root.GetValue("Brand").ToString().Trim());

                this.crop_ListBox.Items.Add(cropString);
            }
        }
        private void populate_Crop_Info()
        {
            string cropID = "";
            string temp = this.crop_ListBox.SelectedItem.ToString().Trim();

            cropID += temp.Split('-')[0].Trim();
            
            var objects = JArray.Parse(API.retrieveOneCrop(cropID));
            foreach (JObject root in objects)
            {
                this.crop_ID_Label.Text = root.GetValue("Crop_ID").ToString().Trim();
                this.crop_Name_TextBox.Text = root.GetValue("Crop_Name").ToString().Trim();
                this.species_TextBox.Text = root.GetValue("Species").ToString().Trim();
                this.variety_TextBox.Text = root.GetValue("Variety").ToString().Trim();
                this.brand_TextBox.Text = root.GetValue("Brand").ToString().Trim();
                this.notes_RichTextBox.Text = root.GetValue("Notes").ToString().Trim();
            }
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            API.deleteCrop(Convert.ToInt16(this.crop_ID_Label.Text.ToString().Trim()));

            populate_Crop_List();

            set_Text_Enabled(false);
            set_Save_Cancel_Visibility(false);
            this.delete_Button.Visible = false;
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            this.crop_ListBox.Enabled = true;

            return;
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
            if (this.crop_Name_TextBox.Text.Trim().Equals("") ||
                this.species_TextBox.Text.Trim().Equals("") ||
                this.variety_TextBox.Text.Trim().Equals("") ||
                this.brand_TextBox.Text.Trim().Equals("")
                )
            {
                MessageBox.Show("Please enter the required information. (Crop Name, Species, Variety and Brand)");
                return;
            }
            
            API.farmCrop crop = new API.farmCrop();

            if (this.crop_Name_TextBox.Modified)
            {
                crop.cropName = crop_Name_TextBox.Text.ToString().Trim();
            }
            if (this.species_TextBox.Modified)
            {
                crop.species = species_TextBox.Text.ToString().Trim();
            }
            if (this.variety_TextBox.Modified)
            {
                crop.variety = variety_TextBox.Text.ToString().Trim();
            }
            if (this.brand_TextBox.Modified)
            {
                crop.brand = brand_TextBox.Text.ToString().Trim();
            }
            if (this.notes_RichTextBox.Modified)
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
            this.delete_Button.Visible = false;

            this.crop_ListBox.Enabled = true;

            populate_Crop_List();

            this.crop_ListBox.SelectedIndex = 0;

            populate_Crop_Info();

            return;
        }
        private void update_Button_Click(object sender, EventArgs e)
        {
            updateCropCheck = true;
            newCropCheck = false;

            set_Text_Enabled(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);
            this.delete_Button.Visible = true;

            this.crop_ListBox.Enabled = false;

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

            this.crop_ListBox.Enabled = false;

            this.crop_ID_Label.Text = "X";

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
            this.delete_Button.Visible = false;

            this.crop_ListBox.Enabled = true;

            if (this.crop_ListBox.Items.Count != 0)
            {
                populate_Crop_Info();
            }
            else
            {
                this.crop_ID_Label.Text = "Crop ID";
            }

            return;
        }
        private void crop_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Crop_Info();
        }

        private void Crop_UserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
