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
    public partial class MainApp : Form
    {
        //Controls enum holding names of all the user controls
        public enum ControlsEnum
        {
            OVERVIEW_CONTROL,            
            BREAKDOWN_CONTROL,
            OPERATORS_CONTROL,
            EQUIPMENT_CONTROL,
            FIELDS_CONTROL,
            CROPS_CONTROL,
            CHEMICALS_CONTROL,
            FARMING_EVENT_CONTROL,
            REPORTS_CONTROL
        }

        //Dictionary that holds all our instantiated user controls.
        private IDictionary<ControlsEnum, Control> controls = new Dictionary<ControlsEnum, Control>();

        public MainApp(string position)
        {
            InitializeComponent();

            if (position.ToLower() == "mechanic")
            {
                overview_Button.Visible = false;
                farming_Events_Button.Visible = false;
                operators_Button.Visible = false;
                crops_Button.Visible = false;
                chemical_Button.Visible = false;
                fields_Button.Visible = false;
                reports_Button.Visible = false;
            }

        }
        public void ShowControl(ControlsEnum ctrl)
        {
            Control new_control = null;

            //If our dictionary already contains instance of
            if (controls.ContainsKey(ctrl))
            {
                new_control = controls[ctrl];
            }
            else
            {
                new_control = CreateControl(ctrl);
                controls[ctrl] = new_control;
            }
            new_control.Parent = main_Function_Panel;
            new_control.Anchor = AnchorStyles.Bottom;
            new_control.Anchor = AnchorStyles.Left;
            new_control.Anchor = AnchorStyles.Right;
            new_control.Anchor = AnchorStyles.Top;
            new_control.Dock = DockStyle.Fill;
            new_control.BringToFront();
            new_control.Show();
        }
        private Control CreateControl(ControlsEnum ctrl)
        {
            switch (ctrl)
            {
                case ControlsEnum.OVERVIEW_CONTROL:
                    //return new Overview_UserControl();
                case ControlsEnum.BREAKDOWN_CONTROL:
                    return new Breakdown_UserControl();
                case ControlsEnum.OPERATORS_CONTROL:
                    return new Operators_UserControl();
                case ControlsEnum.EQUIPMENT_CONTROL:
                    return new Equipment_UserControl();
                case ControlsEnum.FIELDS_CONTROL:
                    return new Field_UserControl();
                case ControlsEnum.CROPS_CONTROL:
                    return new Crop_UserControl();
                case ControlsEnum.CHEMICALS_CONTROL:
                    return new Chemical_UserControl();
                case ControlsEnum.FARMING_EVENT_CONTROL:
                    return new Farming_Event_UserControl();
                case ControlsEnum.REPORTS_CONTROL:
                    //return new Reports_UserControl();
                default:
                    return null;
            }
        }
        private void breakdown_Button_Click(object sender, EventArgs e)
        {
            set_Button_Colors();
            breakdown_Button.BackColor = SystemColors.ActiveCaption;
            ShowControl(ControlsEnum.BREAKDOWN_CONTROL);
        }
        private void overview_Button_Click(object sender, EventArgs e)
        {
            set_Button_Colors();
            overview_Button.BackColor = SystemColors.ActiveCaption;
            ShowControl(ControlsEnum.OVERVIEW_CONTROL);
        }
        private void operators_Button_Click(object sender, EventArgs e)
        {
            set_Button_Colors();
            operators_Button.BackColor = SystemColors.ActiveCaption;
            ShowControl(ControlsEnum.OPERATORS_CONTROL);
        }
        private void equipment_Button_Click(object sender, EventArgs e)
        {
            set_Button_Colors();
            equipment_Button.BackColor = SystemColors.ActiveCaption;
            ShowControl(ControlsEnum.EQUIPMENT_CONTROL);
        }
        private void fields_Button_Click(object sender, EventArgs e)
        {
            set_Button_Colors();
            fields_Button.BackColor = SystemColors.ActiveCaption;
            ShowControl(ControlsEnum.FIELDS_CONTROL);
        }
        private void crops_Button_Click(object sender, EventArgs e)
        {
            set_Button_Colors();
            crops_Button.BackColor = SystemColors.ActiveCaption;
            ShowControl(ControlsEnum.CROPS_CONTROL);
        }
        private void chemical_Button_Click(object sender, EventArgs e)
        {
            set_Button_Colors();
            chemical_Button.BackColor = SystemColors.ActiveCaption;
            ShowControl(ControlsEnum.CHEMICALS_CONTROL);
        }
        private void reports_Button_Click(object sender, EventArgs e)
        {
            set_Button_Colors();
            reports_Button.BackColor = SystemColors.ActiveCaption;
            //ShowControl(ControlsEnum.REPORTS_CONTROL);
        }
        private void farming_Events_Button_Click(object sender, EventArgs e)
        {
            set_Button_Colors();
            farming_Events_Button.BackColor = SystemColors.ActiveCaption;
            ShowControl(ControlsEnum.FARMING_EVENT_CONTROL);
        }
        private void MainApp_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void logout_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void set_Button_Colors()
        {
            overview_Button.BackColor = SystemColors.Control;
            farming_Events_Button.BackColor = SystemColors.Control;
            breakdown_Button.BackColor = SystemColors.Control;
            operators_Button.BackColor = SystemColors.Control;
            crops_Button.BackColor = SystemColors.Control;
            chemical_Button.BackColor = SystemColors.Control;
            fields_Button.BackColor = SystemColors.Control;
            equipment_Button.BackColor = SystemColors.Control;
            reports_Button.BackColor = SystemColors.Control;
        }
    }
}
