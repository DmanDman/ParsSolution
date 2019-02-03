using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParsDashboard.Globals;

namespace ParsDashboard
{
    public partial class FrmPicOnly : Form
    {
        //  define forms
        FormNav fNav = new FormNav();

        SubRoutine SubRtn = new SubRoutine();

        public FrmPicOnly()
        {
            InitializeComponent();
        }

        private void TSMnuPicOnlySave_Click(object sender, EventArgs e)
        {
            FrmAddImageDesc fAddImageDesc = new FrmAddImageDesc();

            SAVEPICTONEW = false;
            SAVEPICTOEXISTING = false;
            SAVEPICONLY = false;

            bool bSearchFound = false;
            bool bMainFound = false;

            fAddImageDesc.ShowDialog();

            //  save pics to existing patient
            if ( SAVEPICTOEXISTING == true )
            {                              
                foreach ( Form f in Application.OpenForms )
                {
                    if ( f.Tag.ToString() == "FrmImageSearchResults" )
                    {                        
                        f.BringToFront();
                        bSearchFound = true;                       
                    }

                    if ( f.Tag.ToString() == "FrmMain" )
                    {
                        Control lbl = SubRoutine.FindControl( f, "LblImages" );
                        Label ctllbl = lbl as Label;

                        Control pnl = SubRoutine.FindControl( f, "tableLayoutPanel1" );
                        TableLayoutPanel ctlpnl = pnl as TableLayoutPanel;

                        SubRtn.DashboardAccordian( ctllbl, e, ctlpnl );

                        lbl = SubRoutine.FindControl( f, "LblImagesSearchResults" );
                        ctllbl = lbl as Label;

                        SubRtn.NavSetStyleClickSub( ctllbl );

                        bMainFound = true;
                    }

                    if ( bSearchFound == true && bMainFound == true )
                    {
                        break;
                    }
                }                
            }

            //  save pics to new patient
            if ( SAVEPICTONEW == true )
            {
                foreach ( Form f in Application.OpenForms )
                {
                    if ( f.Tag.ToString() == "FrmImageSearchResults" )
                    {
                        f.BringToFront();
                        bSearchFound = true;
                    }

                    if ( f.Tag.ToString() == "FrmMain" )
                    {
                        Control lbl = SubRoutine.FindControl(f, "LblImages");
                        Label ctllbl = lbl as Label;

                        Control pnl = SubRoutine.FindControl( f, "tableLayoutPanel1" );
                        TableLayoutPanel ctlpnl = pnl as TableLayoutPanel;

                        SubRtn.DashboardAccordian( ctllbl, e, ctlpnl );

                        lbl = SubRoutine.FindControl( f, "LblImagesSearchResults" );
                        ctllbl = lbl as Label;

                        SubRtn.NavSetStyleClickSub( ctllbl );

                        bMainFound = true;
                    }

                    if ( bSearchFound == true && bMainFound == true )
                    {
                        break;
                    }
                }
            }

            //  save pics only
            if ( SAVEPICONLY == true )
            {
                foreach ( Form f in Application.OpenForms )
                {
                    if ( f.Tag.ToString() == "FrmImageSearchResults" )
                    {
                        f.BringToFront();
                        bSearchFound = true;
                    }

                    if ( f.Tag.ToString() == "FrmMain" )
                    {
                        Control lbl = SubRoutine.FindControl( f, "LblImages" );
                        Label ctllbl = lbl as Label;

                        Control pnl = SubRoutine.FindControl( f, "tableLayoutPanel1" );
                        TableLayoutPanel ctlpnl = pnl as TableLayoutPanel;

                        SubRtn.DashboardAccordian( ctllbl, e, ctlpnl );

                        lbl = SubRoutine.FindControl( f, "LblImagesSearchResults" );
                        ctllbl = lbl as Label;

                        SubRtn.NavSetStyleClickSub( ctllbl );

                        bMainFound = true;
                    }

                    if (bSearchFound == true && bMainFound == true)
                    {
                        break;
                    }
                }
            }
             
        fAddImageDesc.Close();

        }
    }
}
