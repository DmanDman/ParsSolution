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
    public partial class FrmSecurity : Form
    {
        public FrmSecurity()
        {
            InitializeComponent();
        }

        private void FrmSecurity_Load(object sender, EventArgs e)
        {
            GrpCurrentDBUser.Left = GrpHoldCurrent.Left;
            GrpExistingUsers.Left = GrpHoldUsers.Left;
        }
    }
}
