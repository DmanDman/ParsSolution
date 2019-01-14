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
    public partial class FrmImageFilter : Form
    {
        FrmFilterAge fFilterAge = new FrmFilterAge();
        FrmFilterDate fFilterDate = new FrmFilterDate();

        Helper helper = new Helper();

        public static class FilterVar
        {
            public static string FilterDate { get; set; }
            public static string FilterAge { get; set; }
        }

        public FrmImageFilter()
        {
            InitializeComponent();            
        }

        private void ChkSurgeryAge_Click(object sender, EventArgs e)
        {
            if ( ChkSurgeryAge.Checked )
            {
                AGECANCEL = false;
                FORMLOADED = Tag.ToString();

                fFilterAge.ShowDialog();

                FORMLOADED = "";

                TxtSurgeryAge.Text = FilterVar.FilterAge;
            }
        }

        private void ChkSurgeryDate_Click(object sender, EventArgs e)
        {
            if ( ChkSurgeryDate.Checked )
            {
                fFilterDate.ShowDialog();

                TxtSurgeryDate.Text = FilterVar.FilterDate;       
                
                if ( TxtSurgeryDate.Text.Contains( "Between" ))
                {
                    TxtSurgeryDate.Height = 32;
                }
                else
                {
                    TxtSurgeryDate.Height = 22;
                }
            }
        }       

        private void ChkSurgeryAge_CheckedChanged(object sender, EventArgs e)
        {
            if ( !ChkSurgeryAge.Checked )
            {
                TxtSurgeryAge.Text = "";
            }
        }

        private void ChkSurgeryDate_CheckedChanged(object sender, EventArgs e)
        {
            if ( !ChkSurgeryDate.Checked )
            {
                TxtSurgeryDate.Text = "";
                TxtSurgeryDate.Height = 22;
            }
        }

        private void ChkDOB_CheckedChanged(object sender, EventArgs e)
        {
            if ( !ChkDOB.Checked )
            {                
                DtDOB.Value = DateTime.Today; 
            }
        }

        private void ChkLastName_CheckedChanged(object sender, EventArgs e)
        {
            if ( !ChkLastName.Checked )
            {
                TxtLastName.Text = "";                
            }
        }

        private void ChkFirstName_CheckedChanged(object sender, EventArgs e)
        {
            if ( !ChkFirstName.Checked )
            {
                TxtFirstName.Text = "";
            }
        }

        private void ChkSex_CheckedChanged(object sender, EventArgs e)
        {
            if ( !ChkSex.Checked )
            {
                RdoMale.Checked = false;
                RdoFemale.Checked = false;
            }
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
    }
}
