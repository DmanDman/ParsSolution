using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParsDashboard
{
    public partial class FrmImageFilter : Form
    {
        FrmFilterAge fFilterAge = new FrmFilterAge();
        FrmFilterDate fFilterDate = new FrmFilterDate();

        public FrmImageFilter()
        {
            InitializeComponent();            
        }

        private void ChkSurgeryAge_Click(object sender, EventArgs e)
        {
            if( ChkSurgeryAge.Checked )
            {
                fFilterAge.ShowDialog();       
            }
        }

        private void ChkSurgeryDate_Click(object sender, EventArgs e)
        {
            if ( ChkSurgeryDate.Checked )
            {
                fFilterDate.ShowDialog();
            }
        }
    }
}
