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
    public partial class FrmDataLink : Form
    {
        Helper helper = new Helper();

        #region Form SubRoutines

        public void ClearFrom()
        {
            helper.ClearComboBoxTxt( CboLinkFromType );
            helper.ClearComboBoxTxt( CboLinkFromDetail );

            CboLinkFromType.Focus();
        }

        public void ClearTo()
        {
            helper.ClearComboBoxTxt( CboLinkToType );
            helper.ClearComboBoxTxt( CboLinkToDetail );

            CboLinkToType.Focus();
        }
       
        public void ClearAll()
        {
            ClearFrom();
            ClearTo();

            CboLinkFromType.Focus();
        }

        #endregion

        public FrmDataLink()
        {
            InitializeComponent();
        }

        private void TSMnuDataLinkClearFrom_Click(object sender, EventArgs e)
        {
            ClearFrom();
        }

        private void TSMnuDataLinkClearTo_Click(object sender, EventArgs e)
        {
            ClearTo();
        }

        private void TSMnuDataLinkClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void FrmDataLink_Load(object sender, EventArgs e)
        {
            //// Enable double duffering to stop flickering.
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            SetStyle(ControlStyles.Opaque, false);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }
}
