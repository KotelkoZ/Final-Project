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
        //Controls enum holding names of all our user controls
        public enum ControlsEnum
        {
            OVERVIEW_CONTROL,            
            BREAKDOWN_CONTROL,
            OPERATORS_CONTROL,
            EQUIPMENT_CONTROL,
            FIELDS_CONTROL,
            CROPS_CONTROL,
            CHEMICALS_CONTROL,
            FARMING_EVENTS,
            REPORTS_CONTROL
        }

        //Dictionary that holds all our instantiated user controls.
        private IDictionary<ControlsEnum, Control> controls = new Dictionary<ControlsEnum, Control>();

        public MainApp()
        {
            InitializeComponent();
            splitContainer.Panel2MinSize = 0;
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
            splitContainer.Panel2.ClientSize = new_control.Size;
            new_control.Parent = splitContainer.Panel2;
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
                case ControlsEnum.FARMING_EVENTS:
                    return new Farming_Event_UserControl();
                case ControlsEnum.REPORTS_CONTROL:
                    //return new Reports_UserControl();
                default:
                    return null;
            }
        }
        private void breakdown_Button_Click(object sender, EventArgs e)
        {
            ShowControl(ControlsEnum.BREAKDOWN_CONTROL);
        }
        private void overview_Button_Click(object sender, EventArgs e)
        {
            ShowControl(ControlsEnum.OVERVIEW_CONTROL);
        }
        private void operators_Button_Click(object sender, EventArgs e)
        {
            ShowControl(ControlsEnum.OPERATORS_CONTROL);
        }
        private void equipment_Button_Click(object sender, EventArgs e)
        {
            ShowControl(ControlsEnum.EQUIPMENT_CONTROL);
        }
        private void fields_Button_Click(object sender, EventArgs e)
        {
            ShowControl(ControlsEnum.FIELDS_CONTROL);
        }
        private void crops_Button_Click(object sender, EventArgs e)
        {
            ShowControl(ControlsEnum.CROPS_CONTROL);
        }
        private void chemical_Button_Click(object sender, EventArgs e)
        {
            ShowControl(ControlsEnum.CHEMICALS_CONTROL);
        }
        private void reports_Button_Click(object sender, EventArgs e)
        {
            ShowControl(ControlsEnum.REPORTS_CONTROL);
        }

    }
}
