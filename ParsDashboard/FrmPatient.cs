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

        Helper helper = new Helper();

        #region Form SubRoutines

        public void Clear()
        {
            //  clear last name
            if ( PatientVar.ClearType == 0 )
            {
                helper.ClearUpDwn( UpDwnLastNameLetter );

                helper.ClearComboBox( CboFullName );
            }

            //  clear date
            if ( PatientVar.ClearType == 1 )
            {
                helper.ClearUpDwn( UpDwnYear );

                helper.ClearUpDwn( UpDwnMonth );
            }
        }

        #endregion

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
            //  set the tab number: 0 last name; 1 date
            PatientVar.ClearType = TabDisplay.SelectedIndex;
        }

        private void TSMnuPatientClear_Click(object sender, EventArgs e)
        {
            //  clear form
            Clear();
        }
    }
}
