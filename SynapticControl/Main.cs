using System.Windows.Forms;
using Microsoft.Win32;
using System;

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
            // Loop over the applications defined in the registry and add them to the listView
            RegistryKey appExes = Registry.LocalMachine.OpenSubKey(REGISTRY_APP_EXECUTABLES);
            foreach (string subKeyName in appExes.GetSubKeyNames())
            {
                ListViewItem item = new ListViewItem(subKeyName);
                using (RegistryKey tempKey = appExes.OpenSubKey(subKeyName))
                {
                    item.SubItems.Add((string)tempKey.GetValue("AppExe"));
                    item.SubItems.Add((string)tempKey.GetValue("AppClassName"));
                    int appMatchType = Convert.ToInt32(tempKey.GetValue("AppMatchType", -1));
                    if (appMatchType != -1)
                    {
                        item.SubItems.Add(appMatchType.ToString());
                    }
                }
                this.listView_apps.Items.Add(item);
            }
            appExes.Close();
        }

        private void resizeColumns()
        {
            // Resize the column headers
            for (int i = 0; i < this.listView_apps.Columns.Count - 1; i++)
            {
                ColumnHeader head = this.listView_apps.Columns[i];
                head.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                if (head.Width > this.listView_apps.Width / this.listView_apps.Columns.Count)
                {
                    head.Width = this.listView_apps.Width / this.listView_apps.Columns.Count;
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
