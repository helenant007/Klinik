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
    public partial class HospitalizedForm : Form
    {
        bool _insert, _update;
        public HospitalizedForm()
        {
            InitializeComponent();
            mode(true);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            mode(false);

            dateTimePicker1.Text = DateTime.Now.Date.ToString();
            TbBinusID.Text =
            CbSection.Text =
            TbName.Text =
            TbPhone.Text =
            TbDiagnose.Text =
            TbHName.Text =
            TbNotes.Text = "";




            _insert = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            mode(false);


            _update = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int _custom = 0;
            //do delete data

            mode(true, _custom);

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_insert)
            {
                //add to db
            }
            else if (_update)
            {

            }

            //save to db
            _insert = _update = false;
            mode(true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _insert = _update = false;
            mode(true);
        }

        private void mode(bool state, int custom = 0)
        {
            BtnSave.Enabled =
            BtnCancel.Enabled =
            dateTimePicker1.Enabled =
            CbSection.Enabled = !state;


            TbBinusID.ReadOnly =
            TbName.ReadOnly =
            TbPhone.ReadOnly =
            TbDiagnose.ReadOnly =
            TbHName.ReadOnly =
            TbNotes.ReadOnly =

            BtnInsert.Enabled = state;

            if (custom == 0)
            {
                BtnUpdate.Enabled =
                BtnDelete.Enabled = state;
            }
            else if (custom == 1) //kondisi ga ada data, ga bisa update + delete
            {
                BtnUpdate.Enabled =
                BtnDelete.Enabled = !state;
            }

        }
    }
}
