using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SynapticControl
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // populate the listView with the data from the registry
        private void populateData()
        {
            // Add Default entry
            this.listView_apps.Items.Add(this.createListViewItem(Global.DEFAULT_APP_NAME,"---","---","---"));

            // Loop over the applications defined in the registry and add them to the listView
            RegistryKey appExes = Registry.LocalMachine.OpenSubKey(Global.REG_APP_EXECUTABLES);
            foreach (string subKeyName in appExes.GetSubKeyNames())
            {
                using (RegistryKey tempKey = appExes.OpenSubKey(subKeyName))
                {
                    int appMatchType = Convert.ToInt32(tempKey.GetValue("AppMatchType", -1));
                    this.listView_apps.Items.Add(this.createListViewItem(
                        subKeyName,
                        (string)tempKey.GetValue("AppExe"),
                        (string)tempKey.GetValue("AppClassName"),
                        appMatchType==-1? "" : appMatchType.ToString()
                    ));
                }
            }
            appExes.Close();
        }

        private ListViewItem createListViewItem(string friendlyName, string exe, string className, string matchType)
        {
            ListViewItem item = new ListViewItem(friendlyName);
            item.UseItemStyleForSubItems = false;
            item.Font = new Font(item.Font, FontStyle.Bold);

            item.SubItems.Add(exe);
            item.SubItems.Add(className);
            item.SubItems.Add(matchType);

            return item;
        }

        // Resize the ListView's columns to fill the avaliable space
        private void resizeColumns()
        {
            // First col should be visible.
            ColumnHeader firstCol = this.listView_apps.Columns[0];
            firstCol.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            int remainingWidth = this.listView_apps.Width - firstCol.Width;

            // Resize the column headers
            for (int i = 1; i < this.listView_apps.Columns.Count - 1; i++)
            {
                ColumnHeader head = this.listView_apps.Columns[i];
                head.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                if (head.Width > remainingWidth / (this.listView_apps.Columns.Count - 1))
                {
                    head.Width = remainingWidth / (this.listView_apps.Columns.Count - 1);
                }
            }

            this.listView_apps.Columns[this.listView_apps.Columns.Count - 1].Width = -2;
        }

        private void editSelectedItem()
        {
            // Make sure an item is selected.
            if (this.listView_apps.SelectedItems.Count == 0) return;

            //I've disabled MultiSelect, so if there is something selected, there'll only ever be one.
            ListViewItem item = this.listView_apps.SelectedItems[0];
        }

        private void removeSelectedItem()
        {
            if (this.listView_apps.SelectedItems.Count == 0) return;

            // Get the selected item's main text, it's the Key used through the reg.
            string toRemove = this.listView_apps.SelectedItems[0].Text;
        }

        // EVENT HANDLERS
        private void Main_Load(object sender, System.EventArgs e)
        {
            this.populateData();
            this.resizeColumns();
        }

        private void Main_ResizeEnd(object sender, System.EventArgs e)
        {
            this.resizeColumns();
        }
        
        private void listView_apps_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.editSelectedItem();
        }

        // If the Default entry was selected, disable the Remove button
        private void listView_apps_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.listView_apps.SelectedItems.Count == 0) return;
            if (this.listView_apps.SelectedItems[0].Text == Global.DEFAULT_APP_NAME)
                this.btn_remove.Enabled = false;
            else
                this.btn_remove.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.editSelectedItem();
        }
    }
}
