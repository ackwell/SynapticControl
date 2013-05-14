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

            // Try to open the registry key, won't nessicarily exist though
            RegistryKey appDetails;
            try
            {
                appDetails = Registry.LocalMachine.OpenSubKey(
                    Global.REG_APP_EXECUTABLES + @"\" + this.appKey);
            }
            catch (ArgumentException) { return; }

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

        // EVENT HANDLERS
        private void AppEdit_Load(object sender, System.EventArgs e)
        {
            this.populateAppDetails();
        }
    }
}
