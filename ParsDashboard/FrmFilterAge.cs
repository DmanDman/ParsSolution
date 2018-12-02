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
    public partial class FrmFilterAge : Form
    {
        public FrmFilterAge()
        {
            InitializeComponent();
        }

        private void RdoFilterLessThan_CheckedChanged(object sender, EventArgs e)
        {
            if( RdoFilterLessThan.Checked )
            {
                NumLess.Visible = true;
                LblAnd.Visible = false;
                NumGreater.Visible = false;
            }
        }

        private void RdoFilterGreaterThan_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFilterGreaterThan.Checked )
            {
                NumLess.Visible = true;
                LblAnd.Visible = false;
                NumGreater.Visible = false;
            }
        }

        private void RdoFilterEqualTo_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFilterEqualTo.Checked )
            {
                NumLess.Visible = true;
                LblAnd.Visible = false;
                NumGreater.Visible = false;
            }
        }

        private void RdoFilterBetween_CheckedChanged(object sender, EventArgs e)
        {
            if ( RdoFilterBetween.Checked )
            {
                NumLess.Visible = true;
                LblAnd.Visible = true;
                NumGreater.Visible = true;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if( RdoFilterLessThan.Checked )
            {

            }
              
        }
    }
}
