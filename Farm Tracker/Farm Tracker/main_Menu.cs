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
    public partial class main_Menu : Form
    {
        public main_Menu()
        {
            InitializeComponent();
        }

        private void operators_Button_Click(object sender, EventArgs e)
        {
            Operator_Form operatorWindow = new Operator_Form();
            operatorWindow.Owner = this;
            operatorWindow.Visible = true;

            return;
        }

        private void crops_Button_Click(object sender, EventArgs e)
        {
            Crop_Form cropWindow = new Crop_Form();
            cropWindow.Owner = this;
            cropWindow.Visible = true;

            return;
        }
        private void equipment_Button_Click(object sender, EventArgs e)
        {
            Equipment equipmentWindow = new Equipment();
            equipmentWindow.Owner = this;
            equipmentWindow.Visible = true;

            return;
        }
        private void fields_Button_Click(object sender, EventArgs e)
        {
            Field_Form fieldWindow = new Field_Form();
            fieldWindow.Owner = this;
            fieldWindow.Visible = true;

            return;
        }

        private void logout_Button_Click(object sender, EventArgs e)
        {
            foreach (Form aForm in this.OwnedForms)
            {
                aForm.Close();
            }

            this.Owner.Visible = true;
            
            this.Close();

            return;
        }

      

        
    }
}
