﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            this.Text = "SynapticControl - " + this.appKey;

            // If we are editing the (Default) entry, don't need to to registry lookups. Also, lock the text boxes.
            if (this.appKey == Global.DEFAULT_APP_NAME)
            {
                this.panel_appDetails.Enabled = false;
                return;
            }
            
            // Try to open the registry key, won't nessicarily exist though (new keys, etc)
            using (RegistryKey appDetails = Registry.LocalMachine.OpenSubKey(
                    Global.REG_APP_EXECUTABLES + @"\" + this.appKey))
            {
                if (appDetails == null) return;

                // Populate the text boxes
                foreach (KeyValuePair<string, TextBox> pair in this.fieldMap)
                {
                    // Retrieve value if it's there
                    object value = appDetails.GetValue(pair.Key);
                    if (value != null)
                    {
                        pair.Value.Text = value.ToString();
                    }
                }

            }
        }

        private void saveAppDetails()
        {
            // NEEDS TO DELETE EMPTY FIELDS
            // Can't edit (Default) details, so ignore.
            if (this.appKey == Global.DEFAULT_APP_NAME) return;

            // Open the key we are editing, creating it if required
            using (RegistryKey appDetails = Registry.LocalMachine.CreateSubKey(
                Global.REG_APP_EXECUTABLES + @"\" + this.appKey))
                {
                // Read data out of the text boxes, into the app details reg key
                foreach (KeyValuePair<string, TextBox> pair in this.fieldMap)
                {
                    // If it's empty, delete the key (if it exists)
                    if (pair.Value.Text == "")
                    {
                        appDetails.DeleteValue(pair.Key, false);
                        continue;
                    }

                    // Save the values
                    if (pair.Key == "AppMatchType")
                    {
                        int value;
                        if (!int.TryParse(pair.Value.Text, out value)) continue;
                        appDetails.SetValue(pair.Key, value, RegistryValueKind.DWord);
                    }
                    else
                    {
                        string value = pair.Value.Text;
                        appDetails.SetValue(pair.Key, value, RegistryValueKind.String);
                    }
                }
            }
        }

        private void populateActionDetails()
        {
            // We'll want to grab (Default) actions from the Defaults subkey (Duh).
            string basePath = (this.appKey==Global.DEFAULT_APP_NAME?
                Global.REG_DEFAULT_ACTIONS :
                Global.REG_APP_ACTIONS + @"\" + this.appKey);

            foreach (ListViewGroup group in this.listView_actions.Groups)
            {
                // Try to open up the gesture subkey. If it doesn't exist, ignore. ActionEdit will handle it.
                using (RegistryKey appGestureActions = Registry.LocalMachine.OpenSubKey(basePath + @"\" + (string)group.Tag))
                {
                    if (appGestureActions == null) continue;

                    // Load up the individual actions
                    foreach (ListViewItem item in group.Items)
                    {
                        // Make sure the ListItems all have the two SubItems, set default text
                        if (item.SubItems.Count == 1)
                        {
                            item.SubItems.Add(new ListViewItem.ListViewSubItem());
                        }
                        item.SubItems[1].Text = this.appKey==Global.DEFAULT_APP_NAME?"(None)":"(Inherited)";

                        // Get the ActionID. If it's null, got nothin' to do here.
                        int? actionID = (int?)appGestureActions.GetValue((string)item.Tag);
                        if (actionID == null) continue;

                        // Now use the ID to get the pretty name~
                        using (RegistryKey actionDetails = Registry.LocalMachine.OpenSubKey(Global.REG_ACTIONS + @"\" + actionID.ToString()))
                        {
                            item.SubItems[1].Text = actionDetails == null ? "(Invalid)" : (string)actionDetails.GetValue("ShortName");
                        }
                    }
                }
            }
        }

        private void editSelectedItem()
        {
            // If nothing selected (when clicking Edit button), ignore.
            if (this.listView_actions.SelectedItems.Count == 0) return;

            ListViewItem toEdit = this.listView_actions.SelectedItems[0];

            ActionEdit actionEditDialog = new ActionEdit(this.appKey, (string)toEdit.Group.Tag, (string)toEdit.Tag);
            actionEditDialog.ShowDialog(this);

            // Refresh the action data
            this.populateActionDetails();
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

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.saveAppDetails();
            this.Close();
        }

        // Numbers only folks
        private void text_appMatchType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
