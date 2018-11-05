using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParsDashboard
{
    public class Helper
    {
        public void AddListBoxData( ComboBox combo, ListBox list )
        {
            string sHoldData = null;           

            if ( combo.Text.Trim() == null | combo.Text.Trim() == "" ) 
            {
                string message = "Can not add item, nothing selected.";
                string title = "Search Term Not Selected";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show( message, title, buttons, MessageBoxIcon.Error );
            }
            else
            {
                sHoldData = combo.Text.Trim().ToString();

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
                string message = "Can not remvoe item, nothing selected.";
                string title = "Search Term Not Selected";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show( message, title, buttons, MessageBoxIcon.Error );
            }
            else
            {
                sHoldData = list.SelectedItem.ToString();

                combo.Items.Add( sHoldData );

                list.Items.Remove( sHoldData );

                combo.Sorted = true;
            }            
        }
    }
}
