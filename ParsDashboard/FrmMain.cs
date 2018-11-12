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
        //  define forms

        FormNav fNav = new FormNav();

        FrmDashboard fDashBoard = new FrmDashboard();

        FrmImages fImage = new FrmImages();
        FrmImageSearch fImageSearch = new FrmImageSearch();
        FrmImageSearchResults fImageSearchResuts = new FrmImageSearchResults();

        FrmPatient fPatient = new FrmPatient();


        //  define helper class
        Helper_MouseMove HelpMouseMove = new Helper_MouseMove();


        public FrmMain()
        {
            InitializeComponent();
            StopPanel_Flickering();
          
            Load_All_Forms( fPatient );
            Load_All_Forms( fImage );
            Load_All_Forms( fImageSearch );
            Load_All_Forms( fImageSearchResuts );
            Load_All_Forms( fDashBoard );          
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

            StopPanel_FlickeringPanel(PnlDashboard);
            StopPanel_FlickeringPanel(PnlImages);
            StopPanel_FlickeringPanel(PnlPatient);
            StopPanel_FlickeringPanel(PnlSurgery);
            StopPanel_FlickeringPanel(PnlRpt);
            StopPanel_FlickeringPanel(PnlData);
            StopPanel_FlickeringPanel(PnlMetaData);
            StopPanel_FlickeringPanel(PnlEmailPic);
            StopPanel_FlickeringPanel(PnlSecurity);
            StopPanel_FlickeringPanel(tableLayoutPanel1);
        }

        private void StopPanel_FlickeringPanel(Panel pnl)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, pnl, new object[] { true });
        }

        public void DashboardAccordian(Object sender, EventArgs e)
        {
            // find out which label was clicked
            Label lbl = (Label)sender;

            // find the panel containing the label
            Panel pnl = lbl.Parent as Panel;

            // ### this assumes that no other controls are present in the main table ###
            // the code loops through the panels in the table and expands/collapses
            // each panel according to whether it contains the clicked label. The label
            // images are also swapped depending on the height of the panel.
            foreach ( Panel p in tableLayoutPanel1.Controls )
            {
                Label l = (Label)p.Controls[0];

                if ( p.Equals( pnl ))
                {
                    if ( p.Tag != null )
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
                                if ( p.Controls.Count == 3 )
                                {
                                    p.Height = p.Controls.Count * 28;
                                    p.Tag = "Expanded";
                                }
                                else
                                {
                                    p.Height = ( p.Controls.Count - 1 ) * 28;
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

        private void LblPatient_Click(object sender, EventArgs e)
        {
            DashboardAccordian( sender, e );

            fNav.ShowForm( fPatient );

            NavSetStyleClick( LblPatient );
        }

        private void LblSurgery_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void LblRpt_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void LblData_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void LblMetaData_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void LblEmailPic_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void LblSecurity_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void LblDashboard_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);

            NavSetStyleClick( LblDashboard );

            fNav.ShowForm( fDashBoard );
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
            LblImages.Font = new Font(LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LlbImages_MouseLeave(object sender, EventArgs e)
        {
            LblImages.Font = new Font(LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Regular);
        }


        private void NavSetStyleClick(Label lbl)
        {
            Label lblClick = lbl;

            LblDashboard.Font = new Font( LblDashboard.Font.Name, LblDashboard.Font.SizeInPoints, FontStyle.Regular );

            LblImages.Font = new Font( LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Regular );
            LblImagesAdd.Font = new Font( LblImagesAdd.Font.Name, LblImagesAdd.Font.SizeInPoints, FontStyle.Regular );
            LblImagesSearch.Font = new Font( LblImagesSearch.Font.Name, LblImagesSearch.Font.SizeInPoints, FontStyle.Regular );
            LblImagesFilter.Font = new Font( LblImagesFilter.Font.Name, LblImagesFilter.Font.SizeInPoints, FontStyle.Regular );
            LblImagesSearchResults.Font = new Font( LblImagesSearchResults.Font.Name, LblImagesSearchResults.Font.SizeInPoints, FontStyle.Regular );
            LblImagesSearchToPatient.Font = new Font( LblImagesSearchToPatient.Font.Name, LblImagesSearchToPatient.Font.SizeInPoints, FontStyle.Regular );

            LblPatient.Font = new Font( LblPatient.Font.Name, LblPatient.Font.SizeInPoints, FontStyle.Regular );
            LblPatientAdd.Font = new Font( LblPatientAdd.Font.Name, LblPatientAdd.Font.SizeInPoints, FontStyle.Regular );
            LlbPatientSearch.Font = new Font( LlbPatientSearch.Font.Name, LlbPatientSearch.Font.SizeInPoints, FontStyle.Regular ) ;
            LblPatientFilter.Font = new Font(LblPatient.Font.Name, LblPatient.Font.SizeInPoints, FontStyle.Regular );
             
            if ( lblClick.Font.Bold != true )
            {
                lbl.Font = new Font( lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Bold );
            }
            else
            {

            }
        }

        private void LblImages_Click(object sender, EventArgs e)
        {
            DashboardAccordian( sender, e );

            fNav.ShowForm( fImage );

            NavSetStyleClick( LblImages );
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
            DashboardAccordian( sender, e );

            //fNav.ShowForm( fImage );

            //NavSetStyleClick( LblPatientAdd );
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

        private void Load_All_Forms( Form frm )
        {
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.WindowState = FormWindowState.Minimized;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
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
            //fNav.ShowForm(fImageSearch);

            NavSetStyleClick( LblImagesFilter );
        }

        private void LblImagesSearchResults_Click(object sender, EventArgs e)
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
    }
}
