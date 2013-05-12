using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace SynapticControl
{
    public partial class Main : Form
    {
        public static string REGISTRY_SYNAPTICS_ROOT = @"SOFTWARE\Synaptics";

        private static string REGISTRY_APP_EXECUTABLES = REGISTRY_SYNAPTICS_ROOT + @"\SynTPEnh\OSD\TouchPad\AppProfiles";

        public Main()
        {
            InitializeComponent();
        }

        private void populateData()
        {
            // Add Default entry
            this.listView_apps.Items.Add(this.createListViewItem("(Default)","---","---","---"));

            // Loop over the applications defined in the registry and add them to the listView
            RegistryKey appExes = Registry.LocalMachine.OpenSubKey(REGISTRY_APP_EXECUTABLES);
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

        private void Main_Load(object sender, System.EventArgs e)
        {
            this.populateData();
            this.resizeColumns();
        }

        private void Main_ResizeEnd(object sender, System.EventArgs e)
        {
            this.resizeColumns();
        }
    }
}
