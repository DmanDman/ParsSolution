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
    public partial class FrmDataCustomizeName : Form
    {
        Helper helper = new Helper();
        SubRoutine SubRtn = new SubRoutine();

        #region Form SubRoutines

        public void ClearCusomizeNames()
        {
            helper.ClearTextBox( TxtNewDr );
            helper.ClearTextBox( TxtNewHospital );
            helper.ClearTextBox( TxtNewLocation );
            helper.ClearTextBox( TxtNewLevel );
            helper.ClearTextBox( TxtNewCpt );
            helper.ClearTextBox( TxtNewDx );
            helper.ClearTextBox( TxtNewSurgery );
            helper.ClearTextBox( TxtNewInst );
            helper.ClearTextBox( TxtNewComp );

            TxtNewDr.Focus();
        }

        #endregion
        
        public FrmDataCustomizeName()
        {
            InitializeComponent();
        }

        private void TSMnuDataCustNameClearAll_Click(object sender, EventArgs e)
        {
            ClearCusomizeNames();
        }
    }

    public class SubRoutineFrmDataCustomizeNames
    {
        
    }
}
