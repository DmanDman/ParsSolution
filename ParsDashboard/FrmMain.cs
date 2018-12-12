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

namespace ParsDashboard
{
    public partial class FrmMain : Form
    {
        #region Define Forms
        //  define forms
        FormNav fNav = new FormNav();

        FrmDashboard fDashBoard = new FrmDashboard();

        FrmImages fImage = new FrmImages();
        FrmImageSearch fImageSearch = new FrmImageSearch();
        FrmImageSearchResults fImageSearchResuts = new FrmImageSearchResults();
        FrmImageFilter fImageFilter = new FrmImageFilter();

        FrmPatient fPatient = new FrmPatient();
        public FrmPatientSearch fPatientSearch = new FrmPatientSearch();

        FrmSurgery fSurgery = new FrmSurgery();
        FrmSurgerySearch fSurgerySearch = new FrmSurgerySearch();
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
            LblDashboard.Font = new Font(LblDashboard.Font.Name, LblDashboard.Font.SizeInPoints, FontStyle.Regular);

            //  Images Panel
            LblImages.Font = new Font(LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Regular);
            LblImagesAdd.Font = new Font(LblImagesAdd.Font.Name, LblImagesAdd.Font.SizeInPoints, FontStyle.Regular);
            LblImagesSearch.Font = new Font(LblImagesSearch.Font.Name, LblImagesSearch.Font.SizeInPoints, FontStyle.Regular);
            LblImagesFilter.Font = new Font(LblImagesFilter.Font.Name, LblImagesFilter.Font.SizeInPoints, FontStyle.Regular);
            LblImagesSearchResults.Font = new Font(LblImagesSearchResults.Font.Name, LblImagesSearchResults.Font.SizeInPoints, FontStyle.Regular);
            LblImagesSearchToPatient.Font = new Font(LblImagesSearchToPatient.Font.Name, LblImagesSearchToPatient.Font.SizeInPoints, FontStyle.Regular);

            //  Patient Panel
            LblPatient.Font = new Font(LblPatient.Font.Name, LblPatient.Font.SizeInPoints, FontStyle.Regular);
            LblPatientAdd.Font = new Font(LblPatientAdd.Font.Name, LblPatientAdd.Font.SizeInPoints, FontStyle.Regular);
            LlbPatientSearch.Font = new Font(LlbPatientSearch.Font.Name, LlbPatientSearch.Font.SizeInPoints, FontStyle.Regular);
            LblPatientFilter.Font = new Font(LblPatientFilter.Font.Name, LblPatientFilter.Font.SizeInPoints, FontStyle.Regular);
            LblPatientSearchResults.Font = new Font(LblPatientSearchResults.Font.Name, LblPatientSearchResults.Font.SizeInPoints, FontStyle.Regular);
            LblPatientSearchToImage.Font = new Font(LblPatientSearchToImage.Font.Name, LblPatientSearchToImage.Font.SizeInPoints, FontStyle.Regular);

            //  Surgery Panel
            LblSurgery.Font = new Font(LblSurgery.Font.Name, LblSurgery.Font.SizeInPoints, FontStyle.Regular);
            LblSurgeryAdd.Font = new Font(LblSurgeryAdd.Font.Name, LblSurgeryAdd.Font.SizeInPoints, FontStyle.Regular);
            LblSurgerySearch.Font = new Font(LblSurgerySearch.Font.Name, LblSurgerySearch.Font.SizeInPoints, FontStyle.Regular);

            //  Set font bold
            if (lblClick.Font.Bold != true)
            {
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Bold);
            }
            else
            {

            }
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

