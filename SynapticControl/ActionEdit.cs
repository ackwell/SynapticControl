using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SynapticControl
{
    public partial class ActionEdit : Form
    {
        private string
            appKey,
            gestureKey,
            actionKey,
            
            nullValue;

        private List<int> actionIDs = new List<int>();
        
        public ActionEdit(string appKey, string gestureKey, string actionKey)
        {
            InitializeComponent();
            this.appKey = appKey;
            this.gestureKey = gestureKey;
            this.actionKey = actionKey;
        }

        private void populateActions()
        {
            this.nullValue = this.appKey == Global.DEFAULT_APP_NAME ? "(None)" : "(Inherited)";
            this.comboBox_action.Items.Add(this.nullValue);
            this.actionIDs.Add(-1); // Dummy value because of offset introduced by ^
            this.comboBox_action.SelectedIndex = 0;

            string currentActionID;

            // Grab the action ID the gesture is currently set to
            using (RegistryKey gestureActionDetails = Registry.LocalMachine.OpenSubKey(
                 (this.appKey == Global.DEFAULT_APP_NAME ? Global.REG_DEFAULT_ACTIONS :
                 Global.REG_APP_ACTIONS + @"\" + this.appKey) + @"\" + this.gestureKey))
            {
                currentActionID = "";
                object temp = gestureActionDetails.GetValue(this.actionKey);
                if (temp != null)
                {
                    currentActionID = temp.ToString();
                }
            }

            // Populate the combobox from the actions subkeys
            using (RegistryKey actionKeys = Registry.LocalMachine.OpenSubKey(Global.REG_ACTIONS))
            {
                foreach (string actionID in actionKeys.GetSubKeyNames())
                {
                    using (RegistryKey action = actionKeys.OpenSubKey(actionID))
                    {
                        this.comboBox_action.Items.Add(action.GetValue("ShortName"));
                        this.actionIDs.Add(int.Parse(actionID));

                        if (actionID == currentActionID)
                        {
                            this.comboBox_action.SelectedIndex = this.comboBox_action.Items.Count - 1;
                        }
                    }
                }
            }
        }

        private void saveAction()
        {
            using (RegistryKey gestureActionDetails = Registry.LocalMachine.OpenSubKey(
                 (this.appKey == Global.DEFAULT_APP_NAME ? Global.REG_DEFAULT_ACTIONS :
                 Global.REG_APP_ACTIONS + @"\" + this.appKey) + @"\" + this.gestureKey, true))
            {
                if (this.comboBox_action.Text == this.nullValue)
                {
                    // If it was changed to/left at the null value, try to delete the value
                    gestureActionDetails.DeleteValue(this.actionKey, false);
                }
                else
                {
                    // Otherwise, save it out
                    int id = this.actionIDs[this.comboBox_action.SelectedIndex];
                    gestureActionDetails.SetValue(this.actionKey, id, RegistryValueKind.DWord);
                }
            }
            
        }

        // EVENT HANDLERS
        private void ActionEdit_Load(object sender, EventArgs e)
        {
            this.populateActions();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.saveAction();
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
