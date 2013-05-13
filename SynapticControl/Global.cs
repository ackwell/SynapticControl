using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynapticControl
{
    class Global
    {
        private static string SYNAPTICS_ROOT = @"SOFTWARE\Synaptics";

        public static string
            REG_APP_EXECUTABLES = SYNAPTICS_ROOT + @"\SynTPEnh\OSD\TouchPad\AppProfiles",

            DEFAULT_APP_NAME="(Default)";
    }
}
