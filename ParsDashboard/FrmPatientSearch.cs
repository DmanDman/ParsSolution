﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParsDashboard.Globals;

namespace ParsDashboard
{
    public partial class FrmPatientSearch : Form
    {
        SubRoutine SubRtnMain = new SubRoutine();

        Helper helper = new Helper();
        FormNav fNav = new FormNav();        

        FrmFilterAge fFilterAge = new FrmFilterAge();
        FrmFilterDate fFilterDate = new FrmFilterDate();

        #region Form SubRoutines

        public void Clear()
        {
            //  clear personal information
            if ( PatientSearchVar.ClearType == 0 )
            {
                helper.ClearTextBox( TxtLastName );
                helper.ClearTextBox( TxtFirstName );
                helper.ClearTextBox( TxtPatientNum );
                helper.ClearCheckBox( ChkSurgeryDate );
                helper.ClearCheckBox( ChkDOB );
                helper.ClearCheckBox( ChkAge );
                helper.ClearRadioBtn( RdoMale );
                helper.ClearRadioBtn( RdoFemale );
                helper.ClearMaskedTextBox( MTxtssn );

                TxtLastName.Focus();
            }

            //  clear home information
            if ( PatientSearchVar.ClearType == 1 )
            {
                helper.ClearTextBox( TxtAddress1 );
                helper.ClearTextBox( TxtAddress2 );
                helper.ClearTextBox( TxtCity );
                helper.ClearComboBoxTxt( CboState );
                helper.ClearMaskedTextBox( MTxtZip );
                helper.ClearMaskedTextBox( MTxtPhone );
                helper.ClearMaskedTextBox( MTxtCell );

                TxtAddress1.Focus();
            }
        }

        #endregion

        public static class PatientSearchVar
        {
            public static int ClearType { get; set; }
            public static int PersonalType { get; set; }

            public static bool AgeChecked { get; set; }
            public static bool DobChecked { get; set; }
            public static bool SurgeryDateChecked { get; set; }

            public static string FilterSurgeryDate { get; set; }
            public static string FilterDOB { get; set; }
            public static string FilterAge { get; set; }
        }

        public FrmPatientSearch()
        {
            InitializeComponent();
        }

        private void TabSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatientSearchVar.ClearType = TabSearch.SelectedIndex;
        }

        private void ChkSurgeryDate_CheckedChanged(object sender, EventArgs e)
        {
            if ( ChkSurgeryDate.Checked == true )
            {
                PatientSearchVar.PersonalType = 1;
                PatientSearchVar.SurgeryDateChecked = true;
            }
            else
            {
                TxtSurgeryDate.Text = "";
                TxtSurgeryDate.Height = 22;
                PatientSearchVar.FilterSurgeryDate = "";
                PatientSearchVar.SurgeryDateChecked = false;
            }
        }

        private void ChkSurgeryDate_Click(object sender, EventArgs e)
        {
            if ( ChkSurgeryDate.Checked )
            {
                SURGERYDATECANCEL = false;
                FORMLOADED = Tag.ToString();

                fFilterDate.ShowDialog();

                FORMLOADED = "";

                if ( SURGERYDATECANCEL == true )
                {
                    ChkSurgeryDate.Checked = false;
                }
                else
                {
                    TxtSurgeryDate.Text = PatientSearchVar.FilterSurgeryDate;
                }

                if ( TxtSurgeryDate.Text.Contains( "Between" ))
                {
                    TxtSurgeryDate.Height = 32;
                }
                else
                {
                    TxtSurgeryDate.Height = 22;
                }
            }
        }

        private void ChkAge_CheckedChanged(object sender, EventArgs e)
        {
            if ( ChkAge.Checked == true )
            {
                PatientSearchVar.PersonalType = 1;
                PatientSearchVar.AgeChecked = true;
            }
            else
            {
                TxtAge.Text = "";
                PatientSearchVar.FilterAge = "";
                PatientSearchVar.AgeChecked = false;
            }
        }

        private void ChkAge_Click(object sender, EventArgs e)
        {
            if ( ChkAge.Checked )
            {
                AGECANCEL = false;
                FORMLOADED = Tag.ToString();

                fFilterAge.ShowDialog();

                FORMLOADED = "";

                if ( AGECANCEL == true )
                {
                    ChkAge.Checked = false;
                }
                else
                {
                    TxtAge.Text = PatientSearchVar.FilterAge;
                }                
            }
        }

        private void ChkDOB_CheckedChanged(object sender, EventArgs e)
        {
            if ( ChkDOB.Checked == true )
            {
                PatientSearchVar.PersonalType = 1;
                PatientSearchVar.DobChecked = true;
            }
            else
            {
                TxtDob.Text = "";
                TxtDob.Height = 22;
                PatientSearchVar.FilterDOB = "";
                PatientSearchVar.DobChecked = false;
            }
        }

        private void ChkDOB_Click(object sender, EventArgs e)
        {
            if ( ChkDOB.Checked )
            {
                DOBCANCEL = false;
                FORMLOADED = Tag.ToString();

                fFilterDate.ShowDialog();

                FORMLOADED = "";

                if ( DOBCANCEL == true )
                {
                    ChkDOB.Checked = false;
                }
                else
                {
                    TxtDob.Text = PatientSearchVar.FilterDOB;
                }

                if ( TxtDob.Text.Contains( "Between" ))
                {
                    TxtDob.Height = 32;
                }
                else
                {
                    TxtDob.Height = 22;
                }
            }
        }

        private void TSMnuPatientSrchClear_Click(object sender, EventArgs e)
        {
            //  clear form
            Clear();
        }

        private void TSMnuPatientSrchSearch_Click(object sender, EventArgs e)
        {
            //  loop through open forms
            foreach ( Form f in Application.OpenForms )
            {
                //  show Image Search Results
                if ( f.Tag.ToString() == "FrmImageSearchResults" )
                {                    
                    f.BringToFront();
                }

                //  set navigation lable to selected on main form
                if ( f.Tag.ToString() == "FrmMain" )
                {                    
                    Control lbl = SubRoutine.FindControl( f, "LblPatientSearchResults" );
                    Label ctllbl = lbl as Label;

                    SubRtnMain.NavSetStyleClickSub( ctllbl );

                    //  set label LlbPatientSearch to not bold
                    lbl = SubRoutine.FindControl( f, "LlbPatientSearch" );
                    ctllbl = lbl as Label;
                    
                    ctllbl.Font = new Font( ctllbl.Font.Name, ctllbl.Font.SizeInPoints, FontStyle.Regular );
                }
            }
        }
    }
}
