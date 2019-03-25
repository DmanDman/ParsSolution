using System;
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
    public partial class FrmAddNew : Form
    {
        Helper helper = new Helper();

        SubRoutinesFrmAddNew SubRtn = new SubRoutinesFrmAddNew();

        FrmFilterAge fFilterAge = new FrmFilterAge();
        FrmFilterDate fFilterDate = new FrmFilterDate();

        public static class AddNewVar
        {
            public static int AddNewStep { get; set; }

            public static int PersonalType { get; set; }

            public static bool AgeChecked { get; set; }
            public static bool DobChecked { get; set; }

            public static string FilterDOB { get; set; }
            public static string FilterAge { get; set; }
        }


        #region AddNew Sub-Routines   

        private void SetEnableDisable( bool enable, bool eableSave )
        {
            TSMnuAddNewClear.Enabled = enable;
            GrpPersonal.Enabled = enable;
            GrpHome.Enabled = enable;
            GrpSurgery.Enabled = enable;

            if ( eableSave == true )
            {
                GrpSurgerySelected.Enabled = true;
            }
            else
            {
                GrpSurgerySelected.Enabled = false;
            }            
        }

        private void StopPanel_Flickering()
        {
            // Stop flickering
            StopPanel_FlickeringGroupBox( GrpPatient );
        }

        private void StopPanel_FlickeringGroupBox( GroupBox pnl )
        {
            typeof( GroupBox ).InvokeMember( "DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnl, new object[] { true });
        } 

        #endregion


        public FrmAddNew()
        {
            InitializeComponent();

            StopPanel_Flickering();

            AddNewVar.AddNewStep = 1;
        }

        private void FrmAddNew_Load(object sender, EventArgs e)
        {
            //  Hide Home and Surgery tabs
            TabPatient.TabPages.Remove( TabPatientHome );
            TabPatient.TabPages.Remove( TabPatientSurgery );
        }

        private void TSMnuAddNewCont_Click(object sender, EventArgs e)
        {
            switch ( AddNewVar.AddNewStep )
            {
                //  Show home tab
                case 1:
                    TabPatient.TabPages.Insert(0, TabPatientHome);
                    TabPatient.TabPages.Remove(TabPatientPersonal);

                    AddNewVar.AddNewStep = 2;

                    break;

                //  Show surgery tab
                case 2:
                    TabPatient.TabPages.Insert(0, TabPatientSurgery);
                    TabPatient.TabPages.Remove(TabPatientHome);

                    AddNewVar.AddNewStep = 3;

                    break;

                //  Show surgery items
                case 3:
                    SetEnableDisable( false, true );                    

                    GrpSurgerySelect.Location = new Point(
                                                    GrpPatient.Location.X,
                                                    GrpPatient.Location.Y);

                    GrpSurgerySelected.Location = new Point(
                                                      GrpHold.Location.X,
                                                      GrpHold.Location.Y);

                    GrpPatient.Visible = false;
                    GrpSurgerySelect.Visible = true;
                    GrpSurgerySelected.Visible = true;

                    AddNewVar.AddNewStep = 4;

                    break;

                //  Show save
                case 4:
                    SetEnableDisable( false, false );

                    TabPatient.TabPages.Remove(TabPatientSurgery);
                    TabPatient.TabPages.Insert(0, TabPatientPersonal);
                    TabPatient.TabPages.Insert(1, TabPatientHome);
                    TabPatient.TabPages.Insert(2, TabPatientSurgery);

                    TSMnuAddNewCont.Visible = false;
                    TSMnuAddNewSave.Visible = true;

                    GrpSurgerySelect.Location = new Point(
                                                    GrpSurgerySelectFromHold.Location.X,
                                                    GrpSurgerySelectFromHold.Location.Y);

                    GrpSurgerySelected.Location = new Point(
                                                      GrpSurgerySelectFromHold.Location.X,
                                                      GrpSurgerySelectFromHold.Location.Y);

                    GrpPatient.Visible = true;
                    GrpSurgerySelect.Visible = false;
                    GrpImages.Visible = true;
                    GrpDesc.Visible = true;
                    GrpSurgerySelected.Visible = true;

                    AddNewVar.AddNewStep = 5;

                    break;

                default:
                    Console.WriteLine("Default case");

                    break;
            }
        }

        private void TSMnuAddNewBack_Click(object sender, EventArgs e)
        {
            switch ( AddNewVar.AddNewStep )
            {
                //  Close
                case 1:

                    SAVEPICTONEW = false;

                    this.Close();

                    break;

                //  Show personal tab
                case 2:
                    SetEnableDisable( true, false );

                    TabPatient.TabPages.Insert(0, TabPatientPersonal);
                    TabPatient.TabPages.Remove(TabPatientHome);

                    AddNewVar.AddNewStep = 1;

                    break;

                //  Show home tab
                case 3:
                    SetEnableDisable( true, false );

                    TabPatient.TabPages.Remove(TabPatientSurgery);
                    TabPatient.TabPages.Insert(0, TabPatientHome);

                    AddNewVar.AddNewStep = 2;

                    break;

                //  Show patient surgery tab
                case 4:
                    SetEnableDisable( true, false );

                    GrpPatient.Visible = true;
                    GrpSurgerySelect.Visible = false;
                    GrpSurgerySelected.Visible = false;

                    AddNewVar.AddNewStep = 3;

                    break;

                //   Show surgery items
                case 5:
                    SetEnableDisable( false, true );

                    TabPatient.TabPages.Remove(TabPatientPersonal);
                    TabPatient.TabPages.Remove(TabPatientHome);
                    TabPatient.TabPages.Remove(TabPatientSurgery);
                    TabPatient.TabPages.Insert(0, TabPatientSurgery);

                    TSMnuAddNewCont.Visible = true;
                    TSMnuAddNewSave.Visible = false;

                    GrpSurgerySelect.Location = new Point(
                                                    GrpPatient.Location.X,
                                                    GrpPatient.Location.Y);

                    GrpSurgerySelected.Location = new Point(
                                                      GrpHold.Location.X,
                                                      GrpHold.Location.Y);

                    GrpPatient.Visible = false;
                    GrpSurgerySelect.Visible = true;
                    GrpImages.Visible = false;
                    GrpDesc.Visible = false;
                    GrpSurgerySelected.Visible = true;

                    AddNewVar.AddNewStep = 4;

                    break;

                default:
                    Console.WriteLine("Default case");

                    break;
            }
        }

        private void TSMnuAddNewSave_Click(object sender, EventArgs e)
        {
            SAVEPICTONEW = true;

            this.Close();
        }

        private void TSMnuAddNewClear_Click(object sender, EventArgs e)
        {
            //  set the tab number
            int ClearTab = AddNewVar.AddNewStep;           

            switch ( ClearTab )
            {
                //  personal info tab
                case 1:
                    SubRtn.ClearPersonal( this );

                    break;

                //  home tab
                case 2:
                    SubRtn.ClearHome( this );

                    break;

                //  surgery tab
                case 3:
                    SubRtn.ClearSurgery( this );

                    break;

                default:

                    break;
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
                    TxtDob.Text = AddNewVar.FilterDOB;
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

        private void ChkDOB_CheckedChanged(object sender, EventArgs e)
        {
            if ( ChkDOB.Checked == true )
            {
                AddNewVar.PersonalType = 1;
                AddNewVar.DobChecked = true;
            }
            else
            {
                TxtDob.Text = "";
                TxtDob.Height = 22;
                AddNewVar.FilterDOB = "";
                AddNewVar.DobChecked = false;
            }
        }

        private void ChkAge_CheckedChanged(object sender, EventArgs e)
        {
            if ( ChkAge.Checked == true )
            {
                AddNewVar.PersonalType = 1;
                AddNewVar.AgeChecked = true;
            }
            else
            {
                TxtAge.Text = "";
                AddNewVar.FilterAge = "";
                AddNewVar.AgeChecked = false;
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
                    TxtAge.Text = AddNewVar.FilterAge;
                }
            }
        }

        private void LstDrFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstDrFilter, LstDr );
        }

        private void LstDr_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstDr, LstDrFilter );
        }

        private void LstHospitalFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstHospitalFilter, LstHospital );
        }

        private void LstHospital_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstHospital, LstHospitalFilter );
        }

        private void LstLocationFIlter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstLocationFIlter, LstLocation );
        }

        private void LstLocation_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstLocation, LstLocationFIlter );
        }

        private void LstLevelFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstLevelFilter, LstLevel );
        }

        private void LstLevel_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstLevel, LstLevelFilter );
        }

        private void LstCptFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstCptFilter, LstCpt );
        }

        private void LstCpt_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstCpt, LstCptFilter );
        }

        private void LstDxFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstDxFilter, LstDx );
        }

        private void LstDx_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstDx, LstDxFilter );
        }

        private void LstSurgeryFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstSurgeryFilter, LstSurgery );
        }

        private void LstSurgery_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstSurgery, LstSurgeryFilter );
        }

        private void LstInstFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstInstFilter, LstInst );
        }

        private void LstInst_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstInst, LstInstFilter );
        }

        private void LstCompFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstCompFilter, LstComp );
        }

        private void LstComp_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstComp, LstCompFilter );
        }

        private void LstPicInfoFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstPicInfoFilter, LstPicInfo );
        }

        private void LstPicInfo_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstPicInfo, LstPicInfoFilter );
        }
    }

    public class SubRoutinesFrmAddNew
    {
        Helper helper = new Helper();

        public void ClearPersonal( Form frm )
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
            txt = SubRoutine.FindControl( frm, "TxtPatNum" );
            ctltxt = txt as TextBox;

            helper.ClearTextBox( ctltxt );

            //  Clear patient number
            txt = SubRoutine.FindControl( frm, "TxtPatNum" );
            ctltxt = txt as TextBox;

            helper.ClearTextBox(ctltxt);

            //  Clear DOB
            Control chk = SubRoutine.FindControl( frm, "ChkDOB" );
            CheckBox ctlchk = chk as CheckBox;

            helper.ClearCheckBox( ctlchk );

            //  Clear Age
            chk = SubRoutine.FindControl( frm, "ChkAge" );
            ctlchk = chk as CheckBox;

            helper.ClearCheckBox( ctlchk );

            //  Clear male
            Control rdo = SubRoutine.FindControl( frm, "RdoMale" );
            RadioButton ctlrdo = rdo as RadioButton;

            helper.ClearRadioBtn( ctlrdo );

            //  Clear female
            rdo = SubRoutine.FindControl( frm, "RdoFemale" );
            ctlrdo = rdo as RadioButton;

            helper.ClearRadioBtn( ctlrdo );

            //  Clear SSN
            Control mtxt = SubRoutine.FindControl( frm, "MTxtssn" );
            MaskedTextBox ctrlmtxt = mtxt as MaskedTextBox;

            helper.ClearMaskedTextBox( ctrlmtxt );
        }

        public void ClearHome( Form frm )
        {
            //  Clear address 1
            Control txt = SubRoutine.FindControl( frm, "TxtAddress1" );
            TextBox ctltxt = txt as TextBox;

            helper.ClearTextBox( ctltxt );

            //  Clear address 2
            txt = SubRoutine.FindControl( frm, "TxtAddress2" );
            ctltxt = txt as TextBox;

            helper.ClearTextBox( ctltxt );

            //  Clear city
            txt = SubRoutine.FindControl( frm, "TxtCity" );
            ctltxt = txt as TextBox;

            helper.ClearTextBox( ctltxt );

            //  Clear state
            Control cbo = SubRoutine.FindControl( frm, "CboState" );
            ComboBox ctlcbo = cbo as ComboBox;

            helper.ClearComboBoxTxt( ctlcbo );

            //  Clear zip
            Control mtxt = SubRoutine.FindControl( frm, "MTxtZip" );
            MaskedTextBox ctrlmtxt = mtxt as MaskedTextBox;

            helper.ClearMaskedTextBox( ctrlmtxt );

            //  Clear phone
            mtxt = SubRoutine.FindControl( frm, "MTxtPhone" );
            ctrlmtxt = mtxt as MaskedTextBox;

            helper.ClearMaskedTextBox( ctrlmtxt );

            //  Clear cell
            mtxt = SubRoutine.FindControl( frm, "MTxtCell" );
            ctrlmtxt = mtxt as MaskedTextBox;

            helper.ClearMaskedTextBox( ctrlmtxt );
        }

        public void ClearSurgery( Form frm )
        {
            //  surgery date
            Control dt = SubRoutine.FindControl( frm, "DtSurgeryDate" );
            DateTimePicker ctldt = dt as DateTimePicker;

            helper.SetDateToToday( ctldt );

            //  fiscal year
            dt = SubRoutine.FindControl( frm, "DtFiscalYear" );
            ctldt = dt as DateTimePicker;

            helper.SetDateToToday( ctldt );
        }

    }
 }
