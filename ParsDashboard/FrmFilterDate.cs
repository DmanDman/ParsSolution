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
using static ParsDashboard.FrmAddNew;
using static ParsDashboard.Globals;

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
            //  FrmPatientSearch personal info
            if ( FORMLOADED == "FrmPatientSearch" )
            { 
                if ( PatientSearchVar.DobChecked == true )
                { DOBCANCEL = true; }

                if ( PatientSearchVar.SurgeryDateChecked == true )
                { SURGERYDATECANCEL = true; }
            }

            //  FrmAddNew personal info
            if ( FORMLOADED == "FrmAddNew" )
            { 
                if ( AddNewVar.DobChecked == true )
                { DOBCANCEL = true; }
            
                if ( AddNewVar.AgeChecked == true )
                { AGECANCEL = true; }
            }

            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //  FrmPatientSearch personal info
            if ( FORMLOADED == "FrmPatientSearch" )
            {
                if ( PatientSearchVar.PersonalType == 1 )
                {
                    //  date of birth checked
                    if ( PatientSearchVar.DobChecked == true )
                    {
                        if ( RdoFilterEqualTo.Checked )
                        { PatientSearchVar.FilterDOB = RdoFilterEqualTo.Text + " " + DtStart.Text; }

                        if ( RdoFilterGreaterThan.Checked )
                        { PatientSearchVar.FilterDOB = RdoFilterGreaterThan.Text + " " + DtStart.Text; }

                        if ( RdoFilterLessThan.Checked )
                        { PatientSearchVar.FilterDOB = RdoFilterLessThan.Text + " " + DtStart.Text; }

                        if ( RdoFilterBetween.Checked )
                        { PatientSearchVar.FilterDOB = RdoFilterBetween.Text + " " + DtStart.Text + " and " + DtEnd.Text; }
                    }

                    //  surgery date checked
                    if ( PatientSearchVar.SurgeryDateChecked == true )
                    {
                        if ( RdoFilterEqualTo.Checked )
                        { PatientSearchVar.FilterSurgeryDate = RdoFilterEqualTo.Text + " " + DtStart.Text; }

                        if ( RdoFilterGreaterThan.Checked )
                        { PatientSearchVar.FilterSurgeryDate = RdoFilterGreaterThan.Text + " " + DtStart.Text; }

                        if ( RdoFilterLessThan.Checked )
                        { PatientSearchVar.FilterSurgeryDate = RdoFilterLessThan.Text + " " + DtStart.Text; }

                        if ( RdoFilterBetween.Checked )
                        { PatientSearchVar.FilterSurgeryDate = RdoFilterBetween.Text + " " + DtStart.Text + " and " + DtEnd.Text; }
                    }
                }
            }

            //  FrmAddNew personal info
            if ( FORMLOADED == "FrmAddNew" )
            { 
                if ( AddNewVar.AddNewStep == 1 )
                {
                    if ( RdoFilterEqualTo.Checked )
                    { AddNewVar.FilterDOB = RdoFilterEqualTo.Text + " " + DtStart.Text; }

                    if ( RdoFilterGreaterThan.Checked )
                    { AddNewVar.FilterDOB = RdoFilterGreaterThan.Text + " " + DtStart.Text; }

                    if ( RdoFilterLessThan.Checked )
                    { AddNewVar.FilterDOB = RdoFilterLessThan.Text + " " + DtStart.Text; }

                    if ( RdoFilterBetween.Checked )
                    { AddNewVar.FilterDOB = RdoFilterBetween.Text + " " + DtStart.Text + " and " + DtEnd.Text; }
                }
            }

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
