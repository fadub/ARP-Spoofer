using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;
using System.Globalization;
using PcapDotNet;
using PcapDotNet.Base;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Arp;
using PcapDotNet.Packets.Dns;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.Gre;
using PcapDotNet.Packets.Http;
using PcapDotNet.Packets.Icmp;
using PcapDotNet.Packets.Igmp;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace ARP_Spoofer
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        // Definitions: start
        string str_ethernet_sender_mac1 = "";
        string str_ethernet_sender_mac2 = "";
        string str_ethernet_sender_mac3 = "";
        string str_ethernet_sender_mac4 = "";
        string str_ethernet_sender_mac5 = "";
        string str_ethernet_sender_mac6 = "";
        string str_ethernet_destination_mac1 = "";
        string str_ethernet_destination_mac2 = "";
        string str_ethernet_destination_mac3 = "";
        string str_ethernet_destination_mac4 = "";
        string str_ethernet_destination_mac5 = "";
        string str_ethernet_destination_mac6 = "";
        string str_arp_sender_mac1 = "";
        string str_arp_sender_mac2 = "";
        string str_arp_sender_mac3 = "";
        string str_arp_sender_mac4 = "";
        string str_arp_sender_mac5 = "";
        string str_arp_sender_mac6 = "";
        string str_arp_sender_ip1 = "";
        string str_arp_sender_ip2 = "";
        string str_arp_sender_ip3 = "";
        string str_arp_sender_ip4 = "";
        string str_arp_destination_mac1 = "";
        string str_arp_destination_mac2 = "";
        string str_arp_destination_mac3 = "";
        string str_arp_destination_mac4 = "";
        string str_arp_destination_mac5 = "";
        string str_arp_destination_mac6 = "";
        string str_arp_destination_ip1 = "";
        string str_arp_destination_ip2 = "";
        string str_arp_destination_ip3 = "";
        string str_arp_destination_ip4 = "";
        string str_send_interval = "";
        byte byte_arp_sender_ip1;
        byte byte_arp_sender_ip2;
        byte byte_arp_sender_ip3;
        byte byte_arp_sender_ip4;
        byte byte_arp_destination_ip1;
        byte byte_arp_destination_ip2;
        byte byte_arp_destination_ip3;
        byte byte_arp_destination_ip4;
        byte[] bytes_arp_sender_mac;
        byte[] bytes_arp_destination_mac;
        string str_arp_sender_macFull;
        string str_arp_destination_macFull;
        string[] selectedAdapterList;
        int selectedAdapter;
        int int_send_interval;
        protected delegate void setTextMethodDelegate();
        IList<LivePacketDevice> devices = LivePacketDevice.AllLocalMachine;
        Thread sendArpThread;
        int countARPpackets = 0;
        string startIP_net;
        string endIP_net;
        int startIP_host;
        int endIP_host;
        string replyAddress;
        string replyAddressCache;
        string pingIP;
        Ping ping;
        // Definitions: end

        // Events: start
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Do you really want to close 'ARP Spoofer'?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (window == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp form = new FormHelp();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_send_arp_reply_Click(object sender, EventArgs e)
        {
            btn_stop_arp_reply.Enabled = true;
            btn_send_arp_reply.Enabled = false;
            str_ethernet_sender_mac1 = tB_ethernet_sender_mac1.Text;
            str_ethernet_sender_mac2 = tB_ethernet_sender_mac2.Text;
            str_ethernet_sender_mac3 = tB_ethernet_sender_mac3.Text;
            str_ethernet_sender_mac4 = tB_ethernet_sender_mac4.Text;
            str_ethernet_sender_mac5 = tB_ethernet_sender_mac5.Text;
            str_ethernet_sender_mac6 = tB_ethernet_sender_mac6.Text;
            str_ethernet_destination_mac1 = tB_ethernet_destination_mac1.Text;
            str_ethernet_destination_mac2 = tB_ethernet_destination_mac2.Text;
            str_ethernet_destination_mac3 = tB_ethernet_destination_mac3.Text;
            str_ethernet_destination_mac4 = tB_ethernet_destination_mac4.Text;
            str_ethernet_destination_mac5 = tB_ethernet_destination_mac5.Text;
            str_ethernet_destination_mac6 = tB_ethernet_destination_mac6.Text;
            str_arp_sender_mac1 = tB_arp_sender_mac1.Text;
            str_arp_sender_mac2 = tB_arp_sender_mac2.Text;
            str_arp_sender_mac3 = tB_arp_sender_mac3.Text;
            str_arp_sender_mac4 = tB_arp_sender_mac4.Text;
            str_arp_sender_mac5 = tB_arp_sender_mac5.Text;
            str_arp_sender_mac6 = tB_arp_sender_mac6.Text;
            str_arp_sender_ip1 = tB_arp_sender_ip1.Text;
            str_arp_sender_ip2 = tB_arp_sender_ip2.Text;
            str_arp_sender_ip3 = tB_arp_sender_ip3.Text;
            str_arp_sender_ip4 = tB_arp_sender_ip4.Text;
            str_arp_destination_mac1 = tB_arp_destination_mac1.Text;
            str_arp_destination_mac2 = tB_arp_destination_mac2.Text;
            str_arp_destination_mac3 = tB_arp_destination_mac3.Text;
            str_arp_destination_mac4 = tB_arp_destination_mac4.Text;
            str_arp_destination_mac5 = tB_arp_destination_mac5.Text;
            str_arp_destination_mac6 = tB_arp_destination_mac6.Text;
            str_arp_destination_ip1 = tB_arp_destination_ip1.Text;
            str_arp_destination_ip2 = tB_arp_destination_ip2.Text;
            str_arp_destination_ip3 = tB_arp_destination_ip3.Text;
            str_arp_destination_ip4 = tB_arp_destination_ip4.Text;
            str_send_interval = tB_send_interval.Text;
            if (cB_select_adapter.SelectedItem == null)
            {
                lbl_status.Text = "ERROR: Select an adapter first!";
                btn_send_arp_reply.Enabled = true;
                btn_stop_arp_reply.Enabled = false;
                return;
            }
            else
            {
                selectedAdapterList = cB_select_adapter.SelectedItem.ToString().Split(' ');
                selectedAdapter = Convert.ToInt32(selectedAdapterList[0]);
            }

            sendArpThread = new Thread(sendARPreply);
            sendArpThread.IsBackground = true;
            sendArpThread.Start();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            btn_stop_arp_reply.Enabled = false;
            int i = -1;
            foreach (LivePacketDevice device in devices)
            {
               i++;
               cB_select_adapter.Items.Add(i.ToString() + "      " + device.Description);
            }
            tB_ping_results.Text = "Your local MAC address is:  " + getMACaddressString();
            tB_ping_results.Text = tB_ping_results.Text + Environment.NewLine + "Your local IP address is:  " + getIP();
        }

        private void btn_stop_arp_reply_Click(object sender, EventArgs e)
        {
            if (sendArpThread != null)
            {
                sendArpThread.Abort();
                btn_send_arp_reply.Enabled = true;
                btn_stop_arp_reply.Enabled = false;
                countARPpackets = -1;
            }
            else
            {
                lbl_status.Text = "ERROR: sendArpThread == null (PLEASE contact the developer)";
                lbl_status.Refresh();
            }
        }

        private void btn_IPscan_Click(object sender, EventArgs e)
        {
            btn_IPscan.Enabled = false;
            try
            {
                tB_scanto_Net.Text = tB_scanfrom_Net.Text;
                startIP_net = tB_scanfrom_Net.Text;
                endIP_net = tB_scanto_Net.Text;
                startIP_host = Convert.ToInt32(tB_scanfrom_host.Text);
                endIP_host = Convert.ToInt32(tB_scanto_host.Text);
                tB_ping_results.Text = tB_ping_results.Text + Environment.NewLine + "Scanning IP range...";
            }
            catch
            {
                tB_ping_results.Text = tB_ping_results.Text + Environment.NewLine + "ERROR: Could not read the IP-Addresses!";
                btn_IPscan.Enabled = true;
                return;
            }

            Thread pingThread = new Thread(DoWork);
            pingThread.IsBackground = true;
            pingThread.Start();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                str_ethernet_sender_mac1 = tB_ethernet_sender_mac1.Text;
                str_ethernet_sender_mac2 = tB_ethernet_sender_mac2.Text;
                str_ethernet_sender_mac3 = tB_ethernet_sender_mac3.Text;
                str_ethernet_sender_mac4 = tB_ethernet_sender_mac4.Text;
                str_ethernet_sender_mac5 = tB_ethernet_sender_mac5.Text;
                str_ethernet_sender_mac6 = tB_ethernet_sender_mac6.Text;
                str_ethernet_destination_mac1 = tB_ethernet_destination_mac1.Text;
                str_ethernet_destination_mac2 = tB_ethernet_destination_mac2.Text;
                str_ethernet_destination_mac3 = tB_ethernet_destination_mac3.Text;
                str_ethernet_destination_mac4 = tB_ethernet_destination_mac4.Text;
                str_ethernet_destination_mac5 = tB_ethernet_destination_mac5.Text;
                str_ethernet_destination_mac6 = tB_ethernet_destination_mac6.Text;
                str_arp_sender_mac1 = tB_arp_sender_mac1.Text;
                str_arp_sender_mac2 = tB_arp_sender_mac2.Text;
                str_arp_sender_mac3 = tB_arp_sender_mac3.Text;
                str_arp_sender_mac4 = tB_arp_sender_mac4.Text;
                str_arp_sender_mac5 = tB_arp_sender_mac5.Text;
                str_arp_sender_mac6 = tB_arp_sender_mac6.Text;
                str_arp_sender_ip1 = tB_arp_sender_ip1.Text;
                str_arp_sender_ip2 = tB_arp_sender_ip2.Text;
                str_arp_sender_ip3 = tB_arp_sender_ip3.Text;
                str_arp_sender_ip4 = tB_arp_sender_ip4.Text;
                str_arp_destination_mac1 = tB_arp_destination_mac1.Text;
                str_arp_destination_mac2 = tB_arp_destination_mac2.Text;
                str_arp_destination_mac3 = tB_arp_destination_mac3.Text;
                str_arp_destination_mac4 = tB_arp_destination_mac4.Text;
                str_arp_destination_mac5 = tB_arp_destination_mac5.Text;
                str_arp_destination_mac6 = tB_arp_destination_mac6.Text;
                str_arp_destination_ip1 = tB_arp_destination_ip1.Text;
                str_arp_destination_ip2 = tB_arp_destination_ip2.Text;
                str_arp_destination_ip3 = tB_arp_destination_ip3.Text;
                str_arp_destination_ip4 = tB_arp_destination_ip4.Text;
                str_send_interval = tB_send_interval.Text;
                string[] lines = { str_ethernet_sender_mac1, str_ethernet_sender_mac2, str_ethernet_sender_mac3, str_ethernet_sender_mac4, str_ethernet_sender_mac5, str_ethernet_sender_mac6, str_ethernet_destination_mac1, str_ethernet_destination_mac2, str_ethernet_destination_mac3, str_ethernet_destination_mac4, str_ethernet_destination_mac5, str_ethernet_destination_mac6, str_arp_sender_mac1, str_arp_sender_mac2, str_arp_sender_mac3, str_arp_sender_mac4, str_arp_sender_mac5, str_arp_sender_mac6, str_arp_sender_ip1, str_arp_sender_ip2, str_arp_sender_ip3, str_arp_sender_ip4, str_arp_destination_mac1, str_arp_destination_mac2, str_arp_destination_mac3, str_arp_destination_mac4, str_arp_destination_mac5, str_arp_destination_mac6, str_arp_destination_ip1, str_arp_destination_ip2, str_arp_destination_ip3, str_arp_destination_ip4, str_send_interval };
                if (File.Exists(Application.StartupPath + @"\arpspoofer_settings.arpspoofer"))
                {
                    File.Delete(Application.StartupPath + @"\arpspoofer_settings.arpspoofer");
                    File.WriteAllLines(Application.StartupPath + @"\arpspoofer_settings.arpspoofer", lines);
                }
                else
                {
                    File.WriteAllLines(Application.StartupPath + @"\arpspoofer_settings.arpspoofer", lines);
                }
                
                MessageBox.Show("Saved your settings to:    " + Application.StartupPath, "Save settings complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save your settings." + ex, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\arpspoofer_settings.arpspoofer"))
            {
                this.Enabled = false;
                List<string> lines = new List<string>();
                foreach (string line in File.ReadLines(Application.StartupPath + @"\arpspoofer_settings.arpspoofer"))
                {
                    lines.Add(line);
                }

                tB_ethernet_sender_mac1.Text = lines[0];
                tB_ethernet_sender_mac2.Text = lines[1];
                tB_ethernet_sender_mac3.Text = lines[2];
                tB_ethernet_sender_mac4.Text = lines[3];
                tB_ethernet_sender_mac5.Text = lines[4];
                tB_ethernet_sender_mac6.Text = lines[5];
                tB_ethernet_destination_mac1.Text = lines[6];
                tB_ethernet_destination_mac2.Text = lines[7];
                tB_ethernet_destination_mac3.Text = lines[8];
                tB_ethernet_destination_mac4.Text = lines[9];
                tB_ethernet_destination_mac5.Text = lines[10];
                tB_ethernet_destination_mac6.Text = lines[11];
                tB_arp_sender_mac1.Text = lines[12];
                tB_arp_sender_mac2.Text = lines[13];
                tB_arp_sender_mac3.Text = lines[14];
                tB_arp_sender_mac4.Text = lines[15];
                tB_arp_sender_mac5.Text = lines[16];
                tB_arp_sender_mac6.Text = lines[17];
                tB_arp_sender_ip1.Text = lines[18];
                tB_arp_sender_ip2.Text = lines[19];
                tB_arp_sender_ip3.Text = lines[20];
                tB_arp_sender_ip4.Text = lines[21];
                tB_arp_destination_mac1.Text = lines[22];
                tB_arp_destination_mac2.Text = lines[23];
                tB_arp_destination_mac3.Text = lines[24];
                tB_arp_destination_mac4.Text = lines[25];
                tB_arp_destination_mac5.Text = lines[26];
                tB_arp_destination_mac6.Text = lines[27];
                tB_arp_destination_ip1.Text = lines[28];
                tB_arp_destination_ip2.Text = lines[29];
                tB_arp_destination_ip3.Text = lines[30];
                tB_arp_destination_ip4.Text = lines[31];
                tB_send_interval.Text = lines[32];
                this.Enabled = true;
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Cannot find the settings file." + Environment.NewLine + "Make sure you have it in the same directory as your .EXE", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Events: end
        // Functions: start
        private void ArpComplete()
        {
            lbl_status.Text = "Sent ARP packet:  " + countARPpackets;
            lbl_status.Refresh();
        }

        private void ArpFailed()
        {
            if (countARPpackets < 0)
            {
                lbl_status.Text = "...";
                lbl_status.Refresh();
            }
            else
            {
                lbl_status.Text = "Failed to send ARP packet:  " + countARPpackets;
                lbl_status.Refresh();
            }
        }

        private void InputError()
        {
            lbl_status.Text = "ERROR: Check your input.";
            lbl_status.Refresh();
            btn_stop_arp_reply.Enabled = false;
            btn_send_arp_reply.Enabled = true;
        }

        private void SendIntervalTooBig()
        {
            lbl_status.Text = "Send interval has to be between 1 and 10000 (ms)";
            lbl_status.Refresh();
            btn_stop_arp_reply.Enabled = false;
            btn_send_arp_reply.Enabled = true;
        }

        private string getMACaddressString()
        {
            string macAddresses = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces, thereby ignoring any
                // loopback devices etc.
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet) continue;
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;
        }

        private string getIP()
        {
            string localIP = "";
            try
            {
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    var addr = ni.GetIPProperties().GatewayAddresses.FirstOrDefault();
                    if (addr != null)
                    {
                        if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                        {
                            Console.WriteLine(ni.Name);
                            foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                            {
                                if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                                {
                                    localIP = ip.Address.ToString();
                                }
                            }
                        }
                    }
                }
                return localIP;
            }
            catch
            {
                localIP = "ERROR";
                return localIP;
            }
        }

        private void sendARPreply()
        {
            try
            {
                int_send_interval = Convert.ToInt32(str_send_interval);
                if (int_send_interval < 1 || int_send_interval > 10000)
                {
                    lbl_status.Invoke(new setTextMethodDelegate(SendIntervalTooBig));
                    return;
                }

                byte_arp_sender_ip1 = Convert.ToByte(str_arp_sender_ip1);
                byte_arp_sender_ip2 = Convert.ToByte(str_arp_sender_ip2);
                byte_arp_sender_ip3 = Convert.ToByte(str_arp_sender_ip3);
                byte_arp_sender_ip4 = Convert.ToByte(str_arp_sender_ip4);
                byte_arp_destination_ip1 = Convert.ToByte(str_arp_destination_ip1);
                byte_arp_destination_ip2 = Convert.ToByte(str_arp_destination_ip2);
                byte_arp_destination_ip3 = Convert.ToByte(str_arp_destination_ip3);
                byte_arp_destination_ip4 = Convert.ToByte(str_arp_destination_ip4);
                str_arp_sender_macFull = str_arp_sender_mac1 + str_arp_sender_mac2 + str_arp_sender_mac3 + str_arp_sender_mac4 + str_arp_sender_mac5 + str_arp_sender_mac6;
                str_arp_destination_macFull = str_arp_destination_mac1 + str_arp_destination_mac2 + str_arp_destination_mac3 + str_arp_destination_mac4 + str_arp_destination_mac5 + str_arp_destination_mac6;
                long value_sender = long.Parse(str_arp_sender_macFull, NumberStyles.HexNumber, CultureInfo.CurrentCulture.NumberFormat);
                byte[] macBytes_sender = BitConverter.GetBytes(value_sender);
                Array.Reverse(macBytes_sender);
                bytes_arp_sender_mac = new byte[6];
                for (int i = 0; i <= 5; i++)
                    bytes_arp_sender_mac[i] = macBytes_sender[i + 2];

                long value_destination = long.Parse(str_arp_destination_macFull, NumberStyles.HexNumber, CultureInfo.CurrentCulture.NumberFormat);
                byte[] macBytes_destination = BitConverter.GetBytes(value_destination);
                Array.Reverse(macBytes_destination);
                bytes_arp_destination_mac = new byte[6];
                for (int i = 0; i <= 5; i++)
                    bytes_arp_destination_mac[i] = macBytes_destination[i + 2];

            }
            catch
            {
                lbl_status.Invoke(new setTextMethodDelegate(InputError));
                return;
            }
            PacketDevice selectedDevice = devices[selectedAdapter];
            using (PacketCommunicator communicator =
            selectedDevice.Open(1000, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                while (true)
                {
                    try
                    {
                        countARPpackets += 1;
                        PcapDotNet.Packets.Packet arp;

                        EthernetLayer ethernetLayer = new EthernetLayer
                        {
                            Source = new MacAddress(str_ethernet_sender_mac1 + ":" + str_ethernet_sender_mac2 + ":" + str_ethernet_sender_mac3 + ":" + str_ethernet_sender_mac4 + ":" + str_ethernet_sender_mac5 + ":" + str_ethernet_sender_mac6), // My Mac
                            Destination = new MacAddress(str_ethernet_destination_mac1 + ":" + str_ethernet_destination_mac2 + ":" + str_ethernet_destination_mac3 + ":" + str_ethernet_destination_mac4 + ":" + str_ethernet_destination_mac5 + ":" + str_ethernet_destination_mac6), // Remote device IP
                            EtherType = EthernetType.Arp,
                        };

                        ArpLayer arpLayer = new ArpLayer
                        {
                            ProtocolType = EthernetType.IpV4,
                            Operation = ArpOperation.Reply,
                            SenderHardwareAddress = bytes_arp_sender_mac.AsReadOnly(), // My MAC
                            SenderProtocolAddress = new byte[] { byte_arp_sender_ip1, byte_arp_sender_ip2, byte_arp_sender_ip3, byte_arp_sender_ip4 }.AsReadOnly(), // My Router IP

                            TargetHardwareAddress =  bytes_arp_destination_mac.AsReadOnly(),
                            TargetProtocolAddress = new byte[] { byte_arp_destination_ip1, byte_arp_destination_ip2, byte_arp_destination_ip3, byte_arp_destination_ip4 }.AsReadOnly(),
                        };

                        PacketBuilder builder = new PacketBuilder(ethernetLayer, arpLayer);

                        arp = builder.Build(DateTime.Now);

                        communicator.SendPacket(arp);
                        System.Threading.Thread.Sleep(int_send_interval);
                        lbl_status.Invoke(new setTextMethodDelegate(ArpComplete));
                    }
                    catch
                    {
                            lbl_status.Invoke(new setTextMethodDelegate(ArpFailed));
                            System.Threading.Thread.Sleep(int_send_interval);
                    }
                }
            }
        }

        public void writeReply()
        {
            /*string str_replyHostEntry = "";
            try
            {
               str_replyHostEntry = Dns.GetHostEntry(IPAddress.Parse(replyAddress)).HostName.ToString();
            }
            catch
            {
               str_replyHostEntry = "Unkown Host";
            }*/
            tB_ping_results.Text = tB_ping_results.Text + Environment.NewLine + replyAddress;
            tB_ping_results.SelectionStart = tB_ping_results.Text.Length;
            tB_ping_results.ScrollToCaret();
        }

        public void enableScanButton()
        {
            btn_IPscan.Enabled = true;
            tB_ping_results.Text = tB_ping_results.Text + Environment.NewLine + "-----Address scan finished-----";
            tB_ping_results.SelectionStart = tB_ping_results.Text.Length;
            tB_ping_results.ScrollToCaret();
        }
        public void couldNotScanAddress()
        {
            tB_ping_results.Text = tB_ping_results.Text + Environment.NewLine + "Could not scan " + pingIP;
            tB_ping_results.SelectionStart = tB_ping_results.Text.Length;
            tB_ping_results.ScrollToCaret();
        }

        private void pingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                return;
            }
            if (e.Reply.Status == IPStatus.Success)
            {
                if (replyAddressCache == e.Reply.Address.ToString())
                {
                    return;
                }
                replyAddressCache = e.Reply.Address.ToString();
                replyAddress = e.Reply.Address.ToString();
                tB_ping_results.Invoke(new setTextMethodDelegate(writeReply));
            }
        }

        private void DoWork()
        {
            using (ping = new Ping())
            {
                for (int i = startIP_host; i <= endIP_host; i++)
                {
                    try
                    {
                        AutoResetEvent waiter = new AutoResetEvent(false);
                        pingIP = startIP_net + "." + i;
                        ping.PingCompleted += new PingCompletedEventHandler(pingCompleted);
                        ping.SendAsync(IPAddress.Parse(pingIP), 400, waiter);
                        waiter.WaitOne(700);
                    }
                    catch
                    {
                        tB_ping_results.Invoke(new setTextMethodDelegate(couldNotScanAddress));
                    }
                }
                tB_ping_results.Invoke(new setTextMethodDelegate(enableScanButton));
            }
        }
            // Functions: end
        }
    }
