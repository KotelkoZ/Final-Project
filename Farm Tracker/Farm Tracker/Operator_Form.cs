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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void new_Operator_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
