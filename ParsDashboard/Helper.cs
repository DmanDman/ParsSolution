using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace ParsDashboard
{
    public class Helper
    {
        public void DoubleBuffered(Control control, bool enable)
        {
            var doubleBufferPropertyInfo =
                control.GetType().GetProperty( "DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic );

            doubleBufferPropertyInfo.SetValue( control, enable, null );
        }

        public void AdListBoxToListBox( ListBox listFrom, ListBox listTo )
        {
            string sHoldData;

            if ( listFrom.SelectedIndex == -1 )
            {
                //string message = "Can not remvoe item, nothing selected.";
                //string title = "Search Term Not Selected";

                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                //MessageBox.Show( message, title, buttons, MessageBoxIcon.Error );
            }
            else
            {
                sHoldData = listFrom.SelectedItem.ToString().Trim();

                listTo.Items.Add( sHoldData );

                listFrom.Items.Remove( sHoldData );

                listTo.Sorted = true;
            }
        }

        public void AddListBoxData( ComboBox combo, ListBox list )
        {
            string sHoldData = null;           

            if ( combo.Text.Trim() == null | combo.Text.Trim() == "" | combo.SelectedItem == null ) 
            {
                //string message = "Can not add item, nothing selected.";
                //string title = "Search Term Not Selected";

                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                //MessageBox.Show( message, title, buttons, MessageBoxIcon.Error );
            }
            else
            {                
                sHoldData = combo.SelectedItem.ToString().Trim();
                
                list.Items.Add( sHoldData );

                combo.Items.Remove( sHoldData );

                list.Sorted = true;
            }            
        }

        public void AddComboBox( ComboBox combo, ListBox list )
        {
            string sHoldData;

            if ( list.SelectedIndex == -1 )
            {
                //string message = "Can not remvoe item, nothing selected.";
                //string title = "Search Term Not Selected";

                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                //MessageBox.Show( message, title, buttons, MessageBoxIcon.Error );
            }
            else
            {
                sHoldData = list.SelectedItem.ToString().Trim();

                combo.Items.Add( sHoldData );

                list.Items.Remove( sHoldData );

                combo.Sorted = true;
            }            
        }

        public void RemoveAllListBox( ComboBox combo, ListBox list )
        {
            string sHoldData;
            int x = list.Items.Count;
            
            for ( int i = list.Items.Count - 1; i >= 0; i-- )
            {
                list.SelectedIndex = i;

                sHoldData = list.SelectedItem.ToString().Trim();

                list.Items.RemoveAt( i );

                combo.Items.Add( sHoldData );            
            }

            combo.Sorted = true;            
        }
        
        public void ClearAllCheckBoxes( GroupBox gb )
        {
            var checkBoxes = gb.Controls.OfType<CheckBox>();

            foreach ( CheckBox cb in checkBoxes )
            {
                cb.Checked = false;                
            }
        }

        public void ClearListBoxes( ListBox listFrom, ListBox listTo )
        {
            string sHoldData;
            int x = listFrom.Items.Count;

            for ( int i = listFrom.Items.Count - 1; i >= 0; i-- )
            {
                listFrom.SelectedIndex = i;

                sHoldData = listFrom.SelectedItem.ToString().Trim();

                listFrom.Items.RemoveAt( i );

                listTo.Items.Add( sHoldData );
            }

            listTo.Sorted = true;
        }

        public void ClearUpDwn( DomainUpDown domainupdwm )
        {
            domainupdwm.Text = "";
        }

        public void ClearComboBox( ComboBox cbo )
        {
            cbo.Items.Clear();
            cbo.Text = "";
        }

        public void ClearComboBoxTxt( ComboBox cbo )
        {
            cbo.Text = "";
        }

        public void ClearTextBox ( TextBox txt )
        {
            txt.Text = "";
            txt.Focus();
        }

        public void ClearCheckBox( CheckBox chk )
        {
            chk.Checked = false;
        }

        public void ClearRadioBtn( RadioButton rdo )
        {
            rdo.Checked = false;
        }

        public void SetDateToToday( DateTimePicker dt )
        {
            dt.Value = DateTime.Today;
        }
    }

    public class Helper_MouseMove
    {
        public void MouseEnter( Label  lbl )
        {
            if ( lbl.Font.Bold != true )
            {
                lbl.Font = new Font( lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Underline );
            }
        }

        public void MouseLeave( Label lbl )
        {
            if ( lbl.Font.Bold != true )
            {
                lbl.Font = new Font( lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Regular );
            }
        }        
    }
}
