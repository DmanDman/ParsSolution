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
    public partial class FrmPatient : Form
    {
        FormNav frmNav = new FormNav();

        public FrmPatient()
        {
            InitializeComponent();
        }

        private void TSMnuDash_Click(object sender, EventArgs e)
        {
            frmNav.ShowForm(this.MdiParent.MdiChildren[0]);
        }
    }
}