            StopPanel_FlickeringPanel(tableLayoutPanel1);
            StopPanel_FlickeringPanel(PnlDashboard);
            StopPanel_FlickeringPanel(PnlImages);
            StopPanel_FlickeringPanel(PnlPatient);
            StopPanel_FlickeringPanel(PnlSurgery);
            StopPanel_FlickeringPanel(PnlRpt);
            StopPanel_FlickeringPanel(PnlData);
            StopPanel_FlickeringPanel(PnlMetaData);
            StopPanel_FlickeringPanel(PnlEmailPic);
            StopPanel_FlickeringPanel(PnlSecurity);
        }

        private void StopPanel_FlickeringPanel(Panel pnl)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnl, new object[] { true });
        }
        #endregion


        public FrmMain()
        {
            InitializeComponent();
            StopPanel_Flickering();

            SubRtn.Load_All_Forms(fPatient, this);
            SubRtn.Load_All_Forms(fPatientSearch, this);

            SubRtn.Load_All_Forms(fImage, this);
            SubRtn.Load_All_Forms(fImageSearch, this);
            SubRtn.Load_All_Forms(fImageSearchResuts, this);
            SubRtn.Load_All_Forms(fImageFilter, this);

            SubRtn.Load_All_Forms(fSurgery, this);
            SubRtn.Load_All_Forms(fSurgerySearch, this);

            SubRtn.Load_All_Forms(fDashBoard, this);

            LblDashboard.Click += new EventHandler(LblDashboard_Click);
        }

        private void LblPatient_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);

            fNav.ShowForm(fPatient);

            NavSetStyleClick(LblPatient);

            SubRtn.ShowHideMenu(this, MnuPatient.Name);
        }

        private void LblSurgery_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);

            fNav.ShowForm(fSurgery);

            NavSetStyleClick(LblSurgery);

            SubRtn.ShowHideMenu(this, MnuSurgery.Name);
        }

        private void LblRpt_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);
        }

        private void LblData_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);
        }

        private void LblMetaData_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);
        }

        private void LblEmailPic_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);
        }

        private void LblSecurity_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);
        }

        public void LblDashboard_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);

            NavSetStyleClick(LblDashboard);

            fNav.ShowForm(fDashBoard);

            SubRtn.ShowHideMenu(this, MnuDashboard.Name);
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

            SubRtn.ShowHideMenu(this, MnuImagesSearch.Name);
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
            SubRtn.DashboardAccordian(sender, e, tableLayoutPanel1);

            fNav.ShowForm(fImage);

            NavSetStyleClick(LblImages);

            SubRtn.ShowHideMenu(this, MnuImages.Name);
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
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void LblImagesFilter_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblImagesFilter);
        }

        private void LblImagesSearchResults_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblImagesSearchResults);
        }

        private void LblImagesSearchToPatient_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblImagesSearchToPatient);
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
            HelpMouseMove.MouseEnter(LblPatientSearchResults);
        }

        private void LblPatientSearchToImage_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter(LblPatientSearchToImage);
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
            HelpMouseMove.MouseLeave(LblImagesSearchResults);
        }

        private void LblImagesSearchToPatient_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblImagesSearchToPatient);
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
            HelpMouseMove.MouseLeave(LblPatientSearchResults);
        }

        private void LblPatientSearchToImage_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave(LblPatientSearchToImage);
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
            fNav.ShowForm(fImageFilter);

            NavSetStyleClick(LblImagesFilter);

            SubRtn.ShowHideMenu(this, MnuImageFilter.Name);
        }

        public void LblImagesSearchResults_Click(object sender, EventArgs e)
        {
            //fNav.ShowForm( X );

            NavSetStyleClick(LblImagesSearchResults);
        }

        private void LblImagesSearchToPatient_Click(object sender, EventArgs e)
        {
            //fNav.ShowForm( X );

            NavSetStyleClick(LblImagesSearchToPatient);
        }

        private void LlbPatientSearch_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fPatientSearch);

            NavSetStyleClick(LlbPatientSearch);

            SubRtn.ShowHideMenu(this, MnuPatientSearch.Name);
        }

        private void LblPatientFilter_Click(object sender, EventArgs e)
        {
            //fNav.ShowForm( X );

            NavSetStyleClick(LblPatientFilter);
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

            helper.AddListBoxData(ctlCbo, ctlLst);
        }

        private void TSMnuRemoveMeta_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl(fImageSearch, "CboMetaSearch");
            Control lst = SubRoutine.FindControl(fImageSearch, "LstMetaDataSearchTerms");

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.AddComboBox( ctlCbo, ctlLst );
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
            NavSetStyleClick(LblPatientSearchToImage);
        }

        private void LblPatientSearchResults_Click(object sender, EventArgs e)
        {
            NavSetStyleClick(LblPatientSearchResults);
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

                txt = SubRoutine.FindControl(fPatientSearch, "TxtSsn");
                ctltxt = txt as TextBox;

                helper.ClearTextBox(ctltxt);
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

                txt = SubRoutine.FindControl(fPatientSearch, "TxtZip");
                ctltxt = txt as TextBox;

                helper.ClearTextBox(ctltxt);

                txt = SubRoutine.FindControl(fPatientSearch, "TxtPhone");
                ctltxt = txt as TextBox;

                helper.ClearTextBox(ctltxt);

                txt = SubRoutine.FindControl(fPatientSearch, "TxtCell");
                ctltxt = txt as TextBox;

                helper.ClearTextBox(ctltxt);
            }
        }

        private void TSMnuPatientSrchSearch_Click(object sender, EventArgs e)
        {
            fNav.ShowForm(fImageSearchResuts);

            SubRtn.DashboardAccordian(LblImages, e, tableLayoutPanel1);

            NavSetStyleClick(LblImagesSearchResults);

            SubRtn.ShowHideMenu(this, MnuImageSearchResult.Name);
        }

        private void LblSurgeryAdd_Click(object sender, EventArgs e)
        {
            NavSetStyleClick(LblSurgeryAdd);
        }

        private void LblSurgerySearch_Click(object sender, EventArgs e)
        {
            NavSetStyleClick(LblSurgerySearch);

            fNav.ShowForm(fSurgerySearch);

            SubRtn.ShowHideMenu(this, MnuSurgerySearch.Name);
        }

        private void TSMnuSurgerySrchClearSurgery_Click(object sender, EventArgs e)
        {
            //  clear surgery dates
            if ( FrmSurgerySearch.SurgerySearchVar.ClearType == 0 )
            {             
                Control rdo = SubRoutine.FindControl( fSurgerySearch, "RdoSurgeryEqualTo" );
                RadioButton ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn( ctlrdo );

                rdo = SubRoutine.FindControl( fSurgerySearch, "RdoSurgeryGreater" );
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn( ctlrdo );

                rdo = SubRoutine.FindControl( fSurgerySearch, "RdoSurgeryLess" );
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn( ctlrdo );

                rdo = SubRoutine.FindControl( fSurgerySearch, "RdoSurgeryBetween" );
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn( ctlrdo );

                Control dt = SubRoutine.FindControl( fSurgerySearch, "DtStart" );
                DateTimePicker ctldt = dt as DateTimePicker;

                helper.SetDateToToday( ctldt );

                dt = SubRoutine.FindControl( fSurgerySearch, "DtEnd" );
                ctldt = dt as DateTimePicker;

                helper.SetDateToToday( ctldt );

            }

            //  clear fiscal year
            if ( FrmSurgerySearch.SurgerySearchVar.ClearType ==  1)
            {
                Control rdo = SubRoutine.FindControl( fSurgerySearch, "RdoFiscalEqualTo" );
                RadioButton ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn( ctlrdo );

                rdo = SubRoutine.FindControl( fSurgerySearch, "RdoFiscalGreater" );
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn( ctlrdo );

                rdo = SubRoutine.FindControl( fSurgerySearch, "RdoFiscalLess" );
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn(ctlrdo);

                rdo = SubRoutine.FindControl( fSurgerySearch, "RdoFiscalBetween" );
                ctlrdo = rdo as RadioButton;

                helper.ClearRadioBtn( ctlrdo );

                Control dt = SubRoutine.FindControl( fSurgerySearch, "DtFiscalStart" );
                DateTimePicker ctldt = dt as DateTimePicker;

                helper.SetDateToToday( ctldt );

                dt = SubRoutine.FindControl( fSurgerySearch, "DtFiscalEnd" );
                ctldt = dt as DateTimePicker;

                helper.SetDateToToday( ctldt );               
            }
        }
    }

    public class SubRoutine
    {
        public void ShowHideMenu( Form fMain, string ControlName )
        {           
            foreach( Control ctr in fMain.Controls )
            {
                if( ctr is MenuStrip & ctr.Name == ControlName )
                {
                    ctr.Visible = true;
                }
                else if ( ctr is MenuStrip )
                {
                    ctr.Visible = false;
                }
            }
        }

        public static Control FindControl( Form frm, String name )
        {
            foreach ( Control control in frm.Controls )
            {
                Control result = FindControl( frm, control, name );

                if ( result != null )
                    return result;
            }

            return null;
        }

        private static Control FindControl( Form form, Control control, string name )
        {
            if ( control.Name == name )
            {
                return control;
            }

            foreach ( Control subControl in control.Controls )
            {
                Control result = FindControl( form, subControl, name) ;

                if ( result != null )
                    return result;
            }

            return null;
        }

        public void DashboardAccordian( Object sender, EventArgs e , Panel pnlLayout )
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
            foreach ( Panel p in pnlLayout.Controls )
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
                                if (p.Controls.Count == 3)
                                {
                                    p.Height = p.Controls.Count * 28;
                                    p.Tag = "Expanded";
                                }
                                else
                                {
                                    p.Height = (p.Controls.Count - 1) * 28;
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

        public void Load_All_Forms( Form frm, Form frmMain )
        {
            frm.MdiParent = frmMain;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.WindowState = FormWindowState.Minimized;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }
    }
}
