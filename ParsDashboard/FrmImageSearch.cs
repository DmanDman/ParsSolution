﻿using System;
using System.Windows.Forms;

namespace ParsDashboard
{
    public partial class FrmImageSearch : Form
    {
        Helper helper = new Helper();
        FormNav frmNav = new FormNav();    

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

        private void TSMnuSearch_Click(object sender, EventArgs e)
        {
            frmNav.ShowFormName( this.MdiParent.MdiChildren, "FrmImageSearchResults" );           
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
    }
}
