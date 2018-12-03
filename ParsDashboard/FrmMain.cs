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
                      
            SubRtn.Load_All_Forms( fPatient, this );           
            SubRtn.Load_All_Forms( fImage, this );
            SubRtn.Load_All_Forms( fImageSearch, this );
            SubRtn.Load_All_Forms( fImageSearchResuts, this );
            SubRtn.Load_All_Forms( fImageFilter, this );
            SubRtn.Load_All_Forms( fDashBoard, this );

            LblDashboard.Click += new EventHandler( LblDashboard_Click );
        }
        
        private void LblPatient_Click(object sender, EventArgs e)
        {         
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );

            fNav.ShowForm( fPatient );

            NavSetStyleClick( LblPatient );

            SubRtn.ShowHideMenu( this, MnuPatient.Name );
        }

        private void LblSurgery_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );
        }

        private void LblRpt_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );
        }

        private void LblData_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );
        }

        private void LblMetaData_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );
        }

        private void LblEmailPic_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );
        }

        private void LblSecurity_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );
        }

        public void LblDashboard_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );

            NavSetStyleClick( LblDashboard );

            fNav.ShowForm( fDashBoard );

            SubRtn.ShowHideMenu( this, MnuDashboard.Name );
        }

        private void LblImagesAdd_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblImagesAdd );
        }

        private void LblImagesAdd_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblImagesAdd );
        }

        private void LblImagesAdd_Click(object sender, EventArgs e)
        {
            DlgImagesAdd.ShowDialog();
        }

        private void LblImagesSearch_Click(object sender, EventArgs e)
        {
            fNav.ShowForm( fImageSearch );
            
            NavSetStyleClick( LblImagesSearch );

            SubRtn.ShowHideMenu(this, MnuImagesSearch.Name);
        }

        private void LblDashboard_MouseEnter(object sender, EventArgs e)
        {
            if ( LblDashboard.Font.Bold != true )
            { 
                LblDashboard.Font = new Font( LblDashboard.Font.Name, LblDashboard.Font.SizeInPoints, FontStyle.Underline );
            }
        }

        private void LblDashboard_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblDashboard );            
        }   

        private void LblImagesSearch_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblImagesSearch );
        }

        private void LblImagesSearch_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblImagesSearch );
        }

        private void LlbImages_MouseEnter(object sender, EventArgs e)
        {
            LblImages.Font = new Font( LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Underline );
        }

        private void LlbImages_MouseLeave(object sender, EventArgs e)
        {
            LblImages.Font = new Font( LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Regular );
        }        

        private void LblImages_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );

            fNav.ShowForm( fImage );

            NavSetStyleClick( LblImages );

            SubRtn.ShowHideMenu( this, MnuImages.Name );
        }

        private void LblImages_MouseEnter(object sender, EventArgs e)
        {
            if (LblImages.Font.Bold != true)
            {
                LblImages.Font = new Font( LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Underline );
            }
        }

        private void LblImages_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblImages );            
        }

        private void LblPatient_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblPatient );            
        }

        private void LblPatient_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblPatient );            
        }

        private void LblPatientAdd_Click(object sender, EventArgs e)
        {
            SubRtn.DashboardAccordian( sender, e, tableLayoutPanel1 );

            // TODO create patinet add form; add it here
            //fNav.ShowForm(  );

            NavSetStyleClick( LblPatientAdd );
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
            HelpMouseMove.MouseEnter( LblImagesFilter );
        }

        private void LblImagesSearchResults_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblImagesSearchResults );
        }

        private void LblImagesSearchToPatient_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblImagesSearchToPatient );
        }

        private void LblPatientAdd_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblPatientAdd );
        }

        private void LlbPatientSearch_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LlbPatientSearch );
        }

        private void LblPatientFilter_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblPatientFilter );
        }

        private void LblPatientSearchResults_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblPatientSearchResults );
        }

        private void LblPatientSearchToImage_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblPatientSearchToImage );
        }

        private void LblSurgery_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblSurgery );
        }

        private void LblSurgeryAdd_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblSurgeryAdd );
        }

        private void LblSurgerySearch_MouseEnter(object sender, EventArgs e)
        {
            HelpMouseMove.MouseEnter( LblSurgerySearch );
        }

        private void LblImagesFilter_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblImagesFilter );
        }

        private void LblImagesSearchResults_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblImagesSearchResults );
        }

        private void LblImagesSearchToPatient_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblImagesSearchToPatient );
        }

        private void LblPatientAdd_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblPatientAdd );
        }

        private void LlbPatientSearch_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LlbPatientSearch );
        }

        private void LblPatientFilter_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblPatientFilter );
        }

        private void LblPatientSearchResults_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblPatientSearchResults );
        }

        private void LblPatientSearchToImage_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblPatientSearchToImage );
        }

        private void LblSurgery_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblSurgery );
        }

        private void LblSurgeryAdd_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblSurgeryAdd );
        }

        private void LblSurgerySearch_MouseLeave(object sender, EventArgs e)
        {
            HelpMouseMove.MouseLeave( LblSurgerySearch );
        }

        private void LblImagesFilter_Click(object sender, EventArgs e)
        {
            fNav.ShowForm( fImageFilter );

            NavSetStyleClick( LblImagesFilter );

            SubRtn.ShowHideMenu( this, MnuImageFilter.Name );           
        }

        public void LblImagesSearchResults_Click(object sender, EventArgs e)
        {
            //fNav.ShowForm( X );

            NavSetStyleClick( LblImagesSearchResults );
        }

        private void LblImagesSearchToPatient_Click(object sender, EventArgs e)
        {
            //fNav.ShowForm( X );

            NavSetStyleClick( LblImagesSearchToPatient );
        }

        private void LlbPatientSearch_Click(object sender, EventArgs e)
        {
            //fNav.ShowForm( X );

            NavSetStyleClick( LlbPatientSearch );
        }

        private void LblPatientFilter_Click(object sender, EventArgs e)
        {
            //fNav.ShowForm( X );

            NavSetStyleClick( LblPatientFilter );
        }       

        private void TSMnuSearch_Click(object sender, EventArgs e)
        {            
            fNav.ShowForm( fImageSearchResuts );

            NavSetStyleClick( LblImagesSearchResults );

            SubRtn.ShowHideMenu( this, MnuImageSearchResult.Name );
        }

        private void TSMnuAddMeta_Click(object sender, EventArgs e)
        {      
            Control cbo = SubRoutine.FindControl( fImageSearch, "CboMetaSearch" );
            Control lst = SubRoutine.FindControl( fImageSearch, "LstMetaDataSearchTerms" );

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.AddListBoxData( ctlCbo, ctlLst );
        }

        private void TSMnuRemoveMeta_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl( fImageSearch, "CboMetaSearch" );
            Control lst = SubRoutine.FindControl( fImageSearch, "LstMetaDataSearchTerms" );

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.AddComboBox( ctlCbo, ctlLst );
        }

        private void TSMnuAddInfo_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl( fImageSearch, "CboPicInfo" );
            Control lst = SubRoutine.FindControl( fImageSearch, "LstPicInfoSearchItems" );

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.AddListBoxData( ctlCbo, ctlLst );
        }

        private void TSMnuRemoveInfo_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl( fImageSearch, "CboPicInfo" );
            Control lst = SubRoutine.FindControl( fImageSearch, "LstPicInfoSearchItems" );

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.AddComboBox( ctlCbo, ctlLst );
        }

        private void TSMnuRemoveAllMeta_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl( fImageSearch, "CboMetaSearch" );
            Control lst = SubRoutine.FindControl( fImageSearch, "LstMetaDataSearchTerms" );

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.RemoveAllListBox( ctlCbo, ctlLst );
        }

        private void TsMnuRemoveAllPic_Click(object sender, EventArgs e)
        {
            Control cbo = SubRoutine.FindControl( fImageSearch, "CboPicInfo" );
            Control lst = SubRoutine.FindControl( fImageSearch, "LstPicInfoSearchItems" );

            ComboBox ctlCbo = cbo as ComboBox;
            ListBox ctlLst = lst as ListBox;

            helper.RemoveAllListBox( ctlCbo, ctlLst );
        }

        private void LblPatientSearchToImage_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblPatientSearchToImage );
        }

        private void LblPatientSearchResults_Click(object sender, EventArgs e)
        {
            NavSetStyleClick( LblPatientSearchResults );
        }        

        private void TSMnuFilterClearChecks_Click(object sender, EventArgs e)
        {
            Control gb = SubRoutine.FindControl( fImageFilter, "GrpBoxPersonal" );
            GroupBox ctlGb = gb as GroupBox;

            helper.ClearAllCheckBoxes( ctlGb );
        }

        private void TSMnuFilterClearSurgery_Click(object sender, EventArgs e)
        {
            //  clear doctor
            Control lbFrom = SubRoutine.FindControl( fImageFilter, "LstDr" );
            ListBox ctllbFrom = lbFrom as ListBox;

            Control lbTo = SubRoutine.FindControl( fImageFilter, "LstDrFilter" );
            ListBox ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes( ctllbFrom, ctllbTo );


            //  clear hospital
            lbFrom = SubRoutine.FindControl( fImageFilter, "LstHospital" );
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl( fImageFilter, "LstHospitalFilter" );
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes( ctllbFrom, ctllbTo );


            //  clear location
            lbFrom = SubRoutine.FindControl( fImageFilter, "LstLocation" );
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl( fImageFilter, "LstLocationFIlter" );
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes( ctllbFrom, ctllbTo );


            //  clear level
            lbFrom = SubRoutine.FindControl( fImageFilter, "LstLevel" );
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl( fImageFilter, "LstLevelFilter" );
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes( ctllbFrom, ctllbTo );


            //  clear cpt
            lbFrom = SubRoutine.FindControl( fImageFilter, "LstCpt" );
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl( fImageFilter, "LstCptFilter" );
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes( ctllbFrom, ctllbTo );


            //  clear dx
            lbFrom = SubRoutine.FindControl( fImageFilter, "LstDx" );
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl( fImageFilter, "LstDxFilter" );
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes( ctllbFrom, ctllbTo );


            //  clear surgery
            lbFrom = SubRoutine.FindControl( fImageFilter, "LstSurgery" );
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl( fImageFilter, "LstSurgeryFilter" );
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes( ctllbFrom, ctllbTo );


            //  clear instrumentation
            lbFrom = SubRoutine.FindControl( fImageFilter, "LstInst" );
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl( fImageFilter, "LstInstFilter" );
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes( ctllbFrom, ctllbTo );


            //  clear complication
            lbFrom = SubRoutine.FindControl( fImageFilter, "LstComp" );
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl( fImageFilter, "LstCompFilter" );
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes( ctllbFrom, ctllbTo );


            //  clear pic info
            lbFrom = SubRoutine.FindControl( fImageFilter, "LstPicInfo" );
            ctllbFrom = lbFrom as ListBox;

            lbTo = SubRoutine.FindControl( fImageFilter, "LstPicInfoFilter" );
            ctllbTo = lbTo as ListBox;

            helper.ClearListBoxes( ctllbFrom, ctllbTo );
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
