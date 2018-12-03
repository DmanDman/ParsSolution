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

        public static class PatientVar
        {
            public static int ClearType { get; set; }
        }
        public FrmPatient()
        {
            InitializeComponent();
        }

        private void TSMnuDash_Click( object sender, EventArgs e )
        {            
            //  show mdi child form by tag name, which is the name of the form
            frmNav.ShowFormName( this.MdiParent.MdiChildren, "FrmDashboard" );
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            // Enable double duffering to stop flickering.
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            SetStyle(ControlStyles.Opaque, false);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);

            DateTime CurrentYear = DateTime.Today;
            int year = CurrentYear.Year;

            UpDwnYear.Text= year.ToString();            
        }

        private void TabDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatientVar.ClearType = TabDisplay.SelectedIndex;
        }
    }
}
