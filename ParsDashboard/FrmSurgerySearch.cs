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
    public partial class FrmSurgerySearch : Form
    {
        Helper helper = new Helper();

        SubRoutineSearch SubRtn = new SubRoutineSearch();

        public static class SurgerySearchVar
        {
            public static int ClearType { get; set; }
        }

        public FrmSurgerySearch()
        {
            InitializeComponent();
        }

        private void RdoSurgeryEqualTo_CheckedChanged(object sender, EventArgs e)
        {
            SubRtn.DateRdoBtn( RdoSurgeryEqualTo, DtStart, DtEnd, LblAnd, true, false, false);            
        }

        private void RdoSurgeryGreater_CheckedChanged(object sender, EventArgs e)
        {
            SubRtn.DateRdoBtn(RdoSurgeryGreater, DtStart, DtEnd, LblAnd, true, false, false);           
        }

        private void RdoSurgeryLess_CheckedChanged(object sender, EventArgs e)
        {
            SubRtn.DateRdoBtn( RdoSurgeryLess, DtStart, DtEnd, LblAnd, true, false, false );            
        }

        private void RdoSurgeryBetween_CheckedChanged(object sender, EventArgs e)
        {
            SubRtn.DateRdoBtn( RdoSurgeryBetween, DtStart, DtEnd, LblAnd, true, true, true );            
        }

        private void RdoFiscalEqualTo_CheckedChanged(object sender, EventArgs e)
        {
            SubRtn.DateRdoBtn( RdoFiscalEqualTo, DtFiscalStart, DtFiscalEnd, LblAndFiscalYear, true, false, false );           
        }

        private void RdoFiscalGreater_CheckedChanged(object sender, EventArgs e)
        {
            SubRtn.DateRdoBtn( RdoFiscalGreater, DtFiscalStart, DtFiscalEnd, LblAndFiscalYear, true, false, false );           
        }

        private void RdoFiscalLess_CheckedChanged(object sender, EventArgs e)
        {
            SubRtn.DateRdoBtn( RdoFiscalLess, DtFiscalStart, DtFiscalEnd, LblAndFiscalYear, true, false, false );           
        }

        private void RdoFiscalBetween_CheckedChanged(object sender, EventArgs e)
        {
            SubRtn.DateRdoBtn( RdoFiscalBetween, DtFiscalStart, DtFiscalEnd, LblAndFiscalYear, true, true, true );            
        }

        private void TabDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            SurgerySearchVar.ClearType = TabDisplay.SelectedIndex;
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
            helper.AdListBoxToListBox( LstInst,  LstInstFilter );
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

        private void RdoFiscalEqualTo_CheckedChanged_1(object sender, EventArgs e)
        {
            SubRtn.DateRdoBtn( RdoFiscalEqualTo, DtFiscalStart, DtFiscalEnd, LblAndFiscalYear, true, false, false );
        }
    }

    public class SubRoutineSearch
    {
        public void DateRdoBtn( RadioButton rd, DateTimePicker dtStart, DateTimePicker dtEnd, 
                                Label lbl, bool startVis, bool endVis, bool lblVis )
        {
            if ( rd.Checked )
            {
                dtStart.Visible = startVis;
                lbl.Visible = lblVis;
                dtEnd.Visible = endVis;
            }
        }
    }
}
