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
        FormNav fNav = new FormNav();

        FrmDashboard fDashBoard = new FrmDashboard();

        FrmImages fImage = new FrmImages();
        FrmImageSearch fImageSearch = new FrmImageSearch();
        FrmImageSearchResults fImageSearchResuts = new FrmImageSearchResults();

        FrmPatient fPatient = new FrmPatient();

        public FrmMain()
        {
            InitializeComponent();
            StopPanel_Flickering();

            fDashBoard.MdiParent = this;
            fDashBoard.Show();

            fPatient.MdiParent = this;
            fPatient.Show();
           
            fImage.MdiParent = this;
            fImage.Show();

            fImageSearch.MdiParent = this;
            fImageSearch.Show();

            fImageSearchResuts.MdiParent = this;
            fImageSearchResuts.Show();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            SetPanel_Height();
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
            foreach (Panel p in tableLayoutPanel1.Controls)
            {
                Label l = (Label)p.Controls[0];

                if (p.Equals(pnl))
                {
                    // expand or collapse the panel
                    if (p.Height != 25)
                    {
                        p.Height = 25;
                    }
                    else
                    {
                        p.Height = p.Controls.Count * 28;
                    }
                }
                else
                {
                    p.Height = 25;
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
            if ( LblImagesAdd.Font.Bold != true )           
            {
                LblImagesAdd.Font = new Font( LblImagesAdd.Font.Name, LblImagesAdd.Font.SizeInPoints, FontStyle.Underline );
            }
        }

        private void LblImagesAdd_MouseLeave(object sender, EventArgs e)
        {
            if (LblImagesAdd.Font.Bold != true)
            {
                LblImagesAdd.Font = new Font( LblImagesAdd.Font.Name, LblImagesAdd.Font.SizeInPoints, FontStyle.Regular );
            }
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
            if ( LblDashboard.Font.Bold != true )
            { 
                LblDashboard.Font = new Font( LblDashboard.Font.Name, LblDashboard.Font.SizeInPoints, FontStyle.Regular );
            }
        }   

        private void LblImagesSearch_MouseEnter(object sender, EventArgs e)
        {
            if ( LblImagesSearch.Font.Bold != true )
            {            
                LblImagesSearch.Font = new Font( LblImagesSearch.Font.Name, LblImagesSearch.Font.SizeInPoints, FontStyle.Underline );
            }
        }

        private void LblImagesSearch_MouseLeave(object sender, EventArgs e)
        {
            if ( LblImagesSearch.Font.Bold != true )
            { 
                LblImagesSearch.Font = new Font( LblImagesSearch.Font.Name, LblImagesSearch.Font.SizeInPoints, FontStyle.Regular );
            }
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
            LblPatient.Font = new Font( LblPatient.Font.Name, LblPatient.Font.SizeInPoints, FontStyle.Regular );

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
            DashboardAccordian(sender, e);

            fNav.ShowForm(fImage);

            NavSetStyleClick(LblImages);
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
            if ( LblImages.Font.Bold != true )
            {
                LblImages.Font = new Font( LblImages.Font.Name, LblImages.Font.SizeInPoints, FontStyle.Regular );
            }
        }

        private void LblPatient_MouseEnter(object sender, EventArgs e)
        {
            if ( LblPatient.Font.Bold != true )
            {
                LblPatient.Font = new Font( LblPatient.Font.Name, LblPatient.Font.SizeInPoints, FontStyle.Underline );
            }
        }

        private void LblPatient_MouseLeave(object sender, EventArgs e)
        {
            if ( LblPatient.Font.Bold != true )
            {
                LblPatient.Font = new Font( LblPatient.Font.Name, LblPatient.Font.SizeInPoints, FontStyle.Regular );
            }
        }

        private void LblPatientAdd_Click(object sender, EventArgs e)
        {
            DashboardAccordian( sender, e );

            //fNav.ShowForm( fImage );

            //NavSetStyleClick( LblPatientAdd );
        }
    }
}
