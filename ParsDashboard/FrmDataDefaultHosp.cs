﻿using System;
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
    public partial class FrmDataDefaultHosp : Form
    {
        Helper helper = new Helper();

        #region Form SubRoutines

        public void ClearAvaliableHospital()
        {
            helper.ClearComboBoxTxt( CboAvaliHosp );            
        }

        #endregion

        public FrmDataDefaultHosp()
        {
            InitializeComponent();
        }

        private void TSMnuDataDefaultHospClear_Click(object sender, EventArgs e)
        {
            ClearAvaliableHospital();
        }
    }
}
