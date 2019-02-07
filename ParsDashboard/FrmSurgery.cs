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
    public partial class FrmSurgery : Form
    {
        Helper helper = new Helper();

        #region Form SubRoutines

        public void SurgeryClearType()
        {
            //  clear surgery type
            if ( SurgeryVar.ClearType == 0 )
            {
                helper.ClearUpDwn( UpDwnLastNameLetter );

                helper.ClearComboBox( CboFullName );
            }

            //  clear surgery date
            if ( SurgeryVar.ClearType == 1 )
            {
                helper.ClearUpDwn( UpDwnYear );

                helper.ClearUpDwn( UpDwnMonth );
            }
        }

        #endregion

        public static class SurgeryVar
        {
            public static int ClearType { get; set; }
        }

        public FrmSurgery()
        {
            InitializeComponent();
        }

        private void TabDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            SurgeryVar.ClearType = TabDisplay.SelectedIndex;
        }

        private void TSMnuSurgeryClear_Click(object sender, EventArgs e)
        {
            SurgeryClearType();
        }
    }
}
