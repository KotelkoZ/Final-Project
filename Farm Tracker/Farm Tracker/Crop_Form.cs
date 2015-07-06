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
    public partial class Crop_Form : Form
    {
        public Crop_Form()
        {
            InitializeComponent();

            populate_Crop_List();

            if (this.crop_ListBox.Items.Count != 0)
            {
                this.crop_ListBox.SelectedIndex = 0;
            }
            
        }
        private void update_Crop_Button_Click(object sender, EventArgs e)
        {
            set_Label_Visibility(false);
            set_Text_Visibility(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);
            this.delete_Button.Visible = true;

            this.crop_Name_TextBox.Text = this.crop_Name_Label.Text;
            this.species_TextBox.Text = this.species_Label.Text;
            this.variety_TextBox.Text = this.variety_Label.Text;
            this.brand_TextBox.Text = this.brand_Label.Text;
            this.notes_RichTextBox.Enabled = true;

            this.crop_ListBox.Enabled = false;

            return;
        }

        private void new_Crop_Button_Click(object sender, EventArgs e)
        {
            set_Label_Visibility(false);
            set_Text_Visibility(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);
            clear_Text_Fields();

            this.crop_ListBox.Enabled = false;

            this.crop_ID_Label.Text = "X";

            return;
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            clear_Text_Fields();
            set_Label_Visibility(true);
            set_Text_Visibility(false);
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

        private void set_Main_Button_Visibility(bool value)
        {
            this.update_Crop_Button.Visible = value;
            this.new_Crop_Button.Visible = value;

            return;
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

        private void set_Text_Visibility(bool value)
        {
            this.crop_Name_TextBox.Visible = value;
            this.species_TextBox.Visible = value;
            this.variety_TextBox.Visible = value;
            this.brand_TextBox.Visible = value;
            this.notes_RichTextBox.Enabled = value;

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
            this.crop_Name_Label.Visible = value;
            this.species_Label.Visible = value;
            this.variety_Label.Visible = value;
            this.brand_Label.Visible = value;

            return;
        }
        private void crop_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Crop_Info();
        }

        private void populate_Crop_List()
        {
            this.crop_ListBox.Items.Clear();

            String queryString = "select Crops.Crop_ID, Crops.Crop_Name, Crops.Species from Crops ";


            using (SqlConnection connection = new SqlConnection(Variables.CONNECTIONSTRING))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.crop_ListBox.Items.Add(reader[0].ToString().Trim() + "\t" +
                                                            reader[1].ToString().Trim() + "\t" +
                                                            reader[2].ToString().Trim());
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }
        }

        private void populate_Crop_Info()
        {

            string operatorID = "";
            string temp = this.crop_ListBox.SelectedItem.ToString().Trim();

            for (int i = 0; temp[i] != '\t'; i++)
            {
                operatorID += temp[i];
            }

            String queryString = "select * from Crops where Crops.Crop_ID = " + operatorID;

            using (SqlConnection connection = new SqlConnection(Variables.CONNECTIONSTRING))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        this.crop_ID_Label.Text = reader[0].ToString().Trim();
                        this.crop_Name_Label.Text = reader[1].ToString().Trim();
                        this.species_Label.Text = reader[2].ToString().Trim();
                        this.variety_Label.Text = reader[3].ToString().Trim();
                        this.brand_Label.Text = reader[4].ToString().Trim();
                        this.notes_RichTextBox.Text = reader[5].ToString().Trim();

                        reader.Close();
                    }
                }
                connection.Close();
            }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            string queryString = "delete from Crops where Crops.Crop_ID = '" + this.crop_ID_Label.Text.ToString().Trim() + "'";

            string queryMessage = "Delete crop";
            string querySuccess = "Crop has been deleted.";
            string queryFail = "There was a problem, the crop was not deleted.";

            myFunctions.queryExecute(queryString, queryMessage, querySuccess, queryFail);

            populate_Crop_List();

            set_Text_Visibility(false);
            set_Label_Visibility(true);
            set_Save_Cancel_Visibility(false);
            this.delete_Button.Visible = false;
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            this.crop_ListBox.Enabled = true;

            return;
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            //NEW CROP
            if (this.crop_ID_Label.Text.ToString().Trim() == "X")
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

                string queryString = "insert into Crops (Crops.crop_Name, Crops.Species, Crops.Variety, Crops.Brand, ";

                if (this.notes_RichTextBox.Text.ToString().Trim() != "")
                {
                    queryString += "Crops.Notes) ";
                }

                   queryString += "values ('" + this.crop_Name_TextBox.Text.ToString().Trim() + "', '" +
                                    this.species_TextBox.Text.ToString().Trim() + "', '" +
                                    this.variety_TextBox.Text.ToString().Trim() + "', '" +
                                    this.brand_TextBox.Text.ToString().Trim() + "'";

                if (this.notes_RichTextBox.Text.ToString().Trim() != "")
                {
                    queryString += ", '" + this.notes_RichTextBox.Text.ToString().Trim() + "'";
                }

                queryString += ")";

                MessageBox.Show(queryString);

                string queryMessage = "Insert crop";
                string querySuccess = "Crop has been created.";
                string queryFail = "There was a problem, the crop was not created.";

                myFunctions.queryExecute(queryString, queryMessage, querySuccess, queryFail);

            }
            //UPDATE CROP
            else
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

                string queryString = "update Crops set Crops.Crop_Name = '" + this.crop_Name_TextBox.Text.ToString().Trim() +
                                            "', Crops.Species = '" + this.species_TextBox.Text.ToString().Trim() +
                                            "', Crops.Variety = '" + this.variety_TextBox.Text.ToString().Trim() +
                                            "', Crops.Brand = '" + this.brand_TextBox.Text.ToString().Trim() + "'";

                if (this.notes_RichTextBox.Text.ToString().Trim() != "")
                {
                    queryString += ", Crops.Notes = '" + this.notes_RichTextBox.Text.ToString().Trim() + "'";
                }


                queryString += " Where Crops.Crop_ID = " + this.crop_ID_Label.Text.ToString().Trim();

                string queryMessage = "Update Crop";
                string querySuccess = "Crop has been updated.";
                string queryFail = "There was a problem, the srop was not updated.";

                myFunctions.queryExecute(queryString, queryMessage, querySuccess, queryFail);

            }

            set_Text_Visibility(false);
            set_Label_Visibility(true);
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
    }
}
