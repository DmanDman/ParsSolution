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
using static ParsDashboard.FrmPatientSearch;
using static ParsDashboard.Globals;

namespace ParsDashboard
{
    public partial class FrmFilterAge : Form
    {       
        public FrmFilterAge()
        {
            InitializeComponent();
        }

        private void RdoFilterLessThan_CheckedChanged(object sender, EventArgs e)
        {
            if( RdoFilterLessThan.Checked )
            {
                NumLess.Visible = true;
                LblAnd.Visible = false;
                NumGreater.Visible = false;
            }
        }

        private void RdoFilterGreaterThan_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFilterGreaterThan.Checked )
            {
                NumLess.Visible = true;
                LblAnd.Visible = false;
                NumGreater.Visible = false;
            }
        }

        private void RdoFilterEqualTo_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFilterEqualTo.Checked )
            {
                NumLess.Visible = true;
                LblAnd.Visible = false;
                NumGreater.Visible = false;
            }
        }

        private void RdoFilterBetween_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFilterBetween.Checked )
            {
                NumLess.Visible = true;
                LblAnd.Visible = true;
                NumGreater.Visible = true;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if ( PatientSearchVar.AgeChecked == true )
            { AGECANCEL = true; }

            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            //  FrmPatientSearch personal info
            if ( PatientSearchVar.PersonalType == 1 )
            {
                //  age checked
                if ( PatientSearchVar.AgeChecked == true )
                {
                    if ( RdoFilterEqualTo.Checked )
                    { PatientSearchVar.FilterAge = RdoFilterEqualTo.Text + " " + NumLess.Text; }

                    if ( RdoFilterGreaterThan.Checked )
                    { PatientSearchVar.FilterAge = RdoFilterGreaterThan.Text + " " + NumLess.Text; }

                    if ( RdoFilterLessThan.Checked )
                    { PatientSearchVar.FilterAge = RdoFilterLessThan.Text + " " + NumLess.Text; }

                    if ( RdoFilterBetween.Checked )
                    { PatientSearchVar.FilterAge = RdoFilterBetween.Text + " " + NumLess.Text + " and " + NumGreater.Text; }
                }
            }
            
            //  set FrmImageFilter variables
            if ( RdoFilterEqualTo.Checked )
            { FilterVar.FilterAge = RdoFilterEqualTo.Text + " " + NumLess.Text; }

            if ( RdoFilterGreaterThan.Checked )
            { FilterVar.FilterAge = RdoFilterGreaterThan.Text + " " + NumLess.Text; }

            if ( RdoFilterLessThan.Checked )
            { FilterVar.FilterAge = RdoFilterLessThan.Text + " " + NumLess.Text; }
            
            if ( RdoFilterBetween.Checked )
            { FilterVar.FilterAge = RdoFilterBetween.Text + " " + NumLess.Text + " and " + NumGreater.Text; }

            this.Close();            
        }
    }
}
