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
    public partial class FrmDashboard : Form
    {       
        FormNav frmNav = new FormNav();        

        public FrmDashboard()
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
            this.Refresh();

            //// Enable double duffering to stop flickering.
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            SetStyle(ControlStyles.Opaque, false);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }
}
