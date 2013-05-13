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
            REG_APP_EXECUTABLES = SYNAPTICS_ROOT + @"\SynTPEnh\OSD\TouchPad\AppProfiles", // Mappings of app key to app exe/class/etc
            REG_APP_ACTIONS = SYNAPTICS_ROOT + @"\SynTP\Defaults\AppProfiles", // Mappings of app to gesture actions
            REG_ACTIONS = SYNAPTICS_ROOT + @"\SynTPPlugIns\SynTP", // List of gesture actions
            REG_MACROS = SYNAPTICS_ROOT + @"\SynTPEnh\PlugInConfig", // Application mapping for keyboard macros

            DEFAULT_APP_NAME="(Default)";
    }
}
