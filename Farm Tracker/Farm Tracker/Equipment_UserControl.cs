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
    public partial class Equipment_UserControl : UserControl
    {
        bool updateEquipmentCheck = false;
        bool newEquipmentCheck = false;

        public Equipment_UserControl()
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
            equipment_Type_TextBox.Clear();
            year_TextBox.Clear();
            brand_TextBox.Clear();
            serial_Number_Textbox.Clear();
            model_Number_TextBox.Clear();
            hours_TextBox.Clear();
            horsepower_TextBox.Clear();
            number_Of_Tanks_TextBox.Clear();
            tank_Size_TextBox.Clear();
            width_TextBox.Clear();
            shank_Spacing_TextBox.Clear();
            equipment_ID_Label.Text = "X";
            

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
            equipment_Type_TextBox.Enabled = value;
            year_TextBox.Enabled = value;
            brand_TextBox.Enabled = value;
            serial_Number_Textbox.Enabled = value;
            model_Number_TextBox.Enabled = value;
            hours_TextBox.Enabled = value;
            horsepower_TextBox.Enabled = value;
            number_Of_Tanks_TextBox.Enabled = value;
            tank_Size_TextBox.Enabled = value;
            width_TextBox.Enabled = value;
            shank_Spacing_TextBox.Enabled = value;

            return;
        }
        private void set_Save_Cancel_Visibility(bool value)
        {
            save_Button.Visible = value;
            cancel_Button.Visible = value;
            add_Image_Button.Visible = value;

            return;
        }
        private void populate_Equipment_List()
        {
            equipment_ListBox.Items.Clear();

            var objects = JArray.Parse(API.retrieveAllEquipment());
            foreach (JObject root in objects)
            {
                StringBuilder equipmentString = new StringBuilder();

                equipmentString.Append(root.GetValue("Equipment_ID").ToString().Trim());
                equipmentString.Append(" - ");
                equipmentString.Append(root.GetValue("Model_Number").ToString().Trim());
                equipmentString.Append(" - ");
                equipmentString.Append(root.GetValue("Brand").ToString().Trim());

                equipment_ListBox.Items.Add(equipmentString);
            }
            if (equipment_ListBox.Items.Count != 0)
            {
                equipment_ListBox.SelectedIndex = 0;
            }
        }
        private void populate_Repairs_List()
        {
            if (equipment_ListBox.SelectedIndex == -1)
            {
                repairs_ListBox.Items.Clear();
                return;
            }

            repairs_ListBox.Items.Clear();

            var objects = JArray.Parse(API.retrieveOneEquipmentBreakdowns(equipment_ID_Label.Text.ToString().Trim()));
            foreach (JObject root in objects)
            {
                if ((bool)root.GetValue("Repaired"))
                {
                    repairs_ListBox.Items.Add(Convert.ToDateTime(root.GetValue("Date").ToString().Trim()).ToShortDateString() + " - Fixed");
                }
                else
                {
                    repairs_ListBox.Items.Add(Convert.ToDateTime(root.GetValue("Date").ToString().Trim()).ToShortDateString() + " - Not Fixed");
                }
            }
        }
        private void populate_Equipment_Info()
        {
            if (equipment_ListBox.SelectedIndex == -1)
            {
                clear_Text_Fields();
                return;
            }

            string operatorID = "";
            string temp = equipment_ListBox.SelectedItem.ToString().Trim();

            operatorID += temp.Split('-')[0].Trim();

            var objects = JArray.Parse(API.retrieveOneEquipment(operatorID));
            foreach (JObject root in objects)
            {
                StringBuilder equipmentString = new StringBuilder();

                equipment_ID_Label.Text = root.GetValue("Equipment_ID").ToString().Trim();
                equipment_Type_TextBox.Text = root.GetValue("Equipment_Type").ToString().Trim();
                year_TextBox.Text = root.GetValue("Year").ToString().Trim();
                brand_TextBox.Text = root.GetValue("Brand").ToString().Trim();
                serial_Number_Textbox.Text = root.GetValue("Serial_Number").ToString().Trim();
                model_Number_TextBox.Text = root.GetValue("Model_Number").ToString().Trim();
                hours_TextBox.Text = root.GetValue("Hours").ToString().Trim();
                horsepower_TextBox.Text = root.GetValue("Horsepower").ToString().Trim();
                number_Of_Tanks_TextBox.Text = root.GetValue("Number_Of_Tanks").ToString().Trim();
                tank_Size_TextBox.Text = root.GetValue("Tank_Size").ToString().Trim();
                width_TextBox.Text = root.GetValue("Width").ToString().Trim();
                shank_Spacing_TextBox.Text = root.GetValue("Shank_Spacing").ToString().Trim();

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
            if (equipment_ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a piece of equipment to update.");
                return;
            }

            updateEquipmentCheck = true;
            newEquipmentCheck = false;

            set_Text_Enabled(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);
            delete_Button.Visible = true;

            equipment_ListBox.Enabled = false;

            return;
        }
        private void new_Button_Click(object sender, EventArgs e)
        {
            newEquipmentCheck = true;

            clear_Text_Fields();
            set_Text_Enabled(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);

            equipment_ListBox.Enabled = false;

            equipment_ID_Label.Text = "X";

            return;
        }
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            newEquipmentCheck = false;
            updateEquipmentCheck = false;

            clear_Text_Fields();
            set_Text_Enabled(false);
            set_Save_Cancel_Visibility(false);
            set_Main_Button_Visibility(true);
            delete_Button.Visible = false;

            equipment_ListBox.Enabled = true;

            if (equipment_ListBox.Items.Count != 0)
            {
                populate_Equipment_Info();
                populate_Repairs_List();
            }
            else
            {
                equipment_ID_Label.Text = "Operator ID";
            }

            return;
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
            if (equipment_Type_TextBox.Text.Trim().Equals("") ||
                year_TextBox.Text.Trim().Equals("") ||
                brand_TextBox.Text.Trim().Equals("") ||
                serial_Number_Textbox.Text.Trim().Equals("") ||
                model_Number_TextBox.Text.Trim().Equals("") ||
                hours_TextBox.Text.Trim().Equals("")
                )
            {
                MessageBox.Show("Please enter the required information. (Equipment Type, Year, Brand, Serial Number, Model Number, Hours)");
                return;
            }

            API.farmEquipment equip = new API.farmEquipment();

            if (equipment_Type_TextBox.Modified)
            {
                equip.equipmentType = equipment_Type_TextBox.Text.ToString().Trim();
            }
            if (year_TextBox.Modified)
            {
                equip.year = Convert.ToInt16(year_TextBox.Text);
            }
            if (brand_TextBox.Modified)
            {
                equip.brand = brand_TextBox.Text.ToString().Trim();
            }
            if (serial_Number_Textbox.Modified)
            {
                equip.serialNumber = serial_Number_Textbox.Text.ToString().Trim();
            }
            if (model_Number_TextBox.Modified)
            {
                equip.modelNumber = model_Number_TextBox.Text.ToString().Trim();
            }
            if (hours_TextBox.Modified)
            {
                equip.hours = Convert.ToInt16(hours_TextBox.Text.ToString().Trim());
            }
            if (horsepower_TextBox.Modified)
            {
                equip.horsepower = Convert.ToInt16(horsepower_TextBox.Text.ToString().Trim());
            }
            if (number_Of_Tanks_TextBox.Modified)
            {
                equip.numberOfTanks = Convert.ToInt16(number_Of_Tanks_TextBox.Text.ToString().Trim());
            }
            if (tank_Size_TextBox.Modified)
            {
                equip.tankSize = Convert.ToInt16(tank_Size_TextBox.Text.ToString().Trim());
            }
            if (width_TextBox.Modified)
            {
                equip.width = Convert.ToInt16(width_TextBox.Text.ToString().Trim());
            }
            if (shank_Spacing_TextBox.Modified)
            {
                equip.shank_Spacing = Convert.ToInt16(shank_Spacing_TextBox.Text.ToString().Trim());
            }
            //Image update
            //updateEquipment.image = Utility_Functions.ImageToByteArray(this.equipment_PictureBox.Image, this.equipment_PictureBox);

            if (updateEquipmentCheck)
            {
                equip.ID = Convert.ToInt16(equipment_ID_Label.Text.ToString().Trim());
                API.updateEquipment(equip);
            }
            else if (newEquipmentCheck)
            {
                equip.operational = true;
                API.createEquipment(equip);
            }

            set_Text_Enabled(false);

            set_Save_Cancel_Visibility(false);
            clear_Text_Fields();
            set_Main_Button_Visibility(true);
            delete_Button.Visible = false;

            equipment_ListBox.Enabled = true;
            
            populate_Equipment_List();

            if (equipment_ListBox.Items.Count != 0)
            {
                equipment_ListBox.SelectedIndex = 0;
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

            set_Text_Enabled(false);
            set_Save_Cancel_Visibility(false);
            delete_Button.Visible = false;
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            equipment_ListBox.Enabled = true;

            newEquipmentCheck = false;
            updateEquipmentCheck = false;

            return;
        }
        private void add_Image_Button_Click(object sender, EventArgs e)
        {
            //WILL ADD THIS FUNCTIONALITY AT A LATER DATE

            //OpenFileDialog dialogBox = new OpenFileDialog();

            //dialogBox.Title = "Choose Image";
            //dialogBox.Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG";

            //if (dialogBox.ShowDialog() == DialogResult.OK)
            //{
            //    Image img = new Bitmap(dialogBox.FileName);

                

            //    equipment_PictureBox.Image = Utility_Functions.ResizeImage(img,286,244) ;
            //}
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_Button_Click(sender, e);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_Button_Click(sender, e);
        }
        private void equipment_ListBox_RightClick(object sender, MouseEventArgs e)
        {
            equipment_ListBox.SelectedIndex = equipment_ListBox.IndexFromPoint(e.X, e.Y);
        }
        private void equipment_ListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (equipment_ListBox.SelectedIndex == -1)
            {
                equipment_ContextMenuStrip.Close();
            }
        }
    }
}
