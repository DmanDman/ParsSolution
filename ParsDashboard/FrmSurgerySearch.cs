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
    public partial class FrmSurgerySearch : Form
    {
        public static class SurgerySearchVar
        {
            public static int ClearType { get; set; }
        }

        public FrmSurgerySearch()
        {
            InitializeComponent();
        }

        private void RdoSurgeryEqualTo_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoSurgeryEqualTo.Checked )
            {
                DtStart.Visible = true;
                LblAnd.Visible = false;
                DtEnd.Visible = false;
            }
        }

        private void RdoSurgeryGreater_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoSurgeryGreater.Checked )
            {
                DtStart.Visible = true;
                LblAnd.Visible = false;
                DtEnd.Visible = false;
            }
        }

        private void RdoSurgeryLess_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoSurgeryLess.Checked )
            {
                DtStart.Visible = true;
                LblAnd.Visible = false;
                DtEnd.Visible = false;
            }
        }

        private void RdoSurgeryBetween_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoSurgeryBetween.Checked )
            {
                DtStart.Visible = true;
                LblAnd.Visible = true;
                DtEnd.Visible = true;
            }
        }

        private void RdoFiscalEqualTo_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFiscalEqualTo.Checked )
            {
                DtFiscalStart.Visible = true;
                LblAndFiscalYear.Visible = false;
                DtFiscalEnd.Visible = false;
            }
        }

        private void RdoFiscalGreater_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFiscalGreater.Checked )
            {
                DtFiscalStart.Visible = true;
                LblAndFiscalYear.Visible = false;
                DtFiscalEnd.Visible = false;
            }
        }

        private void RdoFiscalLess_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFiscalLess.Checked )
            {
                DtFiscalStart.Visible = true;
                LblAndFiscalYear.Visible = false;
                DtFiscalEnd.Visible = false;
            }
        }

        private void RdoFiscalBetween_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFiscalBetween.Checked )
            {
                DtFiscalStart.Visible = true;
                LblAndFiscalYear.Visible = true;
                DtFiscalEnd.Visible = true;
            }
        }

        private void TabDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            SurgerySearchVar.ClearType = TabDisplay.SelectedIndex;
        }
    }
}
