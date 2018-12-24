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
    public partial class FrmAddImageDesc : Form
    {
        Helper helper = new Helper();

        Subroutines SubRtn = new Subroutines();

        public FrmAddImageDesc()
        {
            InitializeComponent();
        }

        private void FrmAddImageDesc_Load(object sender, EventArgs e)
        {
            GrpDesc.BringToFront();
            GrpDescFinal.Visible = false;
        }

        private void CboPicInfo_KeyUp(object sender, KeyEventArgs e)
        {
            //  if enter key is pressed
            if ( e.KeyCode == Keys.Enter )
            {
                //  check if entered text is in list
                Int32 TextExist = CboPicInfo.FindStringExact ( CboPicInfo.Text );

                //  if yes, add to list box and remove from combo box
                if ( TextExist != ListBox.NoMatches )
                {                    
                    SubRtn.AddDesc( CboPicInfo, LstImageDesc );
                }
            }
        }

        private void LstImageDesc_DoubleClick(object sender, EventArgs e)
        {            
            SubRtn.RemoveDesc( CboPicInfo, LstImageDesc );
        }

        private void TSMnuAddEmailImagesAdd_Click(object sender, EventArgs e)
        {
            SubRtn.AddDesc( CboPicInfo, LstImageDesc );
        }

        private void TSMnuAddEmailImagesRemove_Click(object sender, EventArgs e)
        {
            SubRtn.RemoveDesc( CboPicInfo, LstImageDesc );
        }

        private void TSMnuAddEmailImagesBack_Click(object sender, EventArgs e)
        {
            //  Group box Descriptors visible
            if ( GrpDesc.Visible == true )
            {
                this.Close();
            }

            //  Group box Add Image visible
            if ( GrpAddImage.Visible == true )
            {
                SubRtn.ShowHideMnu( GrpDesc, GrpAddImage, TSMnuAddEmailImagesAdd, TSMnuAddEmailImagesRemove, TSMnuAddEmailImageSave, TSMnuAddEmailImagesCont,
                                    true,    false,       true,                   true,                      false,                  true );

                GrpDescFinal.Visible = false;
                GrpAddImage.Enabled = true;
            }            
        }

        private void TSMnuAddEmailImagesCont_Click(object sender, EventArgs e)
        {
            //  Group box Descriptors visible
            if ( GrpDesc.Visible == true )
            {
                SubRtn.ShowHideMnu( GrpDesc, GrpAddImage, TSMnuAddEmailImagesAdd, TSMnuAddEmailImagesRemove, TSMnuAddEmailImageSave, TSMnuAddEmailImagesCont,
                                    false,   true,        false,                  false,                     false,                  true );                
            }
            else
            {
                //  Group box Add Image visible and "Add images with no patient, no surgery" is checked
                if ( GrpAddImage.Visible == true && RdoAddNoPatNoSur.Checked ==  true )
                {
                    SubRtn.ShowHideMnu( GrpDescFinal, GrpAddImage, TSMnuAddEmailImagesAdd, TSMnuAddEmailImagesRemove, TSMnuAddEmailImageSave, TSMnuAddEmailImagesCont,
                                        true,         true,        false,                  false,                     true,                   false );

                    GrpAddImage.Enabled = false;
                    
                    helper.CopyListBoxToListBox( LstImageDesc, LstImageDescFinal );
                }
            }
        }
    }

    public class Subroutines
    {
        Helper helper = new Helper();

        public void AddDesc( ComboBox cbo, ListBox lst )
        {
            helper.AddListBoxData( cbo, lst );
        }

        public void RemoveDesc( ComboBox cbo, ListBox lst )
        {
            helper.AddComboBox( cbo, lst );
        }

        public void ShowHideMnu( GroupBox desc, GroupBox addimage, ToolStripMenuItem add, ToolStripMenuItem remove, ToolStripMenuItem save, ToolStripMenuItem cont,
                                 bool descVisible, bool addimageVisible, bool addVisible, bool removeVisible,       bool saveVisible,       bool saveCont )
        {
            //  Set group box visiblility
            desc.Visible = descVisible;
            addimage.Visible = addimageVisible;

            //  Set menu enabled and visibility
            add.Enabled = addVisible;
            remove.Enabled = removeVisible;

            save.Visible = saveVisible;
            cont.Visible = saveCont;
        }
    }
}