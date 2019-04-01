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
    public partial class FrmImageSearchResults : Form
    {
        FormNav frmNav = new FormNav();

        public FrmImageSearchResults()
        {
            InitializeComponent();
        }

        private void FrmImageSearchResults_Load(object sender, EventArgs e)
        {
            // Enable double duffering to stop flickering.
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            SetStyle(ControlStyles.Opaque, false);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void TSMnuSurgeryNew_Click(object sender, EventArgs e)
        {
            FrmPatientAddSurgery fPatientAddSurgery = new FrmPatientAddSurgery();

            fPatientAddSurgery.ShowDialog();

            fPatientAddSurgery.Close();
        }
    }
}
