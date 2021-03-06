﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using static ParsDashboard.Globals;

namespace ParsDashboard
{
    public partial class FrmAddExisting : Form
    {
        SubRoutinesFrmAddExisting SubRtn = new SubRoutinesFrmAddExisting();

        FormNav fNav = new FormNav();

        FrmFilterDate fFilterDate = new FrmFilterDate();

        public static class AddExistingVar
        {
            //  1 - Clear Personal Info
            //  2 - Clear Home Info
            public static int ClearType { get; set; }
            public static int PersonalType { get; set; }

            public static bool DobChecked { get; set; }
            public static bool SurgeryDateChecked { get; set; }

            public static string FilterDOB { get; set; }

            public static string FilterSurgeryDate { get; set; }
        }

        public FrmAddExisting()
        {
            InitializeComponent();
        }

        private void FrmAddExisting_FormClosing(object sender, FormClosingEventArgs e)
        {
            ////  save pics to existing patient
            //if ( AddExistingVar.SavePics == true )
            //{
            //    //fNav.ShowFormName( Form.FrmImageSearchResults, "FrmImageSearchResults" );

            //    fNav.ShowFormName( fImageSearchResuts.MdiParent.MdiChildren, "FrmImageSearchResults" );
            //}
        }

        private void FrmAddExisting_Load(object sender, EventArgs e)
        {

        }

        private void TSMnuAddEmailImagesClearSearch_Click(object sender, EventArgs e)
        {
            //  set the tab number
            int ClearTab = AddExistingVar.ClearType;

            //  clear the selected tab
            SubRtn.ClearSearch( this, ClearTab );
        }

        private void TabSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddExistingVar.ClearType = TabSearch.SelectedIndex;
        }

        private void TSMnuAddEmailImagesBack_Click(object sender, EventArgs e)
        {           
            SAVEPICTOEXISTING = false;

            this.Close();
        }

        private void TSMnuAddEmailImageSave_Click(object sender, EventArgs e)
        {           
            SAVEPICTOEXISTING = true;

            this.Close();
        }

        private void ChkSurgeryDate_CheckedChanged(object sender, EventArgs e)
        {
            if ( ChkSurgeryDate.Checked == true )
            {
                AddExistingVar.PersonalType = 1;
                AddExistingVar.SurgeryDateChecked = true;
            }
            else
            {
                TxtDob.Text = "";
                TxtDob.Height = 22;
                AddExistingVar.FilterDOB = "";
                AddExistingVar.SurgeryDateChecked = false;
            }
        }

        private void ChkSurgeryDate_Click(object sender, EventArgs e)
        {
            if ( ChkSurgeryDate.Checked )
            {
                SURGERYDATE = false;
                FORMLOADED = Tag.ToString();

                fFilterDate.ShowDialog();

                FORMLOADED = "";

                if ( SURGERYDATE == true )
                {
                    ChkSurgeryDate.Checked = false;
                }
                else
                {
                    TxtDob.Text = AddExistingVar.FilterSurgeryDate;
                }

                if ( TxtDob.Text.Contains("Between") )
                {
                    TxtDob.Height = 32;
                }
                else
                {
                    TxtDob.Height = 22;
                }
            }
        }
    }

    public class SubRoutinesFrmAddExisting
    {
        Helper helper = new Helper();     

        public void ClearSearch( Form frm, int ClearTab )
        {
            //  Clear personal tab
            if ( ClearTab == 0 )
            { 
                //  Clear last name
                Control txt = SubRoutine.FindControl( frm, "TxtLastName" );
                TextBox ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  Clear first name
                txt = SubRoutine.FindControl( frm, "TxtFirstName" );
                ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  Clear patient number 
                txt = SubRoutine.FindControl( frm, "TxtPatientNum" );
                ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  Clear surgery date 
                txt = SubRoutine.FindControl( frm, "TxtSurgeryDate" );
                ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  Clear surgery date check box
                Control chk = SubRoutine.FindControl( frm, "ChkSurgeryDate" );
                CheckBox ctlchk = chk as CheckBox;

                helper.ClearCheckBox( ctlchk );

                //  Clear date of birth 
                txt = SubRoutine.FindControl( frm, "TxtDob" );
                ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  Clear date of birth check box
                chk = SubRoutine.FindControl( frm, "ChkDOB" );
                ctlchk = chk as CheckBox;

                helper.ClearCheckBox( ctlchk );

                //  Clear age 
                txt = SubRoutine.FindControl( frm, "TxtAge" );
                ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  Clear age check box
                chk = SubRoutine.FindControl( frm, "ChkAge" );
                ctlchk = chk as CheckBox;

                helper.ClearCheckBox( ctlchk );

                //  Clear radio button male
                Control rdo = SubRoutine.FindControl( frm, "RdoMale" );
                RadioButton ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn( ctlrdo );

                //  Clear radio button female
                rdo = SubRoutine.FindControl( frm, "RdoFemale" );
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn( ctlrdo );

                //  Clear SSN                
                Control mtxt = SubRoutine.FindControl( frm, "MTxtssn");
                MaskedTextBox ctrlmtxt = mtxt as MaskedTextBox;

                helper.ClearMaskedTextBox( ctrlmtxt );

            }

            //  Clear home tab
            if ( ClearTab == 1 )
            {
                //  Address 1
                Control txt = SubRoutine.FindControl( frm, "TxtAddress1" );
                TextBox ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  Address 2
                txt = SubRoutine.FindControl( frm, "TxtAddress2" );
                ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  City
                txt = SubRoutine.FindControl( frm, "TxtCity" );
                ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  State
                Control cbo = SubRoutine.FindControl( frm, "CboState" );
                ComboBox ctlcbo = cbo as ComboBox;

                helper.ClearComboBoxTxt( ctlcbo );

                //  Zip
                txt = SubRoutine.FindControl( frm, "TxtZip" );
                ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  Phone
                txt = SubRoutine.FindControl( frm, "TxtPhone" );
                ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );

                //  Cell
                txt = SubRoutine.FindControl( frm, "TxtCell" );
                ctltxt = txt as TextBox;

                helper.ClearTextBox( ctltxt );
            }
        }
    }
}
