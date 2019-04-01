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
    public partial class FrmPatientAddSurgery : Form
    {
        Helper helper = new Helper();

        #region Form SubRoutines

        public void ClearDates()
        {           
            //  clear dates            
            helper.SetDateToToday( DtSurgeryDate );

            helper.SetDateToToday( DtFiscalYear );

            DtSurgeryDate.Focus();
        }

        public void ClearItems()
        {
            //  clear doctor
            helper.ClearListBoxes(LstDr, LstDrFilter);

            //  clear hospital
            helper.ClearListBoxes(LstHospital, LstHospitalFilter);

            //  clear location
            helper.ClearListBoxes(LstLocation, LstLocationFIlter);

            //  clear level
            helper.ClearListBoxes(LstLevel, LstLevelFilter);

            //  clear cpt
            helper.ClearListBoxes(LstCpt, LstCptFilter);

            //  clear Dx
            helper.ClearListBoxes(LstDx, LstDxFilter);

            //  clear surgery
            helper.ClearListBoxes(LstSurgery, LstSurgeryFilter);

            //  clear instrumentation
            helper.ClearListBoxes(LstInst, LstInstFilter);

            //  clear comp
            helper.ClearListBoxes(LstComp, LstCompFilter);

            //  clear PicInfo
            helper.ClearListBoxes(LstPicInfo, LstPicInfoFilter);
        }

        #endregion

        public FrmPatientAddSurgery()
        {
            InitializeComponent();
        }

        private void TSMnuPatientAddSurgeryClearDates_Click(object sender, EventArgs e)
        {
            //  clear dates
            ClearDates();
        }

        private void TSMnuPatientAddSurgeryClearSelected_Click(object sender, EventArgs e)
        {
            //  clear selected items
            ClearItems();
        }

        private void TSMnuPatientAddSurgeryBack_Click(object sender, EventArgs e)
        {
            //  close form
            this.Close();
        }

        private void LstDrFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox( LstDrFilter, LstDr );
        }

        private void LstHospitalFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstHospitalFilter, LstHospital);
        }

        private void LstLocationFIlter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstLocationFIlter, LstLocation);
        }

        private void LstLevelFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstLevelFilter, LstLevel);
        }

        private void LstCptFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstCptFilter, LstCpt);
        }

        private void LstDxFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstDxFilter, LstDx);
        }

        private void LstSurgeryFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstSurgeryFilter, LstSurgery);
        }

        private void LstInstFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstInstFilter, LstInst);
        }

        private void LstCompFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstCompFilter, LstComp);
        }

        private void LstPicInfoFilter_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstPicInfoFilter, LstPicInfo);
        }

        private void LstDr_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstDr, LstDrFilter);
        }

        private void LstHospital_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstHospital, LstHospitalFilter);
        }

        private void LstLocation_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstLocation, LstLocationFIlter);
        }

        private void LstLevel_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstLevel, LstLevelFilter);
        }

        private void LstCpt_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstCpt, LstCptFilter);
        }

        private void LstDx_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstDx, LstDxFilter);
        }

        private void LstSurgery_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstSurgery, LstSurgeryFilter);
        }

        private void LstInst_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstInst, LstInstFilter);
        }

        private void LstComp_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstInst, LstInstFilter);
        }

        private void LstPicInfo_DoubleClick(object sender, EventArgs e)
        {
            helper.AdListBoxToListBox(LstPicInfo, LstPicInfoFilter);
        }
    }
}
