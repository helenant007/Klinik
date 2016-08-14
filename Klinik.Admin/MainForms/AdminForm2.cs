using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinik.Admin.MainForms
{
    public partial class AdminForm2 : Form
    {
        public AdminForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = false;

            button2.Click += (x, y) =>
            {
                splitContainer1.Panel2Collapsed = true;
            };
            button3.Click += (x, y) =>
            {
                splitContainer1.Panel2Collapsed = true;
            };
        }

        private void splitContainer1_Panel1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = false;

            button2.Click += (x, y) =>
            {
                splitContainer1.Panel2Collapsed = true;
            };
            button3.Click += (x, y) =>
            {
                splitContainer1.Panel2Collapsed = true;
            };
        }
    }
}
