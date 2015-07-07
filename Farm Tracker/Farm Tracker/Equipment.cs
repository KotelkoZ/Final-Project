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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();

            populate_Equipment_List();
            if (this.equipment_ListBox.Items.Count != 0)
            {
                this.equipment_ListBox.SelectedIndex = 0;
            }
        }
        private void update_Button_Click(object sender, EventArgs e)
        {
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
            }
            else
            {
                this.equipment_ID_Label.Text = "Operator ID";
            }

            return;
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            //NEW EQUIPMENT
            if (this.equipment_ID_Label.Text.ToString().Trim() == "X")
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

                using (SqlConnection myconnection = new SqlConnection(Variables.CONNECTIONSTRING))
                {
                    myconnection.Open();

                    SqlCommand mycommand = myconnection.CreateCommand();
                    SqlTransaction mytransaction;

                    mytransaction = myconnection.BeginTransaction("Insert Equipment");

                    mycommand.Connection = myconnection;
                    mycommand.Transaction = mytransaction;

                    try
                    {

                        string queryString = "INSERT INTO Equipment(Equipment_Type,Year,Brand,Serial_Number,Model_Number,Hours ";

                        if (this.horsepower_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ",Horsepower";
                        }
                        if (this.number_Of_Tanks_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ",Number_Of_Tanks";
                        }
                        if (this.tank_Size_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ",Tank_Size";
                        }
                        if (this.width_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ",Width";
                        }
                        if (this.shank_Spacing_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ",Shank_Spacing";
                        }
                        if (this.equipment_PictureBox.Image != null)
                        {
                            queryString += ",Image";
                        }

                        queryString += ",Operational) ";

                        queryString += " values(@Equipment_Type" +
                                            ",@Year" +
                                            ",@Brand" +
                                            ",@Serial_Number" +
                                            ",@Model_Number" +
                                            ",@Hours";

                        if (this.horsepower_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ",@Horsepower";
                        }
                        if (this.number_Of_Tanks_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ",@Number_Of_Tanks";
                        }
                        if (this.tank_Size_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ",@Tank_Size";
                        }
                        if (this.width_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ",@Width";
                        }
                        if (this.shank_Spacing_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ",@Shank_Spacing";
                        }
                        if (this.equipment_PictureBox.Image != null)
                        {
                            queryString += ",@Image";
                        }

                        queryString += ",@Operational)";

                        mycommand.CommandText = queryString;

                        mycommand.Parameters.Add("@Equipment_Type", SqlDbType.NChar, 20);
                        mycommand.Parameters["@Equipment_Type"].Value = this.equipment_Type_TextBox.Text;

                        mycommand.Parameters.Add("@Year", SqlDbType.Int, 4);
                        mycommand.Parameters["@Year"].Value = this.year_TextBox.Text;

                        mycommand.Parameters.Add("@Brand", SqlDbType.NChar, 10);
                        mycommand.Parameters["@Brand"].Value = this.brand_TextBox.Text;

                        mycommand.Parameters.Add("@Serial_Number", SqlDbType.NChar, 25);
                        mycommand.Parameters["@Serial_Number"].Value = this.serial_Number_Textbox.Text;

                        mycommand.Parameters.Add("@Model_Number", SqlDbType.NChar, 15);
                        mycommand.Parameters["@Model_Number"].Value = this.model_Number_TextBox.Text;

                        mycommand.Parameters.Add("@Hours", SqlDbType.Int, 4);
                        mycommand.Parameters["@Hours"].Value = this.hours_TextBox.Text;

                        if (this.horsepower_TextBox.Text.ToString().Trim() != "")
                        {
                            mycommand.Parameters.Add("@Horsepower", SqlDbType.Int, 4);
                            mycommand.Parameters["@Horsepower"].Value = this.horsepower_TextBox.Text;
                        }
                        if (this.number_Of_Tanks_TextBox.Text.ToString().Trim() != "")
                        {
                            mycommand.Parameters.Add("@Number_Of_Tanks", SqlDbType.Int, 4);
                            mycommand.Parameters["@Number_Of_Tanks"].Value = this.number_Of_Tanks_TextBox;
                        }
                        if (this.tank_Size_TextBox.Text.ToString().Trim() != "")
                        {
                            mycommand.Parameters.Add("@Tank_Size", SqlDbType.Int, 4);
                            mycommand.Parameters["@Tank_Size"].Value = this.tank_Size_TextBox.Text;
                        }
                        if (this.width_TextBox.Text.ToString().Trim() != "")
                        {
                            mycommand.Parameters.Add("@Width", SqlDbType.Int, 4);
                            mycommand.Parameters["@Width"].Value = width_TextBox.Text;
                        }
                        if (this.shank_Spacing_TextBox.Text.ToString().Trim() != "")
                        {
                            mycommand.Parameters.Add("@Shank_Spacing", SqlDbType.Int, 4);
                            mycommand.Parameters["@Shank_Spacing"].Value = this.shank_Spacing_TextBox.Text;
                        }
                        if (this.equipment_PictureBox.Image != null)
                        {
                            mycommand.Parameters.Add("@Image", SqlDbType.Image);
                            mycommand.Parameters["@Image"].Value = myFunctions.ImageToByteArray(this.equipment_PictureBox.Image, this.equipment_PictureBox);
                        }

                        mycommand.Parameters.Add("@Operational", SqlDbType.Bit);
                        mycommand.Parameters["@Operational"].Value = 1;

                        mycommand.ExecuteNonQuery();

                        // Attempt to commit the transaction. 
                        mytransaction.Commit();
                        MessageBox.Show("Equipment has been created.");
                        myconnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was a problem, the equipment was not created.");
                        Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                        Console.WriteLine("  Message: {0}", ex.Message);

                        // Attempt to roll back the transaction.  
                        try
                        {
                            mytransaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            // This catch block will handle any errors that may have occurred  
                            // on the server that would cause the rollback to fail, such as  
                            // a closed connection. 
                            Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                            Console.WriteLine("  Message: {0}", ex2.Message);
                        }
                    }
                }

            }
            //UPDATE EQUIPMENT
            else
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

                using (SqlConnection myconnection = new SqlConnection(Variables.CONNECTIONSTRING))
                {
                    myconnection.Open();

                    SqlCommand mycommand = myconnection.CreateCommand();
                    SqlTransaction mytransaction;

                    mytransaction = myconnection.BeginTransaction("Update Equipment");

                    mycommand.Connection = myconnection;
                    mycommand.Transaction = mytransaction;

                    try
                    {


                        string queryString = "update Equipment set Equipment.Equipment_Type = @Equipment_Type" +
                                                    ", Equipment.Year = @Year" +
                                                    ", Equipment.Brand = @Brand" +
                                                    ", Equipment.Serial_Number = @Serial_Number" +
                                                    ", Equipment.Model_Number = @Model_Number" +
                                                    ", Equipment.Hours = @Hours";

                        if (this.horsepower_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ", Equipment.Horsepower = @Horsepower";
                        }
                        if (this.number_Of_Tanks_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ", Equipment.Number_Of_Tanks = @Number_Of_Tanks";
                        }
                        if (this.tank_Size_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ", Equipment.tank_Size = @Tank_Size";
                        }
                        if (this.width_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ", Equipment.Width = @Width";
                        }
                        if (this.shank_Spacing_TextBox.Text.ToString().Trim() != "")
                        {
                            queryString += ", Equipment.Shank_Spacing = @Shank_Spacing";
                        }
                        if (this.equipment_PictureBox.Image != null)
                        {
                            queryString += ", Equipment.Image = @Image";
                        }

                        queryString += " Where Equipment.Equipment_ID = @ID";

                        mycommand.CommandText = queryString;

                        

                        mycommand.Parameters.Add("@Equipment_Type", SqlDbType.NChar, 20);
                        mycommand.Parameters["@Equipment_Type"].Value = this.equipment_Type_TextBox.Text;
                        
                        MessageBox.Show("Here 1");

                        mycommand.Parameters.Add("@Year", SqlDbType.Int, 4);
                        mycommand.Parameters["@Year"].Value = this.year_TextBox.Text;

                        mycommand.Parameters.Add("@Brand", SqlDbType.NChar, 10);
                        mycommand.Parameters["@Brand"].Value = this.brand_TextBox.Text;

                        mycommand.Parameters.Add("@Serial_Number", SqlDbType.NChar, 25);
                        mycommand.Parameters["@Serial_Number"].Value = this.serial_Number_Textbox.Text;

                        mycommand.Parameters.Add("@Model_Number", SqlDbType.NChar, 15);
                        mycommand.Parameters["@Model_Number"].Value = this.model_Number_TextBox.Text;

                        mycommand.Parameters.Add("@Hours", SqlDbType.Int, 4);
                        mycommand.Parameters["@Hours"].Value = this.hours_TextBox.Text;
                        
                        MessageBox.Show("Here 2");

                        if (this.horsepower_TextBox.Text.ToString().Trim() != "")
                        {
                            mycommand.Parameters.Add("@Horsepower", SqlDbType.Int, 4);
                            mycommand.Parameters["@Horsepower"].Value = this.horsepower_TextBox.Text;
                        }
                        if (this.number_Of_Tanks_TextBox.Text.ToString().Trim() != "")
                        {
                            mycommand.Parameters.Add("@Number_Of_Tanks", SqlDbType.Int, 4);
                            mycommand.Parameters["@Number_Of_Tanks"].Value = this.number_Of_Tanks_TextBox;
                        }
                        if (this.tank_Size_TextBox.Text.ToString().Trim() != "")
                        {
                            mycommand.Parameters.Add("@Tank_Size", SqlDbType.Int, 4);
                            mycommand.Parameters["@Tank_Size"].Value = this.tank_Size_TextBox.Text;
                        }
                        if (this.width_TextBox.Text.ToString().Trim() != "")
                        {
                            mycommand.Parameters.Add("@Width", SqlDbType.Int, 4);
                            mycommand.Parameters["@Width"].Value = width_TextBox.Text;
                        }
                        if (this.shank_Spacing_TextBox.Text.ToString().Trim() != "")
                        {
                            mycommand.Parameters.Add("@Shank_Spacing", SqlDbType.Int, 4);
                            mycommand.Parameters["@Shank_Spacing"].Value = this.shank_Spacing_TextBox.Text;
                        }
                        if (this.equipment_PictureBox.Image != null)
                        {
                            mycommand.Parameters.Add("@Image", SqlDbType.Image);
                            mycommand.Parameters["@Image"].Value = myFunctions.ImageToByteArray(this.equipment_PictureBox.Image, this.equipment_PictureBox);
                        }

                        mycommand.Parameters.Add("@ID", SqlDbType.Int, 4);
                        mycommand.Parameters["@ID"].Value = this.equipment_ID_Label.Text;

                        MessageBox.Show("Here 3");

                        mycommand.ExecuteNonQuery();

                        MessageBox.Show("Here 4");
                        // Attempt to commit the transaction. 
                        mytransaction.Commit();
                        MessageBox.Show("Equipment has been updated.");
                        myconnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was a problem, the equipment was not updated.");
                        Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                        Console.WriteLine("  Message: {0}", ex.Message);

                        // Attempt to roll back the transaction.  
                        try
                        {
                            mytransaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            // This catch block will handle any errors that may have occurred  
                            // on the server that would cause the rollback to fail, such as  
                            // a closed connection. 
                            Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                            Console.WriteLine("  Message: {0}", ex2.Message);
                        }
                    }
                }

                set_Text_Visibility(false);
                set_Label_Visibility(true);

                set_Save_Cancel_Visibility(false);
                clear_Text_Fields();
                set_Main_Button_Visibility(true);
                this.delete_Button.Visible = false;

                this.equipment_ListBox.Enabled = true;

                populate_Equipment_List();

                if (this.equipment_ListBox.Items.Count != 0)
                {
                    this.equipment_ListBox.SelectedIndex = 0;
                }

                populate_Equipment_Info();

                return;
            }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            string queryString = "delete from Equipment where Equipment.Equipment_ID = '" + this.equipment_ID_Label.Text.ToString().Trim() + "'";

            string queryMessage = "Delete Equipment";
            string querySuccess = "Equipment has been deleted.";
            string queryFail = "There was a problem, the equipment was not Deleted.";

            myFunctions.queryExecute(queryString, queryMessage, querySuccess, queryFail);

            populate_Equipment_List();

            set_Text_Visibility(false);
            set_Label_Visibility(true);
            set_Save_Cancel_Visibility(false);
            this.delete_Button.Visible = false;
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            this.equipment_ListBox.Enabled = true;

            return;
        }


        private void set_Main_Button_Visibility(bool value)
        {
            this.update_Equipment_Button.Visible = value;
            this.new_Equipment_Button.Visible = value;

            return;
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
        private void equipment_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_Equipment_Info();
        }

        private void populate_Equipment_List()
        {
            this.equipment_ListBox.Items.Clear();

            String queryString = "select Equipment.Equipment_ID, Equipment.Equipment_Type, Equipment.Brand from Equipment ";


            using (SqlConnection connection = new SqlConnection(Variables.CONNECTIONSTRING))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.equipment_ListBox.Items.Add(reader[0].ToString().Trim() + "\t" +
                                                            reader[1].ToString().Trim() + "\t" +
                                                            reader[2].ToString().Trim());
                        }
                        reader.Close();
                    }
                }
                connection.Close();
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

            String queryString = "select * from Equipment where Equipment.Equipment_ID = " + operatorID;

            using (SqlConnection connection = new SqlConnection(Variables.CONNECTIONSTRING))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        this.equipment_ID_Label.Text = reader[0].ToString().Trim();
                        this.equipment_Type_Label.Text = reader[1].ToString().Trim();
                        this.year_Label.Text = reader[2].ToString().Trim();
                        this.brand_Label.Text = reader[3].ToString().Trim();
                        this.serial_Number_Label.Text = reader[4].ToString().Trim();
                        this.model_Number_Label.Text = reader[5].ToString().Trim();
                        this.hours_Label.Text = reader[6].ToString().Trim();
                        this.horsepower_Label.Text = reader[7].ToString().Trim();
                        this.number_Of_Tanks_Label.Text = reader[8].ToString().Trim();
                        this.tank_Size_Label.Text = reader[9].ToString().Trim();
                        this.width_Label.Text = reader[10].ToString().Trim();
                        this.shank_Spacing_Label.Text = reader[11].ToString().Trim();

                        byte[] arr = (byte[])reader[12];

                        this.equipment_PictureBox.Image = myFunctions.GetDataToImage(arr);

                        reader.Close();
                    }
                }
                connection.Close();
            }
        }

        private void add_Image_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogBox = new OpenFileDialog();

            dialogBox.Title = "Choose Image";
            dialogBox.Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG";

            if (dialogBox.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(dialogBox.FileName);

                

                equipment_PictureBox.Image = myFunctions.ResizeImage(img,286,244) ;
            }
        }

        private void equipment_PictureBox_Click(object sender, EventArgs e)
        {

        }

    }
}
