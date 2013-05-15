using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SynapticControl
{
    public partial class AppEdit : Form
    {
        private string appKey;

        private Dictionary<string, TextBox> fieldMap;

        public AppEdit(string appKey)
        {
            InitializeComponent();
            this.appKey = appKey;
            this.fieldMap = new Dictionary<string, TextBox>()
            {
                {"AppExe", this.text_appExe},
                {"AppClassName", this.text_appClassName},
                {"AppMatchType", this.text_appMatchType}
            };
        }

        private void populateAppDetails()
        {
            // This much we know withought messing with the reg
            this.text_appKey.Text = this.appKey;
            this.Text = "SynapticControl - " + appKey;

            // If we are editing the (Default) entry, don't need to to registry lookups. Also, lock the text boxes.
            if (appKey == Global.DEFAULT_APP_NAME)
            {
                this.panel_appDetails.Enabled = false;
                return;
            }
            
            // Try to open the registry key, won't nessicarily exist though
            RegistryKey appDetails = Registry.LocalMachine.OpenSubKey(
                    Global.REG_APP_EXECUTABLES + @"\" + this.appKey);
            if (appDetails == null) return;

            // Populate the text boxes
            foreach (KeyValuePair<string, TextBox> pair in this.fieldMap)
            {
                // Retrieve value if it's there
                string value = (string)appDetails.GetValue(pair.Key);
                if (value != null)
                {
                    pair.Value.Text = value;
                }
            }

            appDetails.Close();
        }

        // Resize the ListView's columns to fill the avaliable space
        private void resizeColumns()
        {
            // Resize the column headers
            for (int i = 0; i < this.listView_actions.Columns.Count - 1; i++)
            {
                ColumnHeader head = this.listView_actions.Columns[i];
                head.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                if (head.Width > this.listView_actions.Width / (this.listView_actions.Columns.Count - 1))
                {
                    head.Width = this.listView_actions.Width / (this.listView_actions.Columns.Count - 1);
                }
            }

            this.listView_actions.Columns[this.listView_actions.Columns.Count - 1].Width = -2;
        }

        // EVENT HANDLERS
        private void AppEdit_Load(object sender, System.EventArgs e)
        {
            this.populateAppDetails();
            this.resizeColumns();
        }
    }
}
