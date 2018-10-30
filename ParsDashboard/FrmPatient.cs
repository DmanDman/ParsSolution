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

        private void TSMnuDash_Click( object sender, EventArgs e )
        {            
            //  show mdi child form by tag name, which is the name of the form
            frmNav.ShowFormName( this.MdiParent.MdiChildren, "FrmDashboard" );
        }
    }
}
