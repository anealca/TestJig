using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestJig_GUI
{
    public partial class TJmenu : Form
    {
        public TJmenu() {
            InitializeComponent();

            tAbout.Visible = false;
        }

        // --------- File Menu Items  ------------------------
        private void fmOpen_Click(object sender, EventArgs e) {
            AddStatus("Open File...");
            tAbout.Visible = false;
        }

        private void fmSave_Click(object sender, EventArgs e) {
            AddStatus("Save File...");
            tAbout.Visible = false;
        }

        private void fmExit_Click(object sender, EventArgs e) {
            AddStatus("Quiting...");
            Environment.Exit(0);
        }

        // -----------------  Edit menu items  ---------------------

        // -----------------  About Menu ---------------------------
        private void mmAbout_Click(object sender, EventArgs e) {
            AddStatus("About...");
            tAbout.Text = "Hello...\r\n  This is a Test Jig GUI application...\r\n\r\nVersion 0.1";
            tAbout.Visible = true;
        }

        // ------------- Status Textbox ---------------------------------
        static List<string> infotxt = new List<string>();
        private void ClearStatus() { infotxt.Clear(); tStatus.Clear(); }
        private void AddStatus(string txt) {
            infotxt.Insert(0, txt);
            tStatus.Lines = infotxt.ToArray();
        }
    }
}
