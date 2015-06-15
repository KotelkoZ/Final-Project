using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Tracker
{
    public partial class Operator_Form : Form
    {
        public Operator_Form()
        {
            InitializeComponent();
            set_Text_Visibility(false);
            set_Label_Visibility(true);
        }

        private void update_Password_Button_Click(object sender, EventArgs e)
        {
            set_Password_Visibility(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);

            return;
        }

        private void update_Operator_Button_Click(object sender, EventArgs e)
        {
            set_Label_Visibility(false);
            set_Text_Visibility(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);

            return;
        }


        private void new_Operator_Button_Click(object sender, EventArgs e)
        {
            set_Label_Visibility(false);
            set_Text_Visibility(true);
            set_Password_Visibility(true);
            set_Save_Cancel_Visibility(true);
            set_Main_Button_Visibility(false);

            return;
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            clear_Text_Fields();
            set_Label_Visibility(true);
            set_Text_Visibility(false);
            set_Password_Visibility(false);
            set_Save_Cancel_Visibility(false);
            set_Main_Button_Visibility(true);

            return;
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            set_Text_Visibility(false);
            set_Label_Visibility(true);
            set_Password_Visibility(false);
            set_Save_Cancel_Visibility(false);
            clear_Text_Fields();
            set_Main_Button_Visibility(true);

            return;
        }

        private void set_Main_Button_Visibility(bool value)
        {
            this.update_Password_Button.Visible = value;
            this.update_Operator_Button.Visible = value;
            this.new_Operator_Button.Visible = value;

            return;
        }

        private void clear_Text_Fields()
        {
            this.first_Name_TextBox.Clear();
            this.last_Name_TextBox.Clear();
            this.language_TextBox.Clear();
            this.password_TextBox.Clear();
            this.confirm_Password_TextBox.Clear();

            return;
        }

        private void set_Text_Visibility(bool value)
        {
            this.first_Name_TextBox.Visible = value;
            this.last_Name_TextBox.Visible = value;
            this.language_TextBox.Visible = value;

            return;
        }

        private void set_Password_Visibility(bool value)
        {
            this.password_Label.Visible = value;
            this.password_TextBox.Visible = value;
            this.confirm_Password_Label.Visible = value;
            this.confirm_Password_TextBox.Visible = value;

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
            this.first_Name_Label.Visible = value;
            this.last_Name_Label.Visible = value;
            this.language_Label.Visible = value;

            return;
        }

        private void phone_Number_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
