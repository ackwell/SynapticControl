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
    public partial class AppEdit : Form
    {
        private string appKey;

        public AppEdit(string appKey)
        {
            InitializeComponent();
            this.appKey = appKey;
        }
    }
}
