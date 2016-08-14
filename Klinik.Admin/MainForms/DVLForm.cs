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
    public partial class DVLForm : Form
    {

        bool _insert, _update;

        public DVLForm()
        {
            InitializeComponent();
            mode(true);
        }

        private void mode(bool state, int custom = 0) {
            BtnSave.Enabled = 
            BtnCancel.Enabled = !state;

            dateTimePicker1.Enabled =
            TbBinusID.ReadOnly =
            CbSection.Enabled =
            TbName.ReadOnly =
            TbPhone.ReadOnly = 
            TbDiagnose.ReadOnly =
            TbAnamnesis.ReadOnly = 
            TbImplementation.ReadOnly =
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
