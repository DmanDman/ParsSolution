using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParsDashboard
{
    public partial class FrmDashboard : Form
    {
        FrmPatient fPatient = new FrmPatient();

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
            PnlDashboard.Height = 25;
            PnlImages.Height = 25;
            PnlPatient.Height = 25;
            PnlSurgery.Height = 25;
            PnlRpt.Height = 25;
            PnlData.Height = 25;

            //Label1Dash.Image = Properties.Resources.Expander_Collapsed16; // use your down arrow image
            //Label2.Image = Properties.Resources.Expander_Collapsed16; // use your down arrow image
            //Label3.Image = Properties.Resources.Expander_Collapsed16; // use your down arrow image
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
                        p.Height = p.Controls.Count * 30;
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

        private void PnlSurgery_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlRpt_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
