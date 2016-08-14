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
    public partial class MDIForm : Form
    {
        Stack<Form> sforms = new Stack<Form>();
        private Form currentForm
        {
            get
            {
                if (sforms.Count == 0) return null;
                else
                    return sforms.Peek();
            }
        }
        private void StackForm(Form form)
        { 

        }
        private void LoadForm(Form form)
        {
            if (currentForm != null && form.GetType() == currentForm.GetType())
                return;

            if (currentForm != null)
            {
                currentForm.Close();
                sforms.Pop();
            }
            //hmm knp di lu nge bug dikit
            form.ControlBox = false;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.WindowState = FormWindowState.Normal;
            form.Visible = true;
            form.WindowState = FormWindowState.Maximized;
            menuStrip1.Items.Add(form.Text);
            sforms.Push(form);
        }

        public MDIForm()
        {
            InitializeComponent();
            LoadForm(new MainForm());
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {

            //jadi kalo mau Buka Form, pake fungsi yang udh gw sediain yah. si LoadForm
            //tapi sifatnya LoadForm begitu, bikin child mdi nya fullscreen , jadi
            //kayak si PickList harusnya JANGAN lewat si LoadForm picklist... itu yg tampilin gridview? bukan
            //yg form form pop up lah umumnya itu kayaknya pick username gk kepake sih wkwkwk wkkwkwk iya mungkin utk skrg blm kepake
            //oh ya trus ini pas load mdi kok ga fullscreen yah?
        }
    }
}
