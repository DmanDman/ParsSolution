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
    public partial class FrmDashboard : Form
    {
        FrmPatient fPatient = new FrmPatient();
        FrmImageSearch fImageSearch = new FrmImageSearch();

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void TSMnuGotoPatient_Click(object sender, EventArgs e)
        {
            fPatient.MdiParent = this;

            fPatient.Show();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            SetPanel_Height();

            StopPanel_Flickering();          
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
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, PnlDashboard, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, PnlImages, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, PnlPatient, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, PnlSurgery, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, PnlRpt, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, PnlData, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, PnlMetaData, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, PnlEmailPic, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, PnlSecurity, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, tableLayoutPanel1, new object[] { true });
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            DashboardAccordian( sender, e );
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
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
            foreach (Panel p in tableLayoutPanel1.Controls )
            {
                Label l = (Label)p.Controls[0];

                if (p.Equals(pnl))
                {
                    // expand or collapse the panel
                    if (p.Height != 25)
                    {                        
                        p.Height = 25;
                        // Change the imaqge name to YOUR image
                        //l.Image = Properties.Resources.Expander_Collapsed16;
                    }
                    else
                    {
                        p.Height = p.Controls.Count * 28;
                        //p.Height = 150;
                        // Change the imaqge name to YOUR image
                        //l.Image = Properties.Resources.Expander_Expanded16;
                    }                
                }
                else
                {
                    p.Height = 25;
                    // Change the imaqge name to YOUR image
                    //l.Image = Properties.Resources.Expander_Collapsed16;
                }
            }
        }

        private void PnlDashboard_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void PnlImages_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void PnlPatient_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void PnlSurgery_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void PnlRpt_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
        }

        private void PnlData_Click(object sender, EventArgs e)
        {
            DashboardAccordian(sender, e);
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

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lblImagesSearch_Click(object sender, EventArgs e)
        {
            fImageSearch.MdiParent = this;

            fImageSearch.Show();
        }
    }
}
