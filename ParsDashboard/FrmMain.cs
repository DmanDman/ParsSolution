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
        f fDashBoard = new f();
        FrmPatient fPatient = new FrmPatient();
        FrmImageSearch fImageSearch = new FrmImageSearch();

        public FrmMain()
        {            
            InitializeComponent();
            StopPanel_Flickering();

            fDashBoard.MdiParent = this;
            fDashBoard.Show();

            fPatient.MdiParent = this;
            fPatient.Show();
        }

        private void TSMnuGotoPatient_Click(object sender, EventArgs e)
        {
            fPatient.MdiParent = this;
            fPatient.Show();
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

            StopPanel_FlickeringPanel( PnlDashboard );
            StopPanel_FlickeringPanel( PnlImages );
            StopPanel_FlickeringPanel( PnlPatient );
            StopPanel_FlickeringPanel( PnlSurgery );
            StopPanel_FlickeringPanel( PnlRpt );
            StopPanel_FlickeringPanel( PnlData );
            StopPanel_FlickeringPanel( PnlMetaData );
            StopPanel_FlickeringPanel( PnlEmailPic );
            StopPanel_FlickeringPanel( PnlSecurity );
            StopPanel_FlickeringPanel( tableLayoutPanel1 );          
        }

        private void StopPanel_FlickeringPanel( Panel pnl )
        {
           typeof( Panel ).InvokeMember( "DoubleBuffered",
           BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
           null, pnl, new object[] { true });
        }
       
        public void DashboardAccordian( Object sender, EventArgs e )
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
                Label l = ( Label )p.Controls[0];

                if ( p.Equals( pnl ))
                {
                    // expand or collapse the panel
                    if ( p.Height != 25 )
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
    
        private void LlbImages_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void LblPatient_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
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
       
        private void LblImagesSearch_Click_1(object sender, EventArgs e)
        {
            fImageSearch.MdiParent = this;

            fImageSearch.Show();
        }

        private void LblDashboard_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }
    }
}
