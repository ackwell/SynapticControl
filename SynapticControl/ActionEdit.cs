using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynapticControl
{
    public partial class ActionEdit : Form
    {
        private string
            appKey,
            gestureKey,
            actionKey;

        private List<string> actionIDs = new List<string>();
        
        public ActionEdit(string appKey, string gestureKey, string actionKey)
        {
            InitializeComponent();
            this.appKey = appKey;
            this.gestureKey = gestureKey;
            this.actionKey = actionKey;
        }

        private void populateActions()
        {
            // Grab the action ID the gesture is currently set to
            RegistryKey gestureActionDetails = Registry.LocalMachine.OpenSubKey(
                (this.appKey == Global.DEFAULT_APP_NAME?Global.REG_DEFAULT_ACTIONS:Global.REG_APP_ACTIONS + @"\" + this.appKey)
                + @"\" + this.gestureKey);
            string currentActionID =  gestureActionDetails.GetValue(this.actionKey).ToString();
            gestureActionDetails.Close();

            // Populate the combobox from the actions subkeys
            RegistryKey actionKeys = Registry.LocalMachine.OpenSubKey(Global.REG_ACTIONS);

            foreach (string actionID in actionKeys.GetSubKeyNames())
            {
                RegistryKey action = actionKeys.OpenSubKey(actionID);
                this.comboBox_action.Items.Add(action.GetValue("ShortName"));
                this.actionIDs.Add(actionID);
                
                if (actionID == currentActionID)
                {
                    this.comboBox_action.SelectedIndex = this.comboBox_action.Items.Count - 1;
                }
                action.Close();
            }

            actionKeys.Close();
        }

        // EVENT HANDLERS
        private void ActionEdit_Load(object sender, EventArgs e)
        {
            populateActions();
        }
    }
}
