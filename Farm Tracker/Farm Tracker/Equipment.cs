using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Farm_Tracker
{
    public partial class Equipment : Form
    {

        bool updateEquipmentCheck = false;
        bool newEquipmentCheck = false;

        public Equipment()
        {
            InitializeComponent();

            populate_Equipment_List();
            if (this.equipment_ListBox.Items.Count != 0)
            {
                this.equipment_ListBox.SelectedIndex = 0;
                populate_Repairs_List();
            }
        }
        private void clear_Text_Fields()
        {
            this.equipment_Type_TextBox.Clear();
            this.year_TextBox.Clear();
            this.brand_TextBox.Clear();
            this.serial_Number_Textbox.Clear();
            this.model_Number_TextBox.Clear();
            this.hours_TextBox.Clear();
            this.horsepower_TextBox.Clear();
            this.number_Of_Tanks_TextBox.Clear();
            this.tank_Size_TextBox.Clear();
            this.width_TextBox.Clear();
            this.shank_Spacing_TextBox.Clear();

            return;
        }
        private void set_Main_Button_Visibility(bool value)
        {
            this.update_Equipment_Button.Visible = value;
            this.new_Equipment_Button.Visible = value;

            return;
        }
        private void set_Text_Visibility(bool value)
        {
            this.equipment_Type_TextBox.Visible = value;
            this.year_TextBox.Visible = value;
            this.brand_TextBox.Visible = value;
            this.serial_Number_Textbox.Visible = value;
            this.model_Number_TextBox.Visible = value;
            this.hours_TextBox.Visible = value;
            this.horsepower_TextBox.Visible = value;
            this.number_Of_Tanks_TextBox.Visible = value;
            this.tank_Size_TextBox.Visible = value;
            this.width_TextBox.Visible = value;
            this.shank_Spacing_TextBox.Visible = value;

            return;
        }
        private void set_Save_Cancel_Visibility(bool value)
        {
            this.save_Button.Visible = value;
            this.cancel_Button.Visible = value;
            this.add_Image_Button.Visible = value;

            return;
        }
        private void set_Label_Visibility(bool value)
        {
            this.equipment_Type_Label.Visible = value;
            this.year_Label.Visible = value;
            this.brand_Label.Visible = value;
            this.serial_Number_Label.Visible = value;
            this.model_Number_Label.Visible = value;
            this.hours_Label.Visible = value;
            this.horsepower_Label.Visible = value;
            this.number_Of_Tanks_Label.Visible = value;
            this.tank_Size_Label.Visible = value;
            this.width_Label.Visible = value;
            this.shank_Spacing_Label.Visible = value;

            return;
        }
        private void populate_Equipment_List()
        {
            this.equipment_ListBox.Items.Clear();

            var objects = JArray.Parse(API.retrieveAllEquipment());
            foreach (JObject root in objects)
            {
                StringBuilder equipmentString = new StringBuilder();

                equipmentString.Append(root.GetValue("Equipment_ID"));
                equipmentString.Append("\t");
                equipmentString.Append(root.GetValue("Equipment_Type"));
                equipmentString.Append(" ");
                equipmentString.Append(root.GetValue("Brand"));

                this.equipment_ListBox.Items.Add(equipmentString);
            }
        }
        private void populate_Repairs_List()
        {
            this.repairs_ListBox.Items.Clear();

            var objects = JArray.Parse(API.retrieveOneEquipmentBreakdowns(this.equipment_ID_Label.Text.ToString().Trim()));
            foreach (JObject root in objects)
            {
                if ((bool)root.GetValue("Repaired"))
                {
                    this.repairs_ListBox.Items.Add(Convert.ToDateTime(root.GetValue("Date").ToString().Trim()).ToShortDateString() + "\tFixed");
                }
                else
                {
                    this.repairs_ListBox.Items.Add(Convert.ToDateTime(root.GetValue("Date").ToString().Trim()).ToShortDateString() + "\tBroken");
                }
            }
        }
        private void populate_Equipment_Info()
        {
            if (this.equipment_ListBox.Items.Count == 0)
            {
                return;
            }

            string operatorID = "";
            string temp = this.equipment_ListBox.SelectedItem.ToString().Trim();

            for (int i = 0; temp[i] != '\t'; i++)
            {
                operatorID += temp[i];
            }

            var objects = JArray.Parse(API.retrieveEquipment(operatorID));
            foreach (JObject root in objects)
            {
                StringBuilder equipmentString = new StringBuilder();

                this.equipment_ID_Label.Text = root.GetValue("Equipment_ID").ToString().Trim();
                this.equipment_Type_Label.Text = root.GetValue("Equipment_Type").ToString().Trim();
                this.year_Label.Text = root.GetValue("Year").ToString().Trim();
                this.brand_Label.Text = root.GetValue("Brand").ToString().Trim();
                this.serial_Number_Label.Text = root.GetValue("Serial_Number").ToString().Trim();
                this.model_Number_Label.Text = root.GetValue("Model_Number").ToString().Trim();
                this.hours_Label.Text = root.GetValue("Hours").ToString().Trim();
                this.horsepower_Label.Text = root.GetValue("Horsepower").ToString().Trim();
                this.number_Of_Tanks_Label.Text = root.GetValue("Number_Of_Tanks").ToString().Trim();
                this.tank_Size_Label.Text = root.GetValue("Tank_Size").ToString().Trim();
                this.width_Label.Text = root.GetValue("Width").ToString().Trim();
                this.shank_Spacing_Label.Text = root.GetValue("Shank_Spacing").ToString().Trim();

                //byte[] arr = (byte[])root.GetValue("Image");

                //this.equipment_PictureBox.Image = Utility_Functions.GetDataToImage(arr);

            }
        }
        private void equipment_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Equipment_Info();
            populate_Repairs_List();
        }
        private void update_Button_Click(object sender, EventArgs e)
        {
            updateEquipmentCheck = true;

            set_Label_Visibility(false);
            set_Text_Visibility(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);
            this.delete_Button.Visible = true;

            this.equipment_Type_TextBox.Text = this.equipment_Type_Label.Text;
            this.year_TextBox.Text = this.year_Label.Text;
            this.brand_TextBox.Text = this.brand_Label.Text;
            this.serial_Number_Textbox.Text = this.serial_Number_Label.Text;
            this.model_Number_TextBox.Text = this.model_Number_Label.Text;
            this.hours_TextBox.Text = this.hours_Label.Text;
            this.horsepower_TextBox.Text = this.horsepower_Label.Text;
            this.number_Of_Tanks_TextBox.Text = this.number_Of_Tanks_Label.Text;
            this.tank_Size_TextBox.Text = this.tank_Size_Label.Text;
            this.width_TextBox.Text = this.width_Label.Text;
            this.shank_Spacing_TextBox.Text = this.shank_Spacing_Label.Text;

            this.equipment_ListBox.Enabled = false;

            return;
        }
        private void new_Equipment_Button_Click(object sender, EventArgs e)
        {
            newEquipmentCheck = true;

            clear_Text_Fields();
            set_Label_Visibility(false);
            set_Text_Visibility(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);

            this.equipment_ListBox.Enabled = false;

            this.equipment_ID_Label.Text = "X";

            return;
        }
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            newEquipmentCheck = false;
            updateEquipmentCheck = false;

            clear_Text_Fields();
            set_Label_Visibility(true);
            set_Text_Visibility(false);
            set_Save_Cancel_Visibility(false);
            set_Main_Button_Visibility(true);
            this.delete_Button.Visible = false;

            this.equipment_ListBox.Enabled = true;

            if (this.equipment_ListBox.Items.Count != 0)
            {
                populate_Equipment_Info();
                populate_Repairs_List();
            }
            else
            {
                this.equipment_ID_Label.Text = "Operator ID";
            }

            return;
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
                if (this.equipment_Type_TextBox.Text.Trim().Equals("") ||
                    this.year_TextBox.Text.Trim().Equals("") ||
                    this.brand_TextBox.Text.Trim().Equals("") ||
                    this.serial_Number_Textbox.Text.Trim().Equals("") ||
                    this.model_Number_TextBox.Text.Trim().Equals("") ||
                    this.hours_TextBox.Text.Trim().Equals("")
                    )
                {
                    MessageBox.Show("Please enter the required information. (Equipment Type, Year, Brand, Serial Number, Model Number, Hours)");
                    return;
                }

                API.farmEquipment equip = new API.farmEquipment();

                if (this.equipment_Type_TextBox.Modified)
                {
                    equip.equipmentType = this.equipment_Type_TextBox.Text.ToString().Trim();
                }
                if (this.year_TextBox.Modified)
                {
                    equip.year = Convert.ToInt16(this.year_TextBox.Text);
                }
                if (this.brand_TextBox.Modified)
                {
                    equip.brand = this.brand_TextBox.Text.ToString().Trim();
                }
                if (this.serial_Number_Textbox.Modified)
                {
                    equip.serialNumber = this.serial_Number_Textbox.Text.ToString().Trim();
                }
                if (this.model_Number_TextBox.Modified)
                {
                    equip.modelNumber = this.model_Number_TextBox.Text.ToString().Trim();
                }
                if (this.hours_TextBox.Modified)
                {
                    equip.hours = Convert.ToInt16(this.hours_TextBox.Text.ToString().Trim());
                }
                if (this.horsepower_TextBox.Modified)
                {
                    equip.horsepower = Convert.ToInt16(this.horsepower_TextBox.Text.ToString().Trim());
                }
                if (this.number_Of_Tanks_TextBox.Modified)
                {
                    equip.numberOfTanks = Convert.ToInt16(this.number_Of_Tanks_TextBox.Text.ToString().Trim());
                }
                if (this.tank_Size_TextBox.Modified)
                {
                    equip.tankSize = Convert.ToInt16(this.tank_Size_TextBox.Text.ToString().Trim());
                }
                if (this.width_TextBox.Modified)
                {
                    equip.width = Convert.ToInt16(this.width_TextBox.Text.ToString().Trim());
                }
                if (this.shank_Spacing_TextBox.Modified)
                {
                    equip.shank_Spacing = Convert.ToInt16(this.shank_Spacing_TextBox.Text.ToString().Trim());
                }
                //Image update
                //updateEquipment.image = Utility_Functions.ImageToByteArray(this.equipment_PictureBox.Image, this.equipment_PictureBox);

            if (updateEquipmentCheck)
            {
                equip.ID = Convert.ToInt16(this.equipment_ID_Label.Text.ToString().Trim());
                API.updateEquipment(equip);
            }
            else if (newEquipmentCheck)
            {
                API.createEquipment(equip);
            }

                set_Text_Visibility(false);
                set_Label_Visibility(true);

                set_Save_Cancel_Visibility(false);
                clear_Text_Fields();
                set_Main_Button_Visibility(true);
                delete_Button.Visible = false;

                this.equipment_ListBox.Enabled = true;

                populate_Equipment_List();

                if (this.equipment_ListBox.Items.Count != 0)
                {
                    this.equipment_ListBox.SelectedIndex = 0;
                }

                populate_Equipment_Info();
                populate_Repairs_List();
                
            updateEquipmentCheck = false;
            newEquipmentCheck = false;

                return;
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            API.deleteEquipment(Convert.ToInt16(this.equipment_ID_Label.Text.ToString()));

            populate_Equipment_List();

            set_Text_Visibility(false);
            set_Label_Visibility(true);
            set_Save_Cancel_Visibility(false);
            this.delete_Button.Visible = false;
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            this.equipment_ListBox.Enabled = true;

            newEquipmentCheck = false;
            updateEquipmentCheck = false;

            return;
        }
        private void add_Image_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogBox = new OpenFileDialog();

            dialogBox.Title = "Choose Image";
            dialogBox.Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG";

            if (dialogBox.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(dialogBox.FileName);

                

                equipment_PictureBox.Image = Utility_Functions.ResizeImage(img,286,244) ;
            }
        }
    }
}
