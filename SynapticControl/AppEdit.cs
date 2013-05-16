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

        private void populateActionDetails()
        {
            // Open up the action listing so we can grab data (names) from it.
            RegistryKey actions = Registry.LocalMachine.OpenSubKey(Global.REG_ACTIONS);

            // Loop over the groups, grab the reg key name etc
            foreach (ListViewGroup group in this.listView_actions.Groups)
            {
                string regPath = Global.REG_APP_ACTIONS + @"\" + this.appKey + @"\" + group.Tag;
                // Try to open the key. If it doesn't exist, create it. (handled by the api)
                RegistryKey appActions = Registry.LocalMachine.CreateSubKey(regPath);

                // Loop over the list items in the group, grab reg value if it's set and stuff
                foreach (ListViewItem item in group.Items)
                {
                    string actionKey = (string)item.Tag;
                    int? actionID = (int?)appActions.GetValue(actionKey);
                    string actionName = "(None)"; // Default (used when null)
                    if (actionID != null)
                    {
                        // Work out the action name from the actions reg
                        RegistryKey actionDetails = actions.OpenSubKey(actionID.ToString());
                        actionName = actionDetails==null? "(Invalid)" : (string)actionDetails.GetValue("ShortName");
                    }

                    // Make sure there is a second subitem, etc etc etc
                    if (item.SubItems.Count == 1)
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem());
                    }
                    item.SubItems[1].Text = actionName;
                }

                appActions.Close();
            }

            actions.Close();
        }

        private void editSelectedItem()
        {
            // If nothing selected (when clicking Edit button), ignore.
            if (this.listView_actions.SelectedItems.Count == 0) return;

            ListViewItem toEdit = this.listView_actions.SelectedItems[0];

            ActionEdit actionEditDialog = new ActionEdit(this.appKey, (string)toEdit.Group.Tag, (string)toEdit.Tag);
            actionEditDialog.ShowDialog(this);
        }

        // Resize the ListView's columns to fill the avaliable space
        private void resizeColumns()
        {
            this.listView_actions.Columns[this.listView_actions.Columns.Count - 1].Width = -2;
        }

        // EVENT HANDLERS
        private void AppEdit_Load(object sender, EventArgs e)
        {
            this.populateAppDetails();
            this.populateActionDetails();
            this.resizeColumns();
        }

        private void AppEdit_ResizeEnd(object sender, EventArgs e)
        {
            this.resizeColumns();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            this.editSelectedItem();
        }

        private void listView_actions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.editSelectedItem();
        }
    }
}
