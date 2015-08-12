using System;
using System.IO;
using System.Windows.Forms;
 
namespace Farm_Tracker
{

    public partial class Field_Form : Form
    {

        public Field_Form()
        {
            InitializeComponent();
            load_Map();
        }

        private void map_WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void new_Field_Button_Click(object sender, EventArgs e)
        {

            //map_WebBrowser.Document.InvokeScript("showMessage");

        }

        private void load_Map()
        {
            try
            {
                
                map_WebBrowser.DocumentStream = new FileStream("../../HTMLPage2.html", FileMode.Open, FileAccess.Read); 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void map_WebKitBrowser_Load(object sender, EventArgs e)
        {
            
        }

        private void map_WebBrowser_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
