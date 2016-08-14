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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            new Admin.MainForms.AdminForm2().Show();
        }

        private void TbUsername_Click(object sender, EventArgs e)
        {
            if (TbPass.Text == "")
            {
                TbPass.UseSystemPasswordChar = false;
                TbPass.Text = "Password";
            }

            if (TbUsername.Text == "Username")
                TbUsername.Text = "";
        }

        private void TbPass_Click(object sender, EventArgs e)
        {
            if (TbUsername.Text == "")
                TbUsername.Text = "Username";

            if (TbPass.Text == "Password")
            {
                TbPass.Text = "";
                TbPass.UseSystemPasswordChar = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {


            if (verifyUser()) // <-- ini jelek, seharusnya fungsi by default return true wkwkwk oke ak
            {
                //if match user table
                var mf = new MainForm();
                mf.Show();

                this.Hide();
                mf.FormClosed += (x, y) => this.Dispose();
            }
            else  //if NOT match user table
            {

                //((MainForm)MdiParent).LoginSuccess(TbUsername.Text);




                // new MainForm(this, TbUsername.Text).Visible = true;
                // this.Visible = false;
            }
        }

        private bool verifyUser()
        {
            var query = "plz";
            //how to connect with db?

            if (query == null)
            {
                MessageBox.Show("User account not found!");
                return false;
            }
            else
            {
                //MessageBox.Show("Welcome " + query.UserName + " !!");
                return true;
            }
        }
    }
}
