using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParsDashboard.FrmImageFilter;

namespace ParsDashboard
{
    public partial class FrmFilterDate : Form
    {    
        public FrmFilterDate()
        {
            InitializeComponent();
        }

        private void RdoFilterGreaterThan_Click(object sender, EventArgs e)
        {
            if ( RdoFilterGreaterThan.Checked )
            {
                DtStart.Visible = true;
                LblAnd.Visible = false;
                DtEnd.Visible = false;
            }
        }

        private void RdoFilterBetween_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFilterBetween.Checked )
            {
                DtStart.Visible = true;
                LblAnd.Visible = true;
                DtEnd.Visible = true;
            }
        }

        private void RdoFilterEqualTo_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFilterEqualTo.Checked )
            {
                DtStart.Visible = true;
                LblAnd.Visible = false;
                DtEnd.Visible = false;
            }
        }

        private void RdoFilterGreaterThan_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFilterGreaterThan.Checked )
            {
                DtStart.Visible = true;
                LblAnd.Visible = false;
                DtEnd.Visible = false;
            }
        }

        private void RdoFilterLessThan_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFilterLessThan.Checked )
            {
                DtStart.Visible = true;
                LblAnd.Visible = false;
                DtEnd.Visible = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if ( RdoFilterEqualTo.Checked )
            {
                FilterVar.FilterDate = RdoFilterEqualTo.Text + " " + DtStart.Value.ToShortDateString();
            }

            if ( RdoFilterGreaterThan.Checked )
            {
                FilterVar.FilterDate = RdoFilterGreaterThan.Text + " " + DtStart.Value.ToShortDateString();
            }

            if ( RdoFilterLessThan.Checked )
            {
                FilterVar.FilterDate = RdoFilterLessThan.Text + " " + DtStart.Value.ToShortDateString();
            }

            if ( RdoFilterBetween.Checked )
            {
                FilterVar.FilterDate = RdoFilterBetween.Text + " " + DtStart.Value.ToShortDateString() + " and " + DtEnd.Value.ToShortDateString();
            }

            this.Close();         
        }
    }
}
