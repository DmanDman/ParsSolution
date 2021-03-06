﻿using System;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Input;
using System.Drawing;
using System.Reflection;

namespace ParsDashboard
{
    public partial class FrmImageSearch : Form
    {
        SubRoutine SubRtnMain = new SubRoutine();

        Helper helper = new Helper();
        FormNav frmNav = new FormNav();

        public FrmMain fMain;

        public FrmImageSearch()
        {
            InitializeComponent();
            helper.DoubleBuffered( LstMetaDataSearchTerms, true );            
        }          

        private void ChkMeataOnly_Click(object sender, EventArgs e)
        {
            if ( ChkMeataOnly.Checked )
            {
                RdoMetaAnd.Checked = false;
                RdoMetaOr.Checked = false;
            }
        }

        private void RdoMetaAnd_Click(object sender, EventArgs e)
        {
            if ( RdoMetaAnd.Checked )
            {
                ChkMeataOnly.Checked = false;                
            }
        }

        private void RdoMetaOr_Click(object sender, EventArgs e)
        {
            if ( RdoMetaOr.Checked )
            {
                ChkMeataOnly.Checked = false;
            }
        }

        private void RdoPicInfoAnd_Click(object sender, EventArgs e)
        {
            if ( RdoPicInfoAnd.Checked )
            {
                ChkPicInfoOnly.Checked = false;
            }
        }

        private void RdoPicInfoOr_Click(object sender, EventArgs e)
        {
            if ( RdoPicInfoOr.Checked )
            {
                ChkPicInfoOnly.Checked = false;
            }
        }

        private void ChkPicInfoOnly_Click(object sender, EventArgs e)
        {
            if ( ChkPicInfoOnly.Checked )
            {
                RdoPicInfoOr.Checked = false;
                RdoPicInfoAnd.Checked = false;
            }
        }

        private void TSMnuAddMeta_Click(object sender, EventArgs e)
        {
            helper.AddListBoxData( CboMetaSearch, LstMetaDataSearchTerms );       
        }

        private void TSMnuRemoveMeta_Click(object sender, EventArgs e)
        {
            helper.AddComboBox( CboMetaSearch, LstMetaDataSearchTerms );
        }

        private void LstMetaDataSearchTerms_DoubleClick(object sender, EventArgs e)
        {
            helper.AddComboBox( CboMetaSearch, LstMetaDataSearchTerms );
        }

        private void TSMnuAddInfo_Click(object sender, EventArgs e)
        {
            helper.AddListBoxData( CboPicInfo, LstPicInfoSearchItems );
        }

        private void TSMnuRemoveInfo_Click(object sender, EventArgs e)
        {
            helper.AddComboBox( CboPicInfo, LstPicInfoSearchItems );
        }

        private void LstPicInfoSearchItems_DoubleClick(object sender, EventArgs e)
        {
            helper.AddComboBox( CboPicInfo, LstPicInfoSearchItems );
        }

        private void TSMnuRemoveAllMeta_Click(object sender, EventArgs e)
        {
            helper.RemoveAllListBox( CboMetaSearch, LstMetaDataSearchTerms );
        }

        private void TsMnuRemoveAllPic_Click(object sender, EventArgs e)
        {
            helper.RemoveAllListBox( CboPicInfo, LstPicInfoSearchItems );
        }

        public void TSMnuSearch_Click(object sender, EventArgs e)
        {            
            //  loop through open forms
            foreach ( Form f in Application.OpenForms )
            {
                //  show Image Search Results
                if ( f.Tag.ToString() == "FrmImageSearchResults" )
                {
                    f.BringToFront();
                }

                //  set navigation label to selected on main form
                if ( f.Tag.ToString() == "FrmMain" )
                {
                    Control lbl = SubRoutine.FindControl( f, "LblImagesSearchResults" );
                    Label ctllbl = lbl as Label;

                    SubRtnMain.NavSetStyleClickSub( ctllbl );

                    //  set label LblImagesSearch to not bold
                    lbl = SubRoutine.FindControl( f, "LblImagesSearch" );
                    ctllbl = lbl as Label;

                    ctllbl.Font = new Font( ctllbl.Font.Name, ctllbl.Font.SizeInPoints, FontStyle.Regular );
                }
            }
        }

        private void FrmImageSearch_Load(object sender, EventArgs e)
        {
            // Enable double duffering to stop flickering.
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            SetStyle(ControlStyles.Opaque, false);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
     
        private void CboMetaSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //  if enter key is pressed
            if ( e.KeyCode == Keys.Enter )
            {
                //  check if entered text is in list
                Int32 TextExist = CboMetaSearch.FindStringExact( CboMetaSearch.Text );
                
                //  if yes, add to list box and remove from combo box
                if ( TextExist != ListBox.NoMatches )
                {
                    helper.AddListBoxData( CboMetaSearch, LstMetaDataSearchTerms );
                }
            }
        }

        private void CboPicInfo_KeyUp(object sender, KeyEventArgs e)
        {
            //  if enter key is pressed
            if ( e.KeyCode == Keys.Enter )
            {
                //  check if entered text is in list
                Int32 TextExist = CboPicInfo.FindStringExact( CboPicInfo.Text );

                //  if yes, add to list box and remove from combo box
                if ( TextExist != ListBox.NoMatches )
                {
                    helper.AddListBoxData( CboPicInfo, LstPicInfoSearchItems );
                }
            }
        }

        private void TsMnuImageSearchMetaDataAdd_Click(object sender, EventArgs e)
        {
            helper.AddListBoxData( CboMetaSearch, LstMetaDataSearchTerms );
        }

        private void TsMnuImageSearchMetaDataRemove_Click(object sender, EventArgs e)
        {
            helper.AddComboBox( CboMetaSearch, LstMetaDataSearchTerms );
        }

        private void TsMnuImageSearchMetaDataRemoveAll_Click(object sender, EventArgs e)
        {
            helper.RemoveAllListBox( CboMetaSearch, LstMetaDataSearchTerms );
        }

        private void TSMnuSearchPicInfoAdd_Click(object sender, EventArgs e)
        {
            helper.AddListBoxData( CboPicInfo, LstPicInfoSearchItems );
        }

        private void TSMnuSearchPicInfoRemove_Click(object sender, EventArgs e)
        {
            helper.AddComboBox( CboPicInfo, LstPicInfoSearchItems );
        }

        private void TSMnuSearchPicInfoRemoveAll_Click(object sender, EventArgs e)
        {
            helper.RemoveAllListBox( CboPicInfo, LstPicInfoSearchItems );
        }
    }
}
