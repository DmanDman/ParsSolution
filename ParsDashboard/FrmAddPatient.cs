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
    public partial class FrmAddPatient : Form
    {
        Helper helper = new Helper();

        #region Form SubRoutines

        public void Clear()
        {
            //  clear personal info
            if ( AddPatientVar.ClearType == 0 )
            {
                helper.ClearTextBox( TxtLastName );
                helper.ClearTextBox( TxtFirstName );
                helper.ClearTextBox( TxtPatNum );
                helper.SetDateToToday( DtStart );
                helper.ClearRadioBtn( RdoMale );
                helper.ClearRadioBtn( RdoFemale );
                helper.ClearMaskedTextBox( MTxtssn );
                TxtLastName.Focus();
            }

            //  clear home
            if ( AddPatientVar.ClearType == 1 )
            {
                helper.ClearTextBox( TxtAddress1 );
                helper.ClearTextBox( TxtAddress2 );
                helper.ClearTextBox( TxtCity );
                helper.ClearComboBoxTxt( CboState );
                helper.ClearMaskedTextBox( MTxtZip );
                helper.ClearMaskedTextBox( MTxtPhone );
                helper.ClearMaskedTextBox( MTxtCell );
                TxtAddress1.Focus();
            }

            //  clear surgery
            if ( AddPatientVar.ClearType == 2 )
            {
                helper.SetDateToToday( DtSurgeryDate );
                helper.SetDateToToday( DtFiscalYear );
                DtSurgeryDate.Focus();
            }
        }

        public void ClearFilterItems()
        {
            helper.ClearListBoxes( LstDr, LstDrFilter );
            helper.ClearListBoxes( LstHospital, LstHospitalFilter );
            helper.ClearListBoxes( LstLocation, LstLocationFIlter );
            helper.ClearListBoxes( LstLevel, LstLevelFilter );
            helper.ClearListBoxes( LstCpt, LstCptFilter );
            helper.ClearListBoxes( LstDx, LstDxFilter );
            helper.ClearListBoxes( LstSurgery, LstSurgeryFilter );
            helper.ClearListBoxes( LstInst, LstInstFilter );
            helper.ClearListBoxes( LstComp, LstCompFilter );
            helper.ClearListBoxes( LstPicInfo, LstPicInfoFilter );
            helper.ClearListBoxes( LstPicInfo, LstPicInfoFilter );
        }

        #endregion

        public static class AddPatientVar
        {
            public static int ClearType { get; set; }
        }

        public FrmAddPatient()
        {
            InitializeComponent();
        }

        private void TabPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  set the tab number: 0 personal info; 1 home; 2 surgery
            AddPatientVar.ClearType = TabPatient.SelectedIndex;
        }

        private void TSMnuAddNewClearPatient_Click(object sender, EventArgs e)
        {
            //  clear form
            Clear();
        }

        private void LstDrFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstDrFilter, LstDr );
        }

        private void LstDr_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstDr, LstDrFilter );
        }

        private void LstHospitalFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstHospitalFilter, LstHospital );
        }

        private void LstHospital_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstHospital, LstHospitalFilter );
        }

        private void LstLocationFIlter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstLocationFIlter, LstLocation );
        }

        private void LstLocation_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstLocation, LstLocationFIlter );
        }

        private void LstLevelFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstLevelFilter, LstLevel );
        }

        private void LstLevel_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstLevel, LstLevelFilter );
        }

        private void LstCptFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstCptFilter, LstCpt );
        }

        private void LstCpt_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstCpt, LstCptFilter );
        }

        private void LstDxFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstDxFilter, LstDx );
        }

        private void LstDx_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstDx, LstDxFilter );
        }

        private void LstSurgeryFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstSurgeryFilter, LstSurgery );
        }

        private void LstSurgery_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstSurgery, LstSurgeryFilter );
        }

        private void LstInstFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstInstFilter, LstInst );
        }

        private void LstInst_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstInst, LstInstFilter );
        }

        private void LstCompFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstCompFilter, LstComp );
        }

        private void LstComp_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstComp, LstCompFilter );
        }

        private void LstPicInfoFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstPicInfoFilter, LstPicInfo );
        }

        private void LstPicInfo_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstPicInfo, LstPicInfoFilter );
        }

        private void TSMnuAddNewClearSurgery_Click(object sender, EventArgs e)
        {
            //  clear filter items
            ClearFilterItems();
        }
    }
}
