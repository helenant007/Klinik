using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinik.Admin.UtilForms
{
    public partial class PickUsernameForm : Form
    {
        private Func<string, string> p;
        
        public PickUsernameForm(Func<string, string> p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void PickUsernameForm_Load(object sender, EventArgs e)
        {
            // Cara Link Project
            // Klik Kanan di References, trus Add References, pilih yang Project, terus Centang aja
            // yang Seeds nya gak perlu di centang karena lu emang ga butuh di project ini
            // Oke setelah Add References, jgn lupa Copy si App.config nyaa, karena disitu ada data-data EF yang penting, copy dari Klinik.Data
            

            Klinik.Data.KlinikModelContainer db = new Data.KlinikModelContainer();

            foreach (var admin in db.Admins)
            {
                listBox1.Items.Add(admin.Username);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p(listBox1.SelectedItem.ToString());
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //oke, yowis. ada lg yg perlu gw pelajari? untuk saat ini? wkwkkw 
            p(listBox1.SelectedItem.ToString());
        }
    }
}
