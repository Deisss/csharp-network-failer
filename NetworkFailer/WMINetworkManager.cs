using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace NetworkFailer
{
    /**
     * Manage network threw WMI
     */
    class WMINetworkManager
    {
        /**
         * Run many instance to stop many interface
         */
        private void runMultipleNetworkCommand(String state)
        {
            SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(wmiQuery);
            foreach (ManagementObject item in searchProcedure.Get())
            {
                // Disable or enable the interface
                item.InvokeMethod(state, null);
            }
        }

        /**
         * Start all possible network connection
         */
        public void start()
        {
            runMultipleNetworkCommand("enable");
        }

        /**
         * Stop all possible network connection
         */
        public void stop()
        {
            runMultipleNetworkCommand("disable");
        }
    }
}
