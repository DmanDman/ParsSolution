using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using static ParsDashboard.Globals;

namespace ParsDashboard
{
    public partial class FrmAddNew : Form
    {
        public static class AddNewVar
        {
            public static int AddNewStep { get; set; }
        }
        #region AddNew Sub-Routines
        private void StopPanel_Flickering()
        {
            // Stop flickering
            StopPanel_FlickeringGroupBox( GrpPatient );
        }

        private void StopPanel_FlickeringGroupBox( GroupBox pnl )
        {
            typeof( GroupBox ).InvokeMember( "DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnl, new object[] { true } );
        }
        #endregion

        public FrmAddNew()
        {
            InitializeComponent();

            AddNewVar.AddNewStep = 1;
        }

        private void FrmAddNew_Load(object sender, EventArgs e)
        {
            //  Hide Home and Surgery tabs
            TabPatient.TabPages.Remove( TabPatientHome );
            TabPatient.TabPages.Remove( TabPatientSurgery );
        }

        private void TSMnuAddNewCont_Click(object sender, EventArgs e)
        {
            switch ( AddNewVar.AddNewStep )
            {
                //  Show home tab
                case 1:
                    TabPatient.TabPages.Insert( 0, TabPatientHome );
                    TabPatient.TabPages.Remove( TabPatientPersonal );

                    AddNewVar.AddNewStep = 2;

                    break;

                //  Show surgery tab
                case 2:
                    TabPatient.TabPages.Insert( 0, TabPatientSurgery );
                    TabPatient.TabPages.Remove( TabPatientHome );

                    AddNewVar.AddNewStep = 3;

                    break;

                //  Show surgery items
                case 3:                    
                    GrpSurgerySelect.Location = new Point(
                                                    GrpPatient.Location.X,
                                                    GrpPatient.Location.Y );                   
                   
                    GrpSurgerySelected.Location = new Point(
                                                      GrpHold.Location.X,
                                                      GrpHold.Location.Y );

                    GrpPatient.Visible = false;
                    GrpSurgerySelect.Visible = true;
                    GrpSurgerySelected.Visible = true;

                    AddNewVar.AddNewStep = 4;

                    break;

                //  Show save
                case 4:
                    TabPatient.TabPages.Remove( TabPatientSurgery );
                    TabPatient.TabPages.Insert( 0, TabPatientPersonal );
                    TabPatient.TabPages.Insert( 1, TabPatientHome );
                    TabPatient.TabPages.Insert( 2, TabPatientSurgery );

                    TSMnuAddNewCont.Visible = false;
                    TSMnuAddNewSave.Visible = true;

                    GrpSurgerySelect.Location = new Point(
                                                    GrpSurgerySelectFromHold.Location.X,
                                                    GrpSurgerySelectFromHold.Location.Y );

                    GrpSurgerySelected.Location = new Point(
                                                      GrpSurgerySelectFromHold.Location.X,
                                                      GrpSurgerySelectFromHold.Location.Y );

                    GrpPatient.Visible = true;
                    GrpSurgerySelect.Visible = true;
                    GrpImages.Visible = true;
                    GrpDesc.Visible = true;
                    GrpSurgerySelected.Visible = false;

                    AddNewVar.AddNewStep = 5;

                    break;

                default:
                    Console.WriteLine( "Default case" );

                    break;
            }
        }

        private void TSMnuAddNewBack_Click(object sender, EventArgs e)
        {
            switch ( AddNewVar.AddNewStep )
            {
                //  Close
                case 1:

                    SAVEPICTONEW = false;

                    this.Close();

                    break;

                //  Show personal tab
                case 2:
                    TabPatient.TabPages.Insert( 0, TabPatientPersonal );
                    TabPatient.TabPages.Remove( TabPatientHome );

                    AddNewVar.AddNewStep = 1;

                    break;

                //  Show home tab
                case 3:
                    TabPatient.TabPages.Remove( TabPatientSurgery );
                    TabPatient.TabPages.Insert( 0, TabPatientHome );                    

                    AddNewVar.AddNewStep = 2;

                    break;

                //  Show patient surgery tab
                case 4:
                    GrpPatient.Visible = true;
                    GrpSurgerySelect.Visible = false;
                    GrpSurgerySelected.Visible = false;

                    AddNewVar.AddNewStep = 3;

                    break;

                //   Show surgery items
                case 5:
                    TabPatient.TabPages.Remove( TabPatientPersonal );
                    TabPatient.TabPages.Remove( TabPatientHome );
                    TabPatient.TabPages.Remove( TabPatientSurgery );
                    TabPatient.TabPages.Insert( 0, TabPatientSurgery );

                    TSMnuAddNewCont.Visible = true;
                    TSMnuAddNewSave.Visible = false;

                    GrpSurgerySelect.Location = new Point(
                                                    GrpPatient.Location.X,
                                                    GrpPatient.Location.Y );

                    GrpSurgerySelected.Location = new Point(
                                                      GrpHold.Location.X,
                                                      GrpHold.Location.Y );

                    GrpPatient.Visible = false;
                    GrpSurgerySelect.Visible = true;
                    GrpImages.Visible = false;
                    GrpDesc.Visible = false;
                    GrpSurgerySelected.Visible = true;

                    AddNewVar.AddNewStep = 4;

                    break;

                default:
                    Console.WriteLine( "Default case" );

                    break;
            }
        }

        private void TSMnuAddNewSave_Click(object sender, EventArgs e)
        {
            SAVEPICTONEW = true;

            this.Close();
        }
    }
}
