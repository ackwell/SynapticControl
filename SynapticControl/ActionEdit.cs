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
        
        public ActionEdit(string appKey, string gestureKey, string actionKey)
        {
            InitializeComponent();
            this.appKey = appKey;
            this.gestureKey = gestureKey;
            this.actionKey = actionKey;
        }
    }
}
