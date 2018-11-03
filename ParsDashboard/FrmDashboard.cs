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
    public partial class f : Form
    {
        FormNav frmNav = new FormNav();        

        public f()
        {
            InitializeComponent();
        }

        private void TSMnuGotoPatient_Click(object sender, EventArgs e)
        {
            //  show mdi child form by tag name, which is the name of the form
            frmNav.ShowFormName( this.MdiParent.MdiChildren, "FrmPatient" );
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void GrpInfo_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
