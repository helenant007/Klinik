using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinik.Admin.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           this.WindowState = FormWindowState.Maximized;
        }
        public void LoginSuccess(string uname) {
            LbGreet.Text = "Welcome " + uname;
        }

        private void BtnDVL_Click(object sender, EventArgs e)
        {
            new Admin.MainForms.DVLForm().Show();
        }

        private void BtnSection_Click(object sender, EventArgs e)
        {
            new Admin.MainForms.SectionListForm().Show();
        }

        private void BtnHospitalized_Click(object sender, EventArgs e)
        {
            new Admin.MainForms.HospitalizedForm().Show();
        }

        private void BtnMedicine_Click(object sender, EventArgs e)
        {

        }
    }
}
