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

            fAddImageDesc.ShowDialog();

            //  save pics to existing patient
            if (SAVEPICTOEXISTING == true)
            {
                fNav.ShowFormName(fImageSearchResuts.MdiParent.MdiChildren, "FrmImageSearchResults");

                SubRtn.DashboardAccordian(LblImages, e, tableLayoutPanel1);

                NavSetStyleClick(LblImagesSearchResults);

                SubRtn.ShowHideMenu(this, MnuImageSearchResult.Name);
            }

            //  save pics to new patient
            if (SAVEPICTONEW == true)
            {
                fNav.ShowFormName(fImageSearchResuts.MdiParent.MdiChildren, "FrmImageSearchResults");

                SubRtn.DashboardAccordian(LblImages, e, tableLayoutPanel1);

                NavSetStyleClick(LblImagesSearchResults);

                SubRtn.ShowHideMenu(this, MnuImageSearchResult.Name);
            }

            //  save pics only
            if (SAVEPICONLY == true)
            {
                fNav.ShowFormName(fImageSearchResuts.MdiParent.MdiChildren, "FrmImageSearchResults");

                SubRtn.DashboardAccordian(LblImages, e, tableLayoutPanel1);

                NavSetStyleClick(LblImagesSearchResults);

                SubRtn.ShowHideMenu(this, MnuImageSearchResult.Name);
            }

            fAddImageDesc.Close();
        }
    }
}
