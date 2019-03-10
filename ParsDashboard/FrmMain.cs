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
    public partial class FrmMain : Form
    {
        #region Define Forms
        //  define forms
        FormNav fNav = new FormNav();       

        //  Images
        FrmImages fImage = new FrmImages();
        FrmImageSearch fImageSearch = new FrmImageSearch();
        public FrmImageSearchResults fImageSearchResuts = new FrmImageSearchResults();
        FrmImageFilter fImageFilter = new FrmImageFilter();

        //  Patient
        FrmPatient fPatient = new FrmPatient();
        public FrmPatientSearch fPatientSearch = new FrmPatientSearch();

        //  Surgery
        FrmSurgery fSurgery = new FrmSurgery();
        public FrmSurgerySearch fSurgerySearch = new FrmSurgerySearch();

        //  Reports
        FrmRptStatic fRptStatic = new FrmRptStatic();
        FrmRptDynamic fRptDynamic = new FrmRptDynamic();

        //  Data
        FrmDataCustomizeName fDataCustName = new FrmDataCustomizeName();
        FrmDataDefaultHosp fDataDefaultHosp = new FrmDataDefaultHosp();
        FrmDataLink fDataLink = new FrmDataLink();
        FrmDataPicInfo fDataPicInfo = new FrmDataPicInfo();

        //  Meta Data
        FrmMD fMD = new FrmMD();

        //  Emailed Pics
        FrmPicOnly fPicOnly = new FrmPicOnly();

        //  Secrity
        FrmSecurity fSecurity = new FrmSecurity();

        FrmDashboard fDashBoard = new FrmDashboard();

        #endregion

        #region Define Helper Classes    
        //  define helper class
        Helper_MouseMove HelpMouseMove = new Helper_MouseMove();

        Helper helper = new Helper();

        SubRoutine SubRtn = new SubRoutine();
        #endregion


        #region Form Sub-Routines               

        public void NavSetStyleClick(Label lbl)
        {
            Label lblClick = lbl;

            //  Dashboard Panel            
            LblDashboard.Font = NavSetStyleLbl( LblDashboard );

            //  Images Panel            
            LblImages.Font = NavSetStyleLbl( LblImages );
            LblImagesAdd.Font = NavSetStyleLbl( LblImagesAdd );            
            LblImagesSearch.Font = NavSetStyleLbl( LblImagesSearch );
            LblImagesFilter.Font = NavSetStyleLbl( LblImagesFilter );
            LblImagesSearchResults.Font = NavSetStyleLbl( LblImagesSearchResults );            

            //  Patient Panel
            LblPatient.Font = NavSetStyleLbl(LblPatient);
            LblPatientAdd.Font = NavSetStyleLbl(LblPatientAdd);
            LlbPatientSearch.Font = NavSetStyleLbl(LlbPatientSearch);
            LblPatientFilter.Font = NavSetStyleLbl(LblPatientFilter);
            LblPatientSearchResults.Font = NavSetStyleLbl(LblPatientSearchResults);           

            //  Surgery Panel
            LblSurgery.Font = NavSetStyleLbl(LblSurgery);
            LblSurgeryAdd.Font = NavSetStyleLbl(LblSurgeryAdd);
            LblSurgerySearch.Font = NavSetStyleLbl(LblSurgerySearch);

            //  Report Panel
            LblRpt.Font = NavSetStyleLbl( LblRpt );
            LblRptStatic.Font = NavSetStyleLbl( LblRptStatic );
            LblRptDynamic.Font = NavSetStyleLbl( LblRptDynamic );

            //  Data Panel
            LblData.Font = NavSetStyleLbl(LblData);
            LblDataCustomizeName.Font = NavSetStyleLbl(LblDataCustomizeName);
            LblDataDefaultHosp.Font = NavSetStyleLbl(LblDataDefaultHosp);
            LblDataLink.Font = NavSetStyleLbl(LblDataLink);
            LblDataPicInfo.Font = NavSetStyleLbl(LblDataPicInfo);

            //  Meta Data Panel
            LblMetaData.Font = NavSetStyleLbl(LblMetaData);
            LblMDComp.Font = NavSetStyleLbl(LblMDComp);
            LblMDCpt.Font = NavSetStyleLbl(LblMDCpt);
            LblMDImageDesc.Font = NavSetStyleLbl(LblMDImageDesc);
            LblMDDx.Font = NavSetStyleLbl(LblMDDx);
            LblMDDr.Font = NavSetStyleLbl(LblMDDr);
            LblMDFiscalYr.Font = NavSetStyleLbl(LblMDFiscalYr);
            LblMDHospital.Font = NavSetStyleLbl(LblMDHospital);
            LblMDInst.Font = NavSetStyleLbl(LblMDLevel);
            LblMDLevel.Font = NavSetStyleLbl(LblMDInst);
            LblMDLocation.Font = NavSetStyleLbl(LblMDLocation);
            LblMDSurgery.Font = NavSetStyleLbl(LblMDSurgery);

            //  Security Panel
            LblSecurity.Font = NavSetStyleLbl( LblSecurity );
            LblSecurityUserMgmt.Font = NavSetStyleLbl( LblSecurityUserMgmt );

            //  Set font bold
            if ( lblClick.Font.Bold != true )
            {
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Bold);
            }
            else
            {

            }
        }

        public static Font NavSetStyleLbl( Label lbl )
        {
            lbl.Font = new Font( lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Regular );
            return lbl.Font;
        }

        private void SetPanel_Height()
        {
            PnlDashboard.Height = 25;
            PnlImages.Height = 25;
            PnlPatient.Height = 25;
            PnlSurgery.Height = 25;
            PnlRpt.Height = 25;
            PnlData.Height = 25;
            PnlMetaData.Height = 25;
            PnlEmailPic.Height = 25;
            PnlSecurity.Height = 25;

            //Label1Dash.Image = Properties.Resources.Expander_Collapsed16; // use your down arrow image
            //Label2.Image = Properties.Resources.Expander_Collapsed16; // use your down arrow image
            //Label3.Image = Properties.Resources.Expander_Collapsed16; // use your down arrow image
        }

        private void StopPanel_Flickering()
        {
            // Stop flickering for panels

            StopPanel_FlickeringPanel( tableLayoutPanel1 );
            StopPanel_FlickeringPanel( PnlDashboard );
            StopPanel_FlickeringPanel( PnlImages );
            StopPanel_FlickeringPanel( PnlPatient );
            StopPanel_FlickeringPanel( PnlSurgery );
            StopPanel_FlickeringPanel( PnlRpt );
            StopPanel_FlickeringPanel( PnlData );
            StopPanel_FlickeringPanel( PnlMetaData );
            StopPanel_FlickeringPanel( PnlEmailPic );
            StopPanel_FlickeringPanel( PnlSecurity );
        }

        private void StopPanel_FlickeringPanel(Panel pnl)
        {
            typeof( Panel ).InvokeMember( "DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnl, new object[] { true } );
        }
        #endregion


        public FrmMain()
        {
            InitializeComponent();
            StopPanel_Flickering();

            SubRtn.Load_All_Forms( fPatient, this );
            SubRtn.Load_All_Forms( fPatientSearch, this );

            SubRtn.Load_All_Forms( fImage, this );
            SubRtn.Load_All_Forms( fImageSearch, this );
            SubRtn.Load_All_Forms( fImageSearchResuts, this );
            SubRtn.Load_All_Forms( fImageFilter, this );

            SubRtn.Load_All_Forms( fSurgery, this );
            SubRtn.Load_All_Forms( fSurgerySearch, this );

            SubRtn.Load_All_Forms( fRptStatic, this );
            SubRtn.Load_All_Forms( fRptDynamic, this );

            SubRtn.Load_All_Forms( fDataCustName, this );
            SubRtn.Load_All_Forms( fDataDefaultHosp, this) ;
            SubRtn.Load_All_Forms( fDataLink, this );
            SubRtn.Load_All_Forms( fDataPicInfo, this );

            SubRtn.Load_All_Forms( fMD, this );

            SubRtn.Load_All_Forms( fPicOnly, this );

            SubRtn.Load_All_Forms( fSecurity, this );

            SubRtn.Load_All_Forms( fDashBoard, this );

            //fDashBoard.Refresh();

            LblDashboard.Click += new EventHandler( LblDashboard_Click );
            
        }

        private void LblPatient_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fPatient);

            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);

            NavSetStyleClick( LblPatient );          
        }

        private void LblSurgery_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fSurgery);

            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );            

            NavSetStyleClick( LblSurgery );
        }

        private void LblRpt_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );

            NavSetStyleClick( LblRpt );
        }

        private void LblData_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fDataCustName);

            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );            

            NavSetStyleClick( LblDataCustomizeName );                       
        }

        private void LblMetaData_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fMD);

            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );            
            
            SubRtn.NavSetStyleClickSub( LblMDComp ) ;

            SubRtn.ShowHideMD( fMD, "GrpComp" );
        }

        private void LblEmailPic_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fPicOnly);
           
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );
            
            NavSetStyleClick( LblEmailPicPicOnly );
        }

        private void LblSecurity_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fSecurity);

            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );

            NavSetStyleClick( LblSecurity );

            SubRtn.ShowHideSecurity( fSecurity, "GrpCurrentUser");

            SubRtn.ShowHideSecurity( fSecurity, "GrpAllUsers");            

            //  Show security menu
            Control mnu = SubRoutine.FindControl( fSecurity, "MnuSecurity" );
            MenuStrip ctlmnu = mnu as MenuStrip;

            helper.ShowControl( ctlmnu );

            //  Hide security user mgmet menu
            mnu = SubRoutine.FindControl( fSecurity, "MnuSecurityUserMgmt" );
            ctlmnu = mnu as MenuStrip;

            helper.HideControl( ctlmnu );            
        }

        public void LblDashboard_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fDashBoard);          

            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);

            NavSetStyleClick(LblDashboard);                
        }

        private void LblImagesAdd_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblImagesAdd);
        }

        private void LblImagesAdd_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblImagesAdd);
        }

        private void LblImagesAdd_Click(object sender, EventArgs e)
        {
            DlgImagesAdd.ShowDialog();
        }

        private void LblImagesSearch_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fImageSearch);

            NavSetStyleClick(LblImagesSearch);           
        }

        private void LblDashboard_MouseEnter(object sender, EventArgs e)
        {
            if (LblDashboard.Font.Bold != true)
            {
                LblDashboard.Font = new Font(LblDashboard.Font.Name, LblDashboard.Font.SizeInPoints, FontStyle.Underline);
            }
        }

        private void LblDashboard_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblDashboard);
        }

        private void LblImagesSearch_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblImagesSearch);
        }

        private void LblImagesSearch_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblImagesSearch);
        }

        private void LlbImages_MouseEnter(object sender, EventArgs e)
        {
            LblImages.Font = new Font(LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LlbImages_MouseLeave(object sender, EventArgs e)
        {
            LblImages.Font = new Font(LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Regular);
        }

        private void LblImages_Click(object sender, EventArgs e)
        {
            fNav.ShowForm( fImage );

            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );          

            NavSetStyleClick( LblImages );            
        }

        private void LblImages_MouseEnter(object sender, EventArgs e)
        {
            if (LblImages.Font.Bold != true)
            {
                LblImages.Font = new Font(LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Underline);
            }
        }

        private void LblImages_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblImages);
        }

        private void LblPatient_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblPatient);
        }

        private void LblPatient_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblPatient);
        }

        private void LblPatientAdd_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);

            // TODO create patinet add form; add it here
            //fNav.ShowForm(  );

            NavSetStyleClick(LblPatientAdd);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetPanel_Height();

            // Enable double duffering to stop flickering.
            this.SetStyle( ControlStyles.DoubleBuffer, true );
            this.SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            this.SetStyle( ControlStyles.UserPaint, true );
            this.SetStyle( ControlStyles.SupportsTransparentBackColor, false );
            this.SetStyle( ControlStyles.Opaque, false );
            this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            this.SetStyle( ControlStyles.ResizeRedraw, true );
        }

        private void LblImagesFilter_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblImagesFilter);
        }

        private void LblImagesSearchResults_MouseEnter(object sender, EventArgs e)
        {
           
        }       

        private void LblPatientAdd_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblPatientAdd);
        }

        private void LlbPatientSearch_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LlbPatientSearch);
        }

        private void LblPatientFilter_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblPatientFilter);
        }

        private void LblPatientSearchResults_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void LblPatientSearchToImage_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void LblSurgery_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblSurgery);
        }

        private void LblSurgeryAdd_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblSurgeryAdd);
        }

        private void LblSurgerySearch_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblSurgerySearch);
        }

        private void LblImagesFilter_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblImagesFilter);
        }

        private void LblImagesSearchResults_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void LblPatientAdd_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblPatientAdd);
        }

        private void LlbPatientSearch_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LlbPatientSearch);
        }

        private void LblPatientFilter_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblPatientFilter);
        }

        private void LblPatientSearchResults_MouseLeave(object sender, EventArgs e)
        {
            //HelpMouseMove.MouseLeave(LblPatientSearchResults);
        }

        private void LblPatientSearchToImage_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void LblSurgery_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblSurgery);
        }

        private void LblSurgeryAdd_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblSurgeryAdd);
        }

        private void LblSurgerySearch_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblSurgerySearch);
        }

        private void LblImagesFilter_Click(object sender, EventArgs e)
        {
            fNav.ShowForm( fImageFilter );

            NavSetStyleClick( LblImagesFilter );            
        }

        public void LblImagesSearchResults_Click(object sender, EventArgs e)
        {            
            //NavSetStyleClick(LblImagesSearchResults);
        }
       
        private void LlbPatientSearch_Click(object sender, EventArgs e)
        {
            fNav.ShowForm( fPatientSearch );

            NavSetStyleClick( LlbPatientSearch );
        }

        private void LblPatientFilter_Click(object sender, EventArgs e)
        {
            //fNav.ShowForm( X );

            NavSetStyleClick( LblPatientFilter );
        }

        private void TSMnuSearch_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fImageSearchResuts);

            NavSetStyleClick(LblImagesSearchResults);

            SubRtn.ShowHideMenu(this, MnuImageSearchResult.Name);
        }

        private void TSMnuAddMeta_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl(fImageSearch, "CboMetaSearch");
            Control lst = SubRoutine.FindControl(fImageSearch, "LstMetaDataSearchTerms");

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.AddListBoxData( ctlCbo, ctlLst );
        }

        private void TSMnuRemoveMeta_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl(fImageSearch, "CboMetaSearch");
            Control lst = SubRoutine.FindControl(fImageSearch, "LstMetaDataSearchTerms");

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.AddComboBox(ctlCbo, ctlLst);
        }

        private void TSMnuAddInfo_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl(fImageSearch, "CboPicInfo");
            Control lst = SubRoutine.FindControl(fImageSearch, "LstPicInfoSearchItems");

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.AddListBoxData(ctlCbo, ctlLst);
        }

        private void TSMnuRemoveInfo_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl(fImageSearch, "CboPicInfo");
            Control lst = SubRoutine.FindControl(fImageSearch, "LstPicInfoSearchItems");

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.AddComboBox(ctlCbo, ctlLst);
        }

        private void TSMnuRemoveAllMeta_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl(fImageSearch, "CboMetaSearch");
            Control lst = SubRoutine.FindControl(fImageSearch, "LstMetaDataSearchTerms");

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.RemoveAllListBox(ctlCbo, ctlLst);
        }

        private void TsMnuRemoveAllPic_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl(fImageSearch, "CboPicInfo");
            Control lst = SubRoutine.FindControl(fImageSearch, "LstPicInfoSearchItems");

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.RemoveAllListBox(ctlCbo, ctlLst);
        }

        private void LblPatientSearchToImage_Click(object sender, EventArgs e)
        {
         
        }

        private void LblPatientSearchResults_Click(object sender, EventArgs e)
        {
            //NavSetStyleClick( LblPatientSearchResults );
        }

        private void TSMnuFilterClearChecks_Click(object sender, EventArgs e)
        {
            Control gb = SubRoutine.FindControl(fImageFilter, "GrpBoxPersonal");
            GroupBox ctlGb = gb as GroupBox;

            helper.ClearAllCheckBoxes(ctlGb);
        }

        private void TSMnuFilterClearSurgery_Click(object sender, EventArgs e)
        {
            //  clear doctor
            Control lbFrom = SubRoutine.FindControl(fImageFilter, "LstDr");
            ListBox ctllbFrom = lbFrom as ListBox;

            Control lbTo = SubRoutine.FindControl(fImageFilter, "LstDrFilter");
            ListBox ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes(ctllbFrom, ctllbTo);


            //  clear hospital
            lbFrom = SubRoutine.FindControl(fImageFilter, "LstHospital");
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl(fImageFilter, "LstHospitalFilter");
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes(ctllbFrom, ctllbTo);


            //  clear location
            lbFrom = SubRoutine.FindControl(fImageFilter, "LstLocation");
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl(fImageFilter, "LstLocationFIlter");
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes(ctllbFrom, ctllbTo);


            //  clear level
            lbFrom = SubRoutine.FindControl(fImageFilter, "LstLevel");
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl(fImageFilter, "LstLevelFilter");
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes(ctllbFrom, ctllbTo);


            //  clear cpt
            lbFrom = SubRoutine.FindControl(fImageFilter, "LstCpt");
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl(fImageFilter, "LstCptFilter");
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes(ctllbFrom, ctllbTo);


            //  clear dx
            lbFrom = SubRoutine.FindControl(fImageFilter, "LstDx");
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl(fImageFilter, "LstDxFilter");
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes(ctllbFrom, ctllbTo);


            //  clear surgery
            lbFrom = SubRoutine.FindControl(fImageFilter, "LstSurgery");
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl(fImageFilter, "LstSurgeryFilter");
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes(ctllbFrom, ctllbTo);


            //  clear instrumentation
            lbFrom = SubRoutine.FindControl(fImageFilter, "LstInst");
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl(fImageFilter, "LstInstFilter");
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes(ctllbFrom, ctllbTo);


            //  clear complication
            lbFrom = SubRoutine.FindControl(fImageFilter, "LstComp");
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl(fImageFilter, "LstCompFilter");
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes(ctllbFrom, ctllbTo);


            //  clear pic info
            lbFrom = SubRoutine.FindControl(fImageFilter, "LstPicInfo");
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl(fImageFilter, "LstPicInfoFilter");
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes(ctllbFrom, ctllbTo);
        }

        private void TSMnuPatientClear_Click(object sender, EventArgs e)
        {
            if (FrmPatient.PatientVar.ClearType == 0)
            {
                Control updwn = SubRoutine.FindControl(fPatient, "UpDwnLastNameLetter");
                DomainUpDown ctlupdwn = updwn as DomainUpDown;

                helper.ClearUpDwn(ctlupdwn);

                Control cbo = SubRoutine.FindControl(fPatient, "CboFullName");
                ComboBox ctlcbo = cbo as ComboBox;

                helper.ClearComboBox(ctlcbo);
            }

            if (FrmPatient.PatientVar.ClearType == 1)
            {
                Control updwn = SubRoutine.FindControl(fPatient, "UpDwnYear");
                DomainUpDown ctlupdwn = updwn as DomainUpDown;

                helper.ClearUpDwn(ctlupdwn);

                updwn = SubRoutine.FindControl(fPatient, "UpDwnMonth");
                ctlupdwn = updwn as DomainUpDown;

                helper.ClearUpDwn(ctlupdwn);
            }
        }

        private void TSMnuPatientSrchClear_Click(object sender, EventArgs e)
        {
            //  clear personal information
            if (FrmPatientSearch.PatientSearchVar.ClearType == 0)
            {
                Control txt = SubRoutine.FindControl(fPatientSearch, "TxtLastName");
                TextBox ctltxt = txt as TextBox;

                helper.ClearTextBox(ctltxt);

                txt = SubRoutine.FindControl(fPatientSearch, "TxtFirstName");
                ctltxt = txt as TextBox;

                helper.ClearTextBox(ctltxt);

                txt = SubRoutine.FindControl(fPatientSearch, "TxtPatientNum");
                ctltxt = txt as TextBox;

                helper.ClearTextBox(ctltxt);

                Control chk = SubRoutine.FindControl(fPatientSearch, "ChkSurgeryDate");
                CheckBox ctlchk = chk as CheckBox;

                helper.ClearCheckBox(ctlchk);

                chk = SubRoutine.FindControl(fPatientSearch, "ChkDOB");
                ctlchk = chk as CheckBox;

                helper.ClearCheckBox(ctlchk);

                chk = SubRoutine.FindControl(fPatientSearch, "ChkAge");
                ctlchk = chk as CheckBox;

                helper.ClearCheckBox(ctlchk);

                Control rdo = SubRoutine.FindControl(fPatientSearch, "RdoMale");
                RadioButton ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);

                rdo = SubRoutine.FindControl(fPatientSearch, "RdoFemale");
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);               
            }

            //  clear home information
            if (FrmPatientSearch.PatientSearchVar.ClearType == 1)
            {
                Control txt = SubRoutine.FindControl(fPatientSearch, "TxtAddress1");
                TextBox ctltxt = txt as TextBox;

                helper.ClearTextBox(ctltxt);

                txt = SubRoutine.FindControl(fPatientSearch, "TxtAddress2");
                ctltxt = txt as TextBox;

                helper.ClearTextBox(ctltxt);

                txt = SubRoutine.FindControl(fPatientSearch, "TxtCity");
                ctltxt = txt as TextBox;

                helper.ClearTextBox(ctltxt);

                Control cbo = SubRoutine.FindControl(fPatientSearch, "CboState");
                ComboBox ctlcbo = cbo as ComboBox;

                helper.ClearComboBoxTxt(ctlcbo);               
            }
        }

        private void TSMnuPatientSrchSearch_Click(object sender, EventArgs e)
        {            
            fNav.ShowForm(fImageSearchResuts);

            SubRtn.DashboardAccordian(LblImages, e, tableLayoutPanel1);

            NavSetStyleClick(LblImagesSearchResults);            
        }

        private void LblSurgeryAdd_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblSurgeryAdd );
        }

        private void LblSurgerySearch_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblSurgerySearch );

            fNav.ShowForm( fSurgerySearch );            
        }

        private void TSMnuSurgerySrchClearSurgery_Click(object sender, EventArgs e)
        {
            //  clear surgery dates
            SubRtn.ClearSurgeryDates(fSurgerySearch);

            //  clear fiscal year
            SubRtn.ClearFiscalYear(fSurgerySearch);
        }

        private void TSMnuSurgerySrchClearItems_Click(object sender, EventArgs e)
        {
            //  clear search items
            SubRtn.ClearItems(fSurgerySearch);
        }

        private void TSMnuSurgerySrchClearAll_Click(object sender, EventArgs e)
        {
            //  clear surgery dates
            SubRtn.ClearSurgeryDates(fSurgerySearch);

            //  clear fiscal year
            SubRtn.ClearFiscalYear(fSurgerySearch);

            //  clear search items
            SubRtn.ClearItems(fSurgerySearch);
        }

        private void TSMnuSurgeryClear_Click(object sender, EventArgs e)
        {
            //  clear surgery type
            SubRtn.SurgeryClearType(fSurgery);
        }

        private void LblDataCustomizeName_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblDataCustomizeName );

            fNav.ShowForm( fDataCustName );            
        }

        private void LblData_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblData ) ;
        }

        private void LblData_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblData );
        }

        private void TSMnuDataCustNameClearAll_Click(object sender, EventArgs e)
        {
            SubRtn.ClearDataCustomizeNames( fDataCustName );
        }

        private void LblDataDefaultHosp_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblDataDefaultHosp );
        }

        private void LblDataDefaultHosp_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblDataDefaultHosp );
        }

        private void LblDataLink_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblDataLink );
        }

        private void LblDataLink_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblDataLink );
        }

        private void LblDataPicInfo_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblDataPicInfo );
        }

        private void LblDataPicInfo_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblDataPicInfo );
        }

        private void LblDataDefaultHosp_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblDataDefaultHosp );

            fNav.ShowForm( fDataDefaultHosp );            
        }

        private void LblDataCustomizeName_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblDataCustomizeName );
        }

        private void LblDataCustomizeName_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblDataCustomizeName );
        }

        private void LblDataLink_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblDataLink );

            fNav.ShowForm( fDataLink );            
        }

        public void TSMnuDataLinkClearFrom_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl(fDataLink, "CboLinkFromType");
            ComboBox ctlcbo = cbo as ComboBox;

            helper.ClearComboBoxTxt(ctlcbo);

            cbo = SubRoutine.FindControl(fDataLink, "CboLinkFromDetail");
            ctlcbo = cbo as ComboBox;

            helper.ClearComboBox(ctlcbo);
        }

        public void TSMnuDataLinkClearTo_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl( fDataLink, "CboLinkToType" );
            ComboBox ctlcbo = cbo as ComboBox;

            helper.ClearComboBoxTxt( ctlcbo );

            cbo = SubRoutine.FindControl( fDataLink, "CboLinkToDetail" );
            ctlcbo = cbo as ComboBox;

            helper.ClearComboBox( ctlcbo );
        }

        private void TSMnuDataLinkClearAll_Click(object sender, EventArgs e)
        {
            TSMnuDataLinkClearFrom_Click( sender, e );

            TSMnuDataLinkClearTo_Click( sender, e );            
        }

        private void LblDataPicInfo_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblDataPicInfo );

            fNav.ShowForm( fDataPicInfo );            
        }

        private void LblMDComp_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDComp );
        }

        private void LblMDComp_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDComp );
        }

        private void LblMDComp_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblMDComp );

            fNav.ShowForm( fMD ); 

            SubRtn.ShowHideMD( fMD, "GrpComp" );
        }

        private void LblMDCpt_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDCpt );
        }

        private void LblMDCpt_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDCpt );
        }

        private void LblMDCpt_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblMDCpt );
             
            fNav.ShowForm( fMD );

            SubRtn.ShowHideMD( fMD, "GrpCpt" );
        }

        private void LblMDImageDesc_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDImageDesc );
        }

        private void LblMDImageDesc_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDImageDesc );
        }

        private void LblMDImageDesc_Click(object sender, EventArgs e)
        {            
            NavSetStyleClick( LblMDImageDesc );

            fNav.ShowForm( fMD );

            SubRtn.ShowHideMD( fMD, "GrpImageDesc" );
        }

        private void LblMDDx_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDDx );
        }

        private void LblMDDx_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDDx );
        }

        private void LblMDDx_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblMDDx );

            fNav.ShowForm( fMD );

            SubRtn.ShowHideMD( fMD, "GrpDx" );
        }

        private void LblMDDr_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDDr );
        }

        private void LblMDDr_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDDr );
        }

        private void LblMDDr_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblMDDr );            

            fNav.ShowForm( fMD );

            SubRtn.ShowHideMD( fMD, "GrpDr" );
        }

        private void LblMDFiscalYr_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDFiscalYr );
        }

        private void LblMDFiscalYr_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDFiscalYr );
        }

        private void LblMDFiscalYr_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblMDFiscalYr );
            
            fNav.ShowForm( fMD );

            SubRtn.ShowHideMD( fMD, "GrpFiscalYr");
        }

        private void LblMDHospital_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDHospital );
        }

        private void LblMDHospital_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDHospital );
        }

        private void LblMDHospital_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblMDHospital );

            fNav.ShowForm( fMD );

            SubRtn.ShowHideMD( fMD, "GrpHospital" );
        }

        private void LblMDInst_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDInst );
        }

        private void LblMDInst_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDInst );
        }

        private void LblMDInst_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblMDInst );

            fNav.ShowForm( fMD );

            SubRtn.ShowHideMD( fMD, "GrpInst" );
        }

        private void LblMDLevel_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDLevel );
        }

        private void LblMDLevel_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDLevel );
        }

        private void LblMDLevel_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblMDLevel );

            fNav.ShowForm( fMD );

            SubRtn.ShowHideMD( fMD, "GrpLevel" );
        }

        private void LblMDLocation_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDLocation );
        }

        private void LblMDLocation_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDLocation );
        }

        private void LblMDLocation_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblMDLocation );

            fNav.ShowForm( fMD );

            SubRtn.ShowHideMD( fMD, "GrpLocation" );
        }

        private void LblMDSurgery_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMDSurgery );
        }

        private void LblMDSurgery_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMDSurgery );
        }

        private void LblMDSurgery_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblMDSurgery );

            fNav.ShowForm( fMD );
            
            SubRtn.ShowHideMD( fMD, "GrpSurgery" );
        }

        private void LblRpt_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblRpt );
        }

        private void LblRpt_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblRpt );
        }

        private void LblMetaData_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblMetaData );
        }

        private void LblMetaData_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblMetaData );
        }

        private void LblRptStatic_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblRptStatic );

            fNav.ShowForm( fRptStatic );
        }

        private void LblRptStatic_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblRptStatic );
        }

        private void LblRptStatic_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblRptStatic );
        }

        private void LblRptDynamic_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblRptDynamic );

            fNav.ShowForm( fRptDynamic );
        }

        private void LblRptDynamic_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblRptDynamic );
        }

        private void LblRptDynamic_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblRptDynamic );
        }

        private void LblEmailPicPicOnly_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblEmailPicPicOnly );
        }

        private void LblEmailPicPicOnly_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblEmailPicPicOnly );
        }

        private void LblEmailPicPicOnly_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblEmailPicPicOnly );

            fNav.ShowForm( fPicOnly );           
        }

        private void LblEmailPic_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblEmailPic );
        }

        private void LblEmailPic_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblEmailPic );
        }

        private void TSMnuPicOnlySave_Click(object sender, EventArgs e)
        {
            FrmAddImageDesc fAddImageDesc = new FrmAddImageDesc();

            SAVEPICTONEW = false;
            SAVEPICTOEXISTING = false;
            SAVEPICONLY = false;

            fAddImageDesc.ShowDialog();

            //  save pics to existing patient
            if ( SAVEPICTOEXISTING == true )
            {
                fNav.ShowFormName( fImageSearchResuts.MdiParent.MdiChildren, "FrmImageSearchResults" );

                SubRtn.DashboardAccordian( LblImages, e, tableLayoutPanel1 );

                NavSetStyleClick( LblImagesSearchResults );

                SubRtn.ShowHideMenu( this, MnuImageSearchResult.Name );
            }

            //  save pics to new patient
            if( SAVEPICTONEW == true )
            {
                fNav.ShowFormName( fImageSearchResuts.MdiParent.MdiChildren, "FrmImageSearchResults" );

                SubRtn.DashboardAccordian( LblImages, e, tableLayoutPanel1 );

                NavSetStyleClick( LblImagesSearchResults );

                SubRtn.ShowHideMenu( this, MnuImageSearchResult.Name );
            }

            //  save pics only
            if ( SAVEPICONLY == true )
            {
                fNav.ShowFormName( fImageSearchResuts.MdiParent.MdiChildren, "FrmImageSearchResults" );

                SubRtn.DashboardAccordian( LblImages, e, tableLayoutPanel1 );

                NavSetStyleClick( LblImagesSearchResults );

                SubRtn.ShowHideMenu( this, MnuImageSearchResult.Name );
            }

            fAddImageDesc.Close();
        }

        private void LblSecurity_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblSecurity );            

            if ( LblSecurity.Font.Bold != true )
            {
                LblSecurity.Font = new Font( LblSecurity.Font.Name, LblSecurity.Font.SizeInPoints, FontStyle.Underline );
            }         
            else
            {
                LblSecurity.Font = new Font( LblSecurity.Font.Name, LblSecurity.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);                
            }
        }

        private void LblSecurity_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblSecurity );            

            if ( LblSecurity.Font.Bold != true )
            {
                LblSecurity.Font = new Font( LblSecurity.Font.Name, LblSecurity.Font.SizeInPoints, FontStyle.Regular );
            }
            else
            {
                LblSecurity.Font = new Font( LblSecurity.Font.Name, LblSecurity.Font.SizeInPoints, FontStyle.Bold );
            }
        }

        private void LblSecurityUserMgmt_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblSecurityUserMgmt );

            if ( LblSecurityUserMgmt.Font.Bold != true )
            {
                LblSecurityUserMgmt.Font = new Font( LblSecurityUserMgmt.Font.Name, LblSecurityUserMgmt.Font.SizeInPoints, FontStyle.Underline );
            }
            else
            {
                LblSecurityUserMgmt.Font = new Font( LblSecurityUserMgmt.Font.Name, LblSecurityUserMgmt.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold );
            }
        }

        private void LblSecurityUserMgmt_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblSecurityUserMgmt );

            if ( LblSecurityUserMgmt.Font.Bold != true )
            {
                LblSecurityUserMgmt.Font = new Font( LblSecurityUserMgmt.Font.Name, LblSecurityUserMgmt.Font.SizeInPoints, FontStyle.Regular );
            }
            else
            {
                LblSecurityUserMgmt.Font = new Font( LblSecurityUserMgmt.Font.Name, LblSecurityUserMgmt.Font.SizeInPoints, FontStyle.Bold );
            }
        }

        private void LblSecurityUserMgmt_Click(object sender, EventArgs e)
        {
            //SubRtn.ShowHideMenu(this, MnuSecurityUserMgmt.Name);
            Control mnu = SubRoutine.FindControl(fSecurity, "MnuSecurityUserMgmt");
            MenuStrip ctlmnu = mnu as MenuStrip;

            helper.ShowControl( ctlmnu );

            mnu = SubRoutine.FindControl( fSecurity, "MnuSecurity" );
            ctlmnu = mnu as MenuStrip;

            helper.HideControl(ctlmnu);


            NavSetStyleClick( LblSecurityUserMgmt );

            SubRtn.ShowHideSecurity( fSecurity, "GrpCurrentDBUser" );

            SubRtn.ShowHideSecurity( fSecurity, "GrpExistingUsers" );
        }
    }

    public class SubRoutine
    {
        public void DashboardAccordian(Object sender, EventArgs e, Panel pnlLayout)
        {
            // find out which label was clicked
            Label lbl = (Label)sender;

            // find the panel containing the label
            Panel pnl = lbl.Parent as Panel;

            // ### this assumes that no other controls are present in the main table ###
            // the code loops through the panels in the table and expands/collapses
            // each panel according to whether it contains the clicked label. The label
            // images are also swapped depending on the height of the panel.

            //foreach (Panel p in tableLayoutPanel1.Controls)
            foreach (Panel p in pnlLayout.Controls)
            {
                Label l = (Label)p.Controls[0];

                if (p.Equals(pnl))
                {
                    if (p.Tag != null)
                    {
                        if (p.Tag.ToString() != "Expanded")
                        {
                            // expand or collapse the panel
                            if (p.Height != 25)
                            {
                                p.Height = 25;
                                p.Tag = "Collapsed";
                            }
                            else
                            {
                                if ( p.Controls.Count == 2 )
                                {                                    
                                    p.Height = 60;
                                    p.Tag = "Expanded";
                                }
                                else if ( p.Controls.Count == 3 )
                                {
                                    p.Height = p.Controls.Count * 26;
                                    p.Tag = "Expanded";
                                }
                                else if ( p.Controls.Count == 4 )
                                {
                                    p.Height = p.Controls.Count * 26;
                                    p.Tag = "Expanded";
                                }
                                else if ( p.Controls.Count == 5 )
                                {                                    
                                    p.Height = ( p.Controls.Count - 1 ) * 30;
                                    p.Tag = "Expanded";
                                }
                                else if ( p.Controls.Count == 6 )
                                {                                   
                                    p.Height = ( p.Controls.Count ) * 24;
                                    p.Tag = "Expanded";
                                }
                                else
                                {
                                    p.Height = ( p.Controls.Count - 1 ) * 26;
                                    p.Tag = "Expanded";
                                }
                            }
                        }
                    }
                }
                else
                {
                    p.Height = 25;
                    p.Tag = "Collapsed";
                }
            }
        }

        public static Control FindControl(Form frm, String name)
        {
            foreach (Control control in frm.Controls)
            {
                Control result = FindControl(frm, control, name);

                if (result != null)
                    return result;
            }

            return null;
        }

        private static Control FindControl(Form form, Control control, string name)
        {
            if (control.Name == name)
            {
                return control;
            }

            foreach (Control subControl in control.Controls)
            {

                Control result = FindControl(form, subControl, name);

                if (result != null)
                    return result;
            }

            return null;
        }        

        public void ClearDataCustomizeNames(Form fDataCustName)
        {
            Helper helper = new Helper();

            //  clear doctor
            Control txt = SubRoutine.FindControl(fDataCustName, "TxtNewDr");
            TextBox ctltxt = txt as TextBox;

            helper.ClearTextBox(ctltxt);

            //  clear hospital
            txt = SubRoutine.FindControl(fDataCustName, "TxtNewHospital");
            ctltxt = txt as TextBox;

            helper.ClearTextBox(ctltxt);

            //  clear location
            txt = SubRoutine.FindControl(fDataCustName, "TxtNewLocation");
            ctltxt = txt as TextBox;

            helper.ClearTextBox(ctltxt);

            //  clear level
            txt = SubRoutine.FindControl(fDataCustName, "TxtNewLevel");
            ctltxt = txt as TextBox;

            helper.ClearTextBox(ctltxt);

            //  clear cpt
            txt = SubRoutine.FindControl(fDataCustName, "TxtNewCpt");
            ctltxt = txt as TextBox;

            helper.ClearTextBox(ctltxt);

            //  clear dx
            txt = SubRoutine.FindControl(fDataCustName, "TxtNewDx");
            ctltxt = txt as TextBox;

            helper.ClearTextBox(ctltxt);

            //  clear surgery
            txt = SubRoutine.FindControl(fDataCustName, "TxtNewSurgery");
            ctltxt = txt as TextBox;

            helper.ClearTextBox(ctltxt);

            //  clear instrumentation
            txt = SubRoutine.FindControl(fDataCustName, "TxtNewInst");
            ctltxt = txt as TextBox;

            helper.ClearTextBox(ctltxt);

            //  clear complication
            txt = SubRoutine.FindControl(fDataCustName, "TxtNewComp");
            ctltxt = txt as TextBox;

            helper.ClearTextBox(ctltxt);

        }

        public void ClearFiscalYear(Form fSurgerySearch)
        {
            Helper helper = new Helper();

            //  clear fiscal year
            if (FrmSurgerySearch.SurgerySearchVar.ClearType == 1)
            {
                Control rdo = SubRoutine.FindControl(fSurgerySearch, "RdoFiscalEqualTo");
                RadioButton ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);

                rdo = SubRoutine.FindControl(fSurgerySearch, "RdoFiscalGreater");
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);

                rdo = SubRoutine.FindControl(fSurgerySearch, "RdoFiscalLess");
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);

                rdo = SubRoutine.FindControl(fSurgerySearch, "RdoFiscalBetween");
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);

                Control dt = SubRoutine.FindControl(fSurgerySearch, "DtFiscalStart");
                DateTimePicker ctldt = dt as DateTimePicker;

                helper.SetDateToToday(ctldt);

                dt = SubRoutine.FindControl(fSurgerySearch, "DtFiscalEnd");
                ctldt = dt as DateTimePicker;

                helper.SetDateToToday(ctldt);
            }
        }

        public void ClearItems(Form fSurgerySearch)
        {
            Helper helper = new Helper();

            //  clear doctor
            Control lstFrom = SubRoutine.FindControl(fSurgerySearch, "LstDr");
            ListBox ctllstFrom = lstFrom as ListBox;

            Control lstTo = SubRoutine.FindControl(fSurgerySearch, "LstDrFilter");
            ListBox ctllstTo = lstTo as ListBox;

            helper.ClearListBoxes(ctllstFrom, ctllstTo);


            //  clear hospital
            lstFrom = SubRoutine.FindControl(fSurgerySearch, "LstHospital");
            ctllstFrom = lstFrom as ListBox;

            lstTo = SubRoutine.FindControl(fSurgerySearch, "LstHospitalFilter");
            ctllstTo = lstTo as ListBox;

            helper.ClearListBoxes(ctllstFrom, ctllstTo);


            //  clear location
            lstFrom = SubRoutine.FindControl(fSurgerySearch, "LstLocation");
            ctllstFrom = lstFrom as ListBox;

            lstTo = SubRoutine.FindControl(fSurgerySearch, "LstLocationFIlter");
            ctllstTo = lstTo as ListBox;

            helper.ClearListBoxes(ctllstFrom, ctllstTo);


            //  clear level
            lstFrom = SubRoutine.FindControl(fSurgerySearch, "LstLevel");
            ctllstFrom = lstFrom as ListBox;

            lstTo = SubRoutine.FindControl(fSurgerySearch, "LstLevelFilter");
            ctllstTo = lstTo as ListBox;

            helper.ClearListBoxes(ctllstFrom, ctllstTo);

            //  clear cpt
            lstFrom = SubRoutine.FindControl(fSurgerySearch, "LstCpt");
            ctllstFrom = lstFrom as ListBox;

            lstTo = SubRoutine.FindControl(fSurgerySearch, "LstCptFilter");
            ctllstTo = lstTo as ListBox;

            helper.ClearListBoxes(ctllstFrom, ctllstTo);


            //  clear Dx
            lstFrom = SubRoutine.FindControl(fSurgerySearch, "LstDx");
            ctllstFrom = lstFrom as ListBox;

            lstTo = SubRoutine.FindControl(fSurgerySearch, "LstDxFilter");
            ctllstTo = lstTo as ListBox;

            helper.ClearListBoxes(ctllstFrom, ctllstTo);


            //  clear surgery
            lstFrom = SubRoutine.FindControl(fSurgerySearch, "LstSurgery");
            ctllstFrom = lstFrom as ListBox;

            lstTo = SubRoutine.FindControl(fSurgerySearch, "LstSurgeryFilter");
            ctllstTo = lstTo as ListBox;

            helper.ClearListBoxes(ctllstFrom, ctllstTo);


            //  clear instrumentation
            lstFrom = SubRoutine.FindControl(fSurgerySearch, "LstInst");
            ctllstFrom = lstFrom as ListBox;

            lstTo = SubRoutine.FindControl(fSurgerySearch, "LstInstFilter");
            ctllstTo = lstTo as ListBox;

            helper.ClearListBoxes(ctllstFrom, ctllstTo);


            //  clear comp
            lstFrom = SubRoutine.FindControl(fSurgerySearch, "LstComp");
            ctllstFrom = lstFrom as ListBox;

            lstTo = SubRoutine.FindControl(fSurgerySearch, "LstCompFilter");
            ctllstTo = lstTo as ListBox;

            helper.ClearListBoxes(ctllstFrom, ctllstTo);


            //  clear PicInfo
            lstFrom = SubRoutine.FindControl(fSurgerySearch, "LstPicInfo");
            ctllstFrom = lstFrom as ListBox;

            lstTo = SubRoutine.FindControl(fSurgerySearch, "LstPicInfoFilter");
            ctllstTo = lstTo as ListBox;

            helper.ClearListBoxes(ctllstFrom, ctllstTo);
        }        

        public void ClearSurgeryDates(Form fSurgerySearch)
        {
            Helper helper = new Helper();

            //  clear surgery dates
            if (FrmSurgerySearch.SurgerySearchVar.ClearType == 0)
            {
                Control rdo = SubRoutine.FindControl(fSurgerySearch, "RdoSurgeryEqualTo");
                RadioButton ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);

                rdo = SubRoutine.FindControl(fSurgerySearch, "RdoSurgeryGreater");
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);

                rdo = SubRoutine.FindControl(fSurgerySearch, "RdoSurgeryLess");
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);

                rdo = SubRoutine.FindControl(fSurgerySearch, "RdoSurgeryBetween");
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);

                Control dt = SubRoutine.FindControl(fSurgerySearch, "DtStart");
                DateTimePicker ctldt = dt as DateTimePicker;

                helper.SetDateToToday(ctldt);

                dt = SubRoutine.FindControl(fSurgerySearch, "DtEnd");
                ctldt = dt as DateTimePicker;

                helper.SetDateToToday(ctldt);

            }
        }

        public void Load_All_Forms(Form frm, Form frmMain)
        {
            frm.MdiParent = frmMain;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.WindowState = FormWindowState.Minimized;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();           
        }

        public void NavSetStyleClickSub( Label lblIn )
        {
            Label lblClick = lblIn;

            //  Dashboard Panel         
            foreach ( Form f in Application.OpenForms )
            {
                if ( f.Tag.ToString() == "FrmMain" )
                {
                    //  Dashboard Panel 
                    Control lbl = SubRoutine.FindControl( f, "LblDashboard" );
                    Label ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    //  Meta Data Panel
                    lbl = SubRoutine.FindControl( f, "LblMetaData" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDComp" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDCpt" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDImageDesc" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDDx" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDDr" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDFiscalYr" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDHospital" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDLevel" );
                    ctllbl = lbl as Label; 
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDInst" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDLocation" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblMDSurgery" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );


                    //  Security Panel
                    lbl = SubRoutine.FindControl( f, "LblSecurity" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );

                    lbl = SubRoutine.FindControl( f, "LblSecurityUserMgmt" );
                    ctllbl = lbl as Label;
                    ctllbl.Font = NavSetStyleLblSub( ctllbl );
                    
                    //break;
                }
            }

            //  Set font bold
            if ( lblIn.Font.Bold != true )
            {
                lblIn.Font = new Font( lblIn.Font.Name, lblIn.Font.SizeInPoints, FontStyle.Bold );
            }            
        }

        public static Font NavSetStyleLblSub ( Label lbl )
        {
            lbl.Font = new Font( lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Regular );
            return lbl.Font;
        }

        public void ShowHideMD ( Form frm, string GrpName )
        {
            //  Complication
            Control grp = SubRoutine.FindControl( frm, "GrpComp");
            GroupBox ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpComp" )
                { ctlGrp.BringToFront(); }
            else
                { ctlGrp.SendToBack(); }

            //  CPT
            grp = SubRoutine.FindControl( frm, "GrpCpt" );
            ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpCpt" )
                { ctlGrp.BringToFront(); }
            else
                { ctlGrp.SendToBack(); }

            //  Image Descriptors
            grp = SubRoutine.FindControl ( frm, "GrpImageDesc" );
            ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpImageDesc" )
            { ctlGrp.BringToFront(); }
            else
            { ctlGrp.SendToBack(); }

            //  DX
            grp = SubRoutine.FindControl( frm, "GrpDx" );
            ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpDx" )
            { ctlGrp.BringToFront(); }
            else
            { ctlGrp.SendToBack(); }

            //  Dr
            grp = SubRoutine.FindControl( frm, "GrpDr" );
            ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpDr" )
            { ctlGrp.BringToFront(); }
            else
            { ctlGrp.SendToBack(); }

            //  Fiscal Year
            grp = SubRoutine.FindControl( frm, "GrpFiscalYr" );
            ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpFiscalYr" )
            { ctlGrp.BringToFront(); }
            else
            { ctlGrp.SendToBack(); }

            //  Hospital
            grp = SubRoutine.FindControl( frm, "GrpHospital" );
            ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpHospital" )
            { ctlGrp.BringToFront(); }
            else
            { ctlGrp.SendToBack(); }

            //  Instrumentation
            grp = SubRoutine.FindControl( frm, "GrpInst" );
            ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpInst")
            { ctlGrp.BringToFront(); }
            else
            { ctlGrp.SendToBack(); }

            //  Level
            grp = SubRoutine.FindControl( frm, "GrpLevel" );
            ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpLevel")
            { ctlGrp.BringToFront(); }
            else
            { ctlGrp.SendToBack(); }

            //  Location
            grp = SubRoutine.FindControl( frm, "GrpLocation" );
            ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpLocation")
            { ctlGrp.BringToFront(); }
            else
            { ctlGrp.SendToBack(); }

            //  Surgery
            grp = SubRoutine.FindControl( frm, "GrpSurgery" );
            ctlGrp = grp as GroupBox;

            if ( GrpName == "GrpSurgery" )
            { ctlGrp.BringToFront(); }
            else
            { ctlGrp.SendToBack(); }
        }

        public void ShowHideSecurity( Form frm, string GrpName )
        {
            Control grp;
            GroupBox ctlGrp;

            switch ( GrpName )
            {
                //  Current DB User
                case "GrpCurrentDBUser":
                    grp = SubRoutine.FindControl( frm, "GrpCurrentDBUser" );
                    ctlGrp = grp as GroupBox;
                    ctlGrp.Visible = true;

                    grp = SubRoutine.FindControl(frm, "GrpCurrentUser");
                    ctlGrp = grp as GroupBox;
                    ctlGrp.Visible = false;

                    break;

                //  Current User
                case "GrpCurrentUser":
                    grp = SubRoutine.FindControl(frm, "GrpCurrentUser");
                    ctlGrp = grp as GroupBox;
                    ctlGrp.Visible = true;

                    grp = SubRoutine.FindControl(frm, "GrpCurrentDBUser");
                    ctlGrp = grp as GroupBox;
                    ctlGrp.Visible = false;

                    break;

                //  Existing User
                case "GrpExistingUsers":
                    grp = SubRoutine.FindControl( frm, "GrpExistingUsers" );
                    ctlGrp = grp as GroupBox;
                    ctlGrp.Visible = true;

                    grp = SubRoutine.FindControl(frm, "GrpAllUsers");
                    ctlGrp = grp as GroupBox;
                    ctlGrp.Visible = false;

                    break;

                //  All Users
                case "GrpAllUsers":
                    grp = SubRoutine.FindControl(frm, "GrpAllUsers");
                    ctlGrp = grp as GroupBox;
                    ctlGrp.Visible = true;

                    grp = SubRoutine.FindControl(frm, "GrpExistingUsers");
                    ctlGrp = grp as GroupBox;
                    ctlGrp.Visible = false;

                    break;
            }
        }

        public void ShowHideMenu(Form fMain, string ControlName)
        {
            foreach (Control ctr in fMain.Controls)
            {
                if (ctr is MenuStrip & ctr.Name == ControlName)
                {
                    ctr.Visible = true;
                    break;
                }
                else if (ctr is MenuStrip)
                {
                    ctr.Visible = false;
                }
            }
        }

        public void SurgeryClearType(Form fSurgery)
        {
            Helper helper = new Helper();

            //  clear surgery type
            if (FrmSurgery.SurgeryVar.ClearType == 0)
            {
                Control updwn = SubRoutine.FindControl(fSurgery, "UpDwnLastNameLetter");
                DomainUpDown ctlupdwn = updwn as DomainUpDown;

                helper.ClearUpDwn(ctlupdwn);

                Control cbo = SubRoutine.FindControl(fSurgery, "CboFullName");
                ComboBox ctlcbo = cbo as ComboBox;

                helper.ClearComboBox(ctlcbo);
            }

            //  clear surgery date
            if (FrmSurgery.SurgeryVar.ClearType == 1)
            {
                Control updwn = SubRoutine.FindControl(fSurgery, "UpDwnYear");
                DomainUpDown ctlupdwn = updwn as DomainUpDown;

                helper.ClearUpDwn(ctlupdwn);

                updwn = SubRoutine.FindControl(fSurgery, "UpDwnMonth");
                ctlupdwn = updwn as DomainUpDown;

                helper.ClearUpDwn(ctlupdwn);
            }
        }

    }
}