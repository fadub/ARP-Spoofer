using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ARP_Spoofer
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string resource1 = "ARP_Spoofer.lib.PacketDotNet.dll";
            string resource2 = "ARP_Spoofer.lib.PcapDotNet.Base.dll";
            string resource3 = "ARP_Spoofer.lib.PcapDotNet.Core.dll";
            string resource4 = "ARP_Spoofer.lib.PcapDotNet.Core.Extensions.dll";
            string resource5 = "ARP_Spoofer.lib.PcapDotNet.Packets.dll";
            EmbeddedAssembly.Load(resource1, "PacketDotNet.dll");
            EmbeddedAssembly.Load(resource2, "PcapDotNet.Base.dll");
            EmbeddedAssembly.Load(resource3, "PcapDotNet.Core.dll");
            EmbeddedAssembly.Load(resource4, "PcapDotNet.Core.Extensions.dll");
            EmbeddedAssembly.Load(resource5, "PcapDotNet.Packets.dll");

            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
