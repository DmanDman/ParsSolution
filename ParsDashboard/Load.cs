using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ParsDashboard
{
    public class LoadForm
    {
        public Boolean isLoaded;
        public Form frmDash;
        public Form frmMain;
        
        public LoadForm( Boolean isLoaded )
        {
            this.isLoaded = false;
        }
        public void LoadDashBoard()
        {
            this.frmDash = new FrmMain();
            this.frmDash.Show();
        }
    }

    public class FormNav
    {
        public Form FrmMain;

        public void ShowForm( Form frm )
        {            
            frm.BringToFront();
            frm.WindowState = FormWindowState.Maximized;
        }

        public void ShowFormName ( Form[] frm, string FrmTagName )
        {
            for ( int i = 0; i <= frm.Count(); i++ )
            {
                if ( frm[i].Tag.ToString() == FrmTagName )
                {
                    frm[i].Show();
                    frm[i].BringToFront();

                    break;
                }
            }
        }
    }
}
