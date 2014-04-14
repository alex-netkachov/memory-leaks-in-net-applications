using System;
using System.Management;

class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        // Initialize management object:
        var obj = new ManagementObject("win32_logicaldisk.deviceid=\"C:\"");
        // Get() creates COM object that should be finalized in the same thread:
        obj.Get();
        // All other finalizable object will not be finalized because
        // COM object is first in the finalization queue and finalizing
        // it requires the main STA thread being stopped. For example,
        // with the following lines:
        // GC.Collect();
        // GC.WaitForPendingFinalizers();
        do
        {
            new BigTable();

            // Wait 5 milliseconds - otherwise the memory will be consumed in a few seconds:
            var start = DateTime.Now;
            while (DateTime.Now.Subtract(start).TotalMilliseconds < 5) ;
        } while (true);
    }
}
