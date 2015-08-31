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
    public partial class Farming_Event_UserControl : UserControl
    {

        bool newEventCheck = false;
        bool updateEventCheck = false;

        public Farming_Event_UserControl()
        {
            InitializeComponent();
            
            fill_Field_ID_ComboBox();
            fill_Media_ComboBoxes();
            fill_Operator_ID_ComboBox();
            fill_Tractor_ID_ComboBox();
            fill_Trailer_ID_ComboBox();
            
            populate_Event_Lists();
            
        }

        private void clear_Text_Fields()
        {
            event_ID_Label.Text = "X";
            event_DateTimePicker.Value = DateTime.Today;
            field_ID_ComboBox.SelectedIndex = 0;
            operator_ID_ComboBox.SelectedIndex = 0;
            planned_RadioButton.Checked = false;
            tractor_ID_ComboBox.SelectedIndex = 0;
            trailer_ID_ComboBox.SelectedIndex = 0;
            acres_Worked_TextBox.Clear();
            p_Media_ID_ComboBox.SelectedIndex = 0;
            p_Media_Quantity_TextBox.Clear();
            p_Media_Rate_TextBox.Clear();
            s_Media_ID_ComboBox.SelectedIndex = 0;
            s_Media_Quantity_TextBox.Clear();
            s_Media_Rate_TextBox.Clear();
            t_Media_ID_ComboBox.SelectedIndex = 0;
            t_Media_Quantity_TextBox.Clear();
            t_Media_Rate_TextBox.Clear();
            yield_Units_ComboBox.SelectedIndex = 0;
            yield_TextBox.Clear();
            notes_RichTextBox.Clear();

            return;
        }
        private void set_List_Buttons_Enabled(bool value)
        {
            current_Button.Enabled = value;
            all_Button.Enabled = value;
        }
        private void set_Activities_RadioButton_Enabled(bool value)
        {
            seeding_RadioButton.Enabled = value;
            spraying_RadioButton.Enabled = value;
            harvesting_RadioButton.Enabled = value;
            disking_RadioButton.Enabled = value;
            crop_Checking_RadioButton.Enabled = value;

            return;
        }
        private void set_Required_Info_Enabled(bool value)
        {
            event_DateTimePicker.Enabled = value;
            field_ID_ComboBox.Enabled = value;
            operator_ID_ComboBox.Enabled = value;
            planned_RadioButton.Enabled = value;
            actual_RadioButton.Enabled = value;

            return;
        }
        private void set_Equipment_Acres_TextBox_Enabled(bool value)
        {
            tractor_ID_ComboBox.Enabled = value;
            trailer_ID_ComboBox.Enabled = value;
            acres_Worked_TextBox.Enabled = value;

            return;
        }
        private void set_Media_TextBox_Enabled(bool value)
        {
            p_Media_ID_ComboBox.Enabled = value;
            p_Media_Quantity_TextBox.Enabled = value;
            p_Media_Rate_TextBox.Enabled = value;
            s_Media_ID_ComboBox.Enabled = value;
            s_Media_Quantity_TextBox.Enabled = value;
            s_Media_Rate_TextBox.Enabled = value;
            t_Media_ID_ComboBox.Enabled = value;
            t_Media_Quantity_TextBox.Enabled = value;
            t_Media_Rate_TextBox.Enabled = value;

            return;
        }
        private void set_Yield_TextBox_Enabled(bool value)
        {
            yield_Units_ComboBox.Enabled = value;
            yield_TextBox.Enabled = value;

            return;
        }
        private void set_Crop_Stage_Enabled(bool value)
        {
            crop_Stage_TextBox.Enabled = value;

            return;
        }
        private void set_Notes_Enabled(bool value)
        {
            notes_RichTextBox.Enabled = value;

            return;
        }
        private void set_ListBox_Enabled(bool value)
        {
            planned_Event_ListBox.Enabled = value;
            actual_Event_ListBox.Enabled = value;

            return;
        }
        private void set_Calendar_Enabled(bool value)
        {
            event_MonthCalendar.Enabled = value;

            return;
        }
        private void set_Main_Button_Visibility(bool value)
        {
            update_Button.Visible = value;
            new_Button.Visible = value;

            return;
        }
        private void set_Save_Cancel_Delete_Button_Visibility(bool value)
        {
            save_Button.Visible = value;
            cancel_Button.Visible = value;
            delete_Button.Visible = value;

            return;
        }
        private void populate_Event_Info()
        {
            if (planned_Event_ListBox.SelectedIndex == -1 && actual_Event_ListBox.SelectedIndex == -1)
            {
                clear_Text_Fields();
                return;
            }

            string eventID = "";
            string[] temp;

            if (planned_Event_ListBox.SelectedIndex > -1)
            {
                temp = planned_Event_ListBox.SelectedItem.ToString().Trim().Split('-');
            }
            else
            {
                temp = actual_Event_ListBox.SelectedItem.ToString().Trim().Split('-');
            }
            
            eventID = temp[1].Trim();

            var objects = JArray.Parse(API.retrieveOneFarmEvent(eventID));
            foreach (JObject root in objects)
            {
                event_ID_Label.Text = root.GetValue("Farming_Event_ID").ToString().Trim();

                event_DateTimePicker.Value = Convert.ToDateTime(root.GetValue("Date").ToString().Trim());

                if (root.GetValue("Activity").ToString().Trim() == "Seeding")
                {
                    seeding_RadioButton.Checked = true;
                }
                else if (root.GetValue("Activity").ToString().Trim() == "Spraying")
                {
                    spraying_RadioButton.Checked = true;
                }
                else if (root.GetValue("Activity").ToString().Trim() == "Harvesting")
                {
                    harvesting_RadioButton.Checked = true;
                }
                else if (root.GetValue("Activity").ToString().Trim() == "Disking")
                {
                    disking_RadioButton.Checked = true;
                }
                else if (root.GetValue("Activity").ToString().Trim() == "Crop Checking")
                {
                    crop_Checking_RadioButton.Checked = true;
                }

                string fieldID = root.GetValue("Field_ID").ToString().Trim();
                string opID = root.GetValue("Operator_ID").ToString().Trim();
                string tractorID = root.GetValue("Tractor_Equipment_ID").ToString().Trim();
                string trailerID = root.GetValue("Trailer_Equipment_ID").ToString().Trim();

                for (int i = 0; i < field_ID_ComboBox.Items.Count; i++)
                {
                    if (field_ID_ComboBox.Items[i].ToString().Trim().Contains(fieldID))
                    {
                        field_ID_ComboBox.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < operator_ID_ComboBox.Items.Count; i++)
                {
                    if (operator_ID_ComboBox.Items[i].ToString().Trim().Contains(opID))
                    {
                        operator_ID_ComboBox.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < tractor_ID_ComboBox.Items.Count; i++)
                {
                    if (tractor_ID_ComboBox.Items[i].ToString().Trim().Contains(tractorID))
                    {
                        tractor_ID_ComboBox.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < trailer_ID_ComboBox.Items.Count; i++)
                {
                    if (trailer_ID_ComboBox.Items[i].ToString().Trim().Contains(trailerID))
                    {
                        trailer_ID_ComboBox.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < p_Media_ID_ComboBox.Items.Count; i++)
                {
                    if (p_Media_ID_ComboBox.Items[i].ToString().Trim().Contains(root.GetValue("Primary_Media_ID").ToString().Trim()))
                    {
                        p_Media_ID_ComboBox.SelectedIndex = i;
                    }
                }

                p_Media_Quantity_TextBox.Text = root.GetValue("Primary_Media_Quantity").ToString().Trim();
                p_Media_Rate_TextBox.Text = root.GetValue("Primary_Media_Rate").ToString().Trim();

                for (int i = 0; i < s_Media_ID_ComboBox.Items.Count; i++)
                {
                    if (s_Media_ID_ComboBox.Items[i].ToString().Trim().Contains(root.GetValue("Secondary_Media_ID").ToString().Trim()))
                    {
                        s_Media_ID_ComboBox.SelectedIndex = i;
                    }
                }

                s_Media_Quantity_TextBox.Text = root.GetValue("Secondary_Media_Quantity").ToString().Trim();
                s_Media_Rate_TextBox.Text = root.GetValue("Secondary_Media_Rate").ToString().Trim();

                for (int i = 0; i < t_Media_ID_ComboBox.Items.Count; i++)
                {
                    if (t_Media_ID_ComboBox.Items[i].ToString().Trim().Contains(root.GetValue("Tertiary_Media_ID").ToString().Trim()))
                    {
                        t_Media_ID_ComboBox.SelectedIndex = i;
                    }
                }

                t_Media_Quantity_TextBox.Text = root.GetValue("Tertiary_Media_Quantity").ToString().Trim();
                t_Media_Rate_TextBox.Text = root.GetValue("Tertiary_Media_Rate").ToString().Trim();

                for (int i = 0; i < yield_Units_ComboBox.Items.Count; i++)
                {
                    if (yield_Units_ComboBox.Items[i].ToString().Trim().Contains(root.GetValue("Yield_Units").ToString().Trim()))
                    {
                        yield_Units_ComboBox.SelectedIndex = i;
                    }
                }

                yield_TextBox.Text = root.GetValue("Yield").ToString().Trim();

                notes_RichTextBox.Text = root.GetValue("Notes").ToString().Trim();

                if (Convert.ToBoolean(root.GetValue("Planned")))
                {
                    planned_RadioButton.Checked = true;
                }
                else
                {
                    actual_RadioButton.Checked = true;
                }

            }
        }
        private void fill_Tractor_ID_ComboBox()
        {
            tractor_ID_ComboBox.Items.Clear();

            tractor_ID_ComboBox.Items.Add("*Select One*");

            var objects = JArray.Parse(API.retrieveAllTractorEquipment());
            foreach (JObject root in objects)
            {
                StringBuilder equipmentString = new StringBuilder();

                equipmentString.Append(root.GetValue("Equipment_ID").ToString().Trim());
                equipmentString.Append(" ");
                equipmentString.Append(root.GetValue("Model_Number").ToString().Trim());

                tractor_ID_ComboBox.Items.Add(equipmentString);
            }
        }
        private void fill_Trailer_ID_ComboBox()
        {
            trailer_ID_ComboBox.Items.Clear();

            trailer_ID_ComboBox.Items.Add("*Select One*");

            var objects = JArray.Parse(API.retrieveAllTrailerEquipment());
            foreach (JObject root in objects)
            {
                StringBuilder equipmentString = new StringBuilder();

                equipmentString.Append(root.GetValue("Equipment_ID").ToString().Trim());
                equipmentString.Append(" ");
                equipmentString.Append(root.GetValue("Model_Number").ToString().Trim());

                trailer_ID_ComboBox.Items.Add(equipmentString);
            }
        }
        private void fill_Operator_ID_ComboBox()
        {
            operator_ID_ComboBox.Items.Clear();

            operator_ID_ComboBox.Items.Add("*Select One*");

            var objects = JArray.Parse(API.retrieveAllOperators());
            foreach (JObject root in objects)
            {
                StringBuilder operatorString = new StringBuilder();

                operatorString.Append(root.GetValue("Operator_ID").ToString().Trim());
                operatorString.Append(" ");
                operatorString.Append(root.GetValue("First_Name").ToString().Trim());
                operatorString.Append(" ");
                operatorString.Append(root.GetValue("Last_Name").ToString().Trim());

                operator_ID_ComboBox.Items.Add(operatorString);
            }
        }
        private void fill_Field_ID_ComboBox()
        {
            field_ID_ComboBox.Items.Clear();

            field_ID_ComboBox.Items.Add("*Select One*");

            var objects = JArray.Parse(API.retrieveAllFields());
            foreach (JObject root in objects)
            {
                StringBuilder operatorString = new StringBuilder();

                operatorString.Append(root.GetValue("Field_ID").ToString().Trim());
                operatorString.Append(" ");
                operatorString.Append(root.GetValue("Field_Name").ToString().Trim());

                field_ID_ComboBox.Items.Add(operatorString);
            }
        }
        private void fill_Media_ComboBoxes()
        {
            p_Media_ID_ComboBox.Items.Clear();
            s_Media_ID_ComboBox.Items.Clear();
            t_Media_ID_ComboBox.Items.Clear();

            p_Media_ID_ComboBox.Items.Add("*Select One*");
            s_Media_ID_ComboBox.Items.Add("*Select One*");
            t_Media_ID_ComboBox.Items.Add("*Select One*");

            var objects = JArray.Parse(API.retrieveAllCrops());
            foreach (JObject root in objects)
            {
                StringBuilder cropString = new StringBuilder();

                cropString.Append(root.GetValue("Crop_ID").ToString().Trim());
                cropString.Append(" ");
                cropString.Append(root.GetValue("Crop_Name").ToString().Trim());

                p_Media_ID_ComboBox.Items.Add(cropString);
                s_Media_ID_ComboBox.Items.Add(cropString);
                t_Media_ID_ComboBox.Items.Add(cropString);
            }
            objects = JArray.Parse(API.retrieveAllChemicals());
            foreach (JObject root in objects)
            {
                StringBuilder chemicalString = new StringBuilder();

                chemicalString.Append(root.GetValue("Chemical_ID").ToString().Trim());
                chemicalString.Append(" ");
                chemicalString.Append(root.GetValue("Chemical_Name").ToString().Trim());

                p_Media_ID_ComboBox.Items.Add(chemicalString);
                s_Media_ID_ComboBox.Items.Add(chemicalString);
                t_Media_ID_ComboBox.Items.Add(chemicalString);
            }
        }
        private void populate_Planned_List(string data)
        {
            planned_Event_ListBox.Items.Clear();

            var objects = JArray.Parse(data);
            foreach (JObject root in objects)
            {
                StringBuilder plannedEventString = new StringBuilder();

                plannedEventString.Append(Convert.ToDateTime(root.GetValue("Date")).ToShortDateString());
                plannedEventString.Append(" - ");
                plannedEventString.Append(root.GetValue("Farming_Event_ID"));
                plannedEventString.Append(" - ");
                plannedEventString.Append(root.GetValue("Field_Name").ToString().Trim());
                plannedEventString.Append(" - ");
                plannedEventString.Append(root.GetValue("Activity").ToString().Trim());

                planned_Event_ListBox.Items.Add(plannedEventString);
            }
            if (planned_Event_ListBox.Items.Count != 0)
            {
                planned_Event_ListBox.SelectedIndex = 0;
            }
        }
        private void populate_Actual_List(string data)
        {
            actual_Event_ListBox.Items.Clear();

            var objects = JArray.Parse(data);
            foreach (JObject root in objects)
            {
                StringBuilder actualEventString = new StringBuilder();

                actualEventString.Append(Convert.ToDateTime(root.GetValue("Date")).ToShortDateString());
                actualEventString.Append(" - ");
                actualEventString.Append(root.GetValue("Farming_Event_ID"));
                actualEventString.Append(" - ");
                actualEventString.Append(root.GetValue("Field_Name").ToString().Trim());
                actualEventString.Append(" - ");
                actualEventString.Append(root.GetValue("Activity").ToString().Trim());

                actual_Event_ListBox.Items.Add(actualEventString);
            }
            if (actual_Event_ListBox.Items.Count != 0)
            {
                actual_Event_ListBox.SelectedIndex = 0;
            }
        }
        private void populate_Event_Lists()
        {
            populate_Planned_List(API.retrievePlannedFarmEventsWithFields());
            populate_Actual_List(API.retrieveActualFarmEventsWithFields());
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void event_MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void seeding_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            equipment_Acres_Panel.Visible = true;
            media_Panel.Visible = true;
            notes_Panel.Visible = true;

            yeild_Panel.Visible = false;
            crop_Stage_Panel.Visible = false;

            return;
        }
        private void spraying_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            equipment_Acres_Panel.Visible = true;
            media_Panel.Visible = true;
            notes_Panel.Visible = true;

            yeild_Panel.Visible = false;
            crop_Stage_Panel.Visible = false;

            return;
        }
        private void harvesting_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            equipment_Acres_Panel.Visible = true;
            yeild_Panel.Visible = true;
            notes_Panel.Visible = true;

            media_Panel.Visible = false;
            crop_Stage_Panel.Visible = false;

            return;
        }
        private void disking_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            equipment_Acres_Panel.Visible = true;
            notes_Panel.Visible = true;

            media_Panel.Visible = false;
            yeild_Panel.Visible = false;
            crop_Stage_Panel.Visible = false;

            return;
        }
        private void crop_Checking_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            crop_Stage_Panel.Visible = true;
            notes_Panel.Visible = true;
                
            equipment_Acres_Panel.Visible = false;
            media_Panel.Visible = false;
            yeild_Panel.Visible = false;

            return;
        }
        private void planned_Event_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Event_Info();
        }
        private void actual_Event_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Event_Info();
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            API.deleteFarmEvent(Convert.ToInt16(event_Label.Text.ToString().Trim()));

            current_Button_Click(sender, e);

            set_Activities_RadioButton_Enabled(false);
            set_Required_Info_Enabled(false);
            set_Equipment_Acres_TextBox_Enabled(false);
            set_Media_TextBox_Enabled(false);
            set_Yield_TextBox_Enabled(false);
            set_Crop_Stage_Enabled(false);
            set_Notes_Enabled(false);

            set_ListBox_Enabled(true);
            set_Calendar_Enabled(true);
            set_List_Buttons_Enabled(true);

            set_Main_Button_Visibility(true);
            set_Save_Cancel_Delete_Button_Visibility(false);

            return;
        }
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            newEventCheck = false;
            updateEventCheck = false;

            set_Activities_RadioButton_Enabled(false);
            set_Required_Info_Enabled(false);
            set_Equipment_Acres_TextBox_Enabled(false);
            set_Media_TextBox_Enabled(false);
            set_Yield_TextBox_Enabled(false);
            set_Crop_Stage_Enabled(false);
            set_Notes_Enabled(false);

            set_ListBox_Enabled(true);
            set_Calendar_Enabled(true);
            set_List_Buttons_Enabled(true);

            set_Main_Button_Visibility(true);
            set_Save_Cancel_Delete_Button_Visibility(false);

            if (planned_Event_ListBox.Items.Count != 0)
            {
                current_Button_Click(sender, e);
            }

            return;
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
            if (field_ID_ComboBox.Text.Equals("*Select One*") ||
                operator_ID_ComboBox.Text.Trim().Equals("*Select One*") ||
                (planned_RadioButton.Checked == false && actual_RadioButton.Checked == false) ||
                (seeding_RadioButton.Checked == false && spraying_RadioButton.Checked == false && harvesting_RadioButton.Checked == false && disking_RadioButton.Checked == false && crop_Checking_RadioButton.Checked == false)
                )
            {
                MessageBox.Show("Please enter the required information. (Date, field name, operator name, activity and planned/actual)");
                return;
            }

            API.farmEvent farmEvent = new API.farmEvent();

            string[] fieldSplit = field_ID_ComboBox.Text.ToString().Trim().Split(' ');
            farmEvent.fieldID = Convert.ToInt16(fieldSplit[0]);
            string[] operatorSplit = operator_ID_ComboBox.Text.ToString().Trim().Split(' ');
            farmEvent.operatorID = Convert.ToInt16(operatorSplit[0]);
            if (tractor_ID_ComboBox.SelectedIndex != 0)
            {
            string[] tractorSplit = tractor_ID_ComboBox.Text.ToString().Trim().Split(' ');
            farmEvent.tractorID = Convert.ToInt16(tractorSplit[0]);
            }
            
            if (trailer_ID_ComboBox.SelectedIndex != 0)
            {
            string[] trailerSplit = trailer_ID_ComboBox.Text.ToString().Trim().Split(' ');
            farmEvent.trailerID = Convert.ToInt16(trailerSplit[0]);
            }

            if (acres_Worked_TextBox.Modified)
            {
                farmEvent.acresWorked = Convert.ToInt16(acres_Worked_TextBox.Text.ToString().Trim());
            }

            if (p_Media_ID_ComboBox.SelectedIndex != 0)
            {
            string[] pIDSplit = p_Media_ID_ComboBox.Text.ToString().Trim().Split(' ');
            farmEvent.primaryMediaID = Convert.ToInt16(pIDSplit[0]);
            }

            farmEvent.primaryMediaQuantity = Convert.ToInt16(p_Media_Quantity_TextBox.Text.ToString().Trim());
            farmEvent.primaryMediaRate = Convert.ToInt16(p_Media_Rate_TextBox.Text.ToString().Trim());

            if (s_Media_ID_ComboBox.SelectedIndex != 0)
            {
            string[] sIDSplit = s_Media_ID_ComboBox.Text.ToString().Trim().Split(' ');
            farmEvent.secondaryMediaID = Convert.ToInt16(sIDSplit[0]);
            }

            farmEvent.secondaryMediaQuantity = Convert.ToInt16(s_Media_Quantity_TextBox.Text.ToString().Trim());
            farmEvent.secondaryMediaRate = Convert.ToInt16(s_Media_Rate_TextBox.Text.ToString().Trim());

            if (t_Media_ID_ComboBox.SelectedIndex != 0)
            {
            string[] tIDSplit = t_Media_ID_ComboBox.Text.ToString().Trim().Split(' ');
            farmEvent.tertiaryMediaID = Convert.ToInt16(tIDSplit[0]);
            }

            farmEvent.tertiaryMediaQuantity = Convert.ToInt16(t_Media_Quantity_TextBox.Text.ToString().Trim());
            farmEvent.tertiaryMediaRate = Convert.ToInt16(t_Media_Rate_TextBox.Text.ToString().Trim());

            farmEvent.Date = event_DateTimePicker.Value;

            farmEvent.yeildUnits = yield_Units_ComboBox.Text.ToString().Trim();
            farmEvent.yeild = Convert.ToInt16(yield_TextBox.Text.ToString().Trim());

            if (newEventCheck)
            {
                API.createFarmEvent(farmEvent);
            }
            else if (updateEventCheck)
            {
                farmEvent.ID = Convert.ToInt16(event_Label.Text.ToString().Trim());
                API.updateFarmEvent(farmEvent);
            }

            newEventCheck = false;
            updateEventCheck = false;

            set_Activities_RadioButton_Enabled(false);
            set_Required_Info_Enabled(false);
            set_Equipment_Acres_TextBox_Enabled(false);
            set_Media_TextBox_Enabled(false);
            set_Yield_TextBox_Enabled(false);
            set_Crop_Stage_Enabled(false);
            set_Notes_Enabled(false);

            set_ListBox_Enabled(true);
            set_Calendar_Enabled(true);
            set_List_Buttons_Enabled(true);

            set_Main_Button_Visibility(true);
            set_Save_Cancel_Delete_Button_Visibility(false);

            current_Button_Click(sender, e);

            if (planned_Event_ListBox.SelectedIndex != -1 || actual_Event_ListBox.SelectedIndex != -1)
            {
            planned_Event_ListBox.SelectedIndex = 0;
            }

            populate_Event_Info();

            return;
        }
        private void update_Button_Click(object sender, EventArgs e)
        {
            if (planned_Event_ListBox.SelectedIndex == -1 && actual_Event_ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an event to update.");
                return;
            }

            updateEventCheck = true;
            newEventCheck = false;

            set_Activities_RadioButton_Enabled(true);
            set_Required_Info_Enabled(true);
            set_Equipment_Acres_TextBox_Enabled(true);
            set_Media_TextBox_Enabled(true);
            set_Yield_TextBox_Enabled(true);
            set_Crop_Stage_Enabled(true);
            set_Notes_Enabled(true);

            set_ListBox_Enabled(false);
            set_Calendar_Enabled(false);
            set_List_Buttons_Enabled(false);

            set_Main_Button_Visibility(false);
            set_Save_Cancel_Delete_Button_Visibility(true);

            return;
        }
        private void new_Button_Click(object sender, EventArgs e)
        {
            newEventCheck = true;
            updateEventCheck = false;

            clear_Text_Fields();
            event_DateTimePicker.Value = DateTime.Today;

            set_Activities_RadioButton_Enabled(true);
            set_Required_Info_Enabled(true);
            set_Equipment_Acres_TextBox_Enabled(true);
            set_Media_TextBox_Enabled(true);
            set_Yield_TextBox_Enabled(true);
            set_Crop_Stage_Enabled(true);
            set_Notes_Enabled(true);

            set_ListBox_Enabled(false);
            set_Calendar_Enabled(false);
            set_List_Buttons_Enabled(false);

            set_Main_Button_Visibility(false);
            set_Save_Cancel_Delete_Button_Visibility(true);

            return;
        }
        private void current_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
