using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIC
{
    public partial class Form1 : Form
    {
        MyNetworkInterface netIf;
        List<MyNetworkInterface> interfaces;

        public Form1()
        {
            InitializeComponent();
            netIf = new MyNetworkInterface();
            interfaces = new List<MyNetworkInterface>();
            this.buildForm();
        }

        private void staticChangeBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in this.interfaces)
            {
                if (item.Ip.Equals(netIf.Ip))
                {
                    this.setIP(item.Ip, item.Subnet, item.Gateway, item.Dns1, item.Dns2);
                    MessageBox.Show("IP Changed!");
                }
            }
        }

        private void dhcpChangeBtn_Click(object sender, EventArgs e)
        {
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();
            List<String> nicsList = new List<String>();

            foreach (ManagementObject adapter in networkCollection)
            {
                if ((bool)adapter["IPEnabled"])
                {
                    try
                    {
                        if (netIf.selectedInterface.Equals(adapter["Description"] as string))
                        {
                            adapter.InvokeMethod("EnableDHCP", null);
                            ManagementBaseObject newDNS = adapter.GetMethodParameters("SetDNSServerSearchOrder");
                            newDNS["DNSServerSearchOrder"] = null;
                            adapter.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);

                            MessageBox.Show("DHCP Mode is ON!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        public void setIP(string ip_address, string subnet_mask, string gateway, string dns1, string dns2)
        {
            ManagementClass adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                if ((bool)adapter["IPEnabled"])
                {
                    try
                    {
                        if (netIf.selectedInterface.Equals(adapter["Description"] as string))
                        {
                            ManagementBaseObject newIP = adapter.GetMethodParameters("EnableStatic");
                            newIP["IPAddress"] = new string[] { ip_address };
                            newIP["SubnetMask"] = new string[] { subnet_mask };
                            ManagementBaseObject newGateway = adapter.GetMethodParameters("SetGateways");
                            newGateway["DefaultIPGateway"] = new string[] { gateway };
                            newGateway["GatewayCostMetric"] = new int[] { 1 };
                            ManagementBaseObject newDNS = adapter.GetMethodParameters("SetDNSServerSearchOrder");
                            newDNS["DNSServerSearchOrder"] = new string[] { dns1, dns2 };
                            adapter.InvokeMethod("SetGateways", newGateway, null);
                            adapter.InvokeMethod("EnableStatic", newIP, null);
                            adapter.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                }
            }

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            this.loadInterfaces(this.myIPCbox);
        }

        private void buildForm()
        {
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                if ((bool)adapter["IPEnabled"])
                {
                    networkInterfacesCbox.Items.Add((string)adapter["Description"]);
                }
            }

            networkInterfacesCbox.SelectedIndex = 0;
            netIf.SelectedInterface = (string)networkInterfacesCbox.SelectedItem;

            this.loadInterfaces(myIPCbox);
        }

        private void loadInterfaces(ComboBox cbox)
        {
            MyNetworkInterface iface = new MyNetworkInterface();
            MyNetworkInterface ifaceAux;
            this.interfaces = new List<MyNetworkInterface>();
            cbox.Items.Clear();
            var i = 0;

            if (iface.loadInterfaces() != null)
            {
                String[] ip;
                String[] ifaces = iface.loadInterfaces();
                foreach (String item in ifaces)
                {
                    ip = item.Split(' ');
                    cbox.Items.Add(ip[0]);
                    ifaceAux = new MyNetworkInterface();
                    ifaceAux.Ip = ip[0];
                    ifaceAux.Gateway = ip[2];
                    ifaceAux.Subnet = ip[1];
                    ifaceAux.Dns1 = ip[3];
                    ifaceAux.Dns2 = ip[4];

                    this.interfaces.Add(ifaceAux);

                    if (i == 0)
                    {
                        netIf.Ip = ifaceAux.Ip;
                        netIf.Gateway = ifaceAux.Gateway;
                        netIf.Dns1 = ifaceAux.Dns1;
                        netIf.Dns2 = ifaceAux.Dns2;
                        netIf.Subnet = ifaceAux.Subnet;
                        i++;
                    }

                }
                cbox.SelectedIndex = 0;
            }
        }

        private void viewInterfacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentInterface currentIfaceForm = new CurrentInterface();
            currentIfaceForm.Show();
        }

        private void addNewInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInterface ifaceForm = new NewInterface();
            ifaceForm.Show();
        }

        private void iPChanger10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void myIPCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ip = myIPCbox.SelectedItem.ToString();
            foreach (var ifacex in this.interfaces)
            {
                if (ifacex.Ip.Equals(ip))
                {
                    netIf.Ip = ifacex.Ip;
                    netIf.Gateway = ifacex.Gateway;
                    netIf.Dns1 = ifacex.Dns1;
                    netIf.Dns2 = ifacex.Dns2;
                    netIf.Subnet = ifacex.Subnet;
                }
            }
        }

        private void networkInterfacesCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            netIf.SelectedInterface = networkInterfacesCbox.SelectedItem.ToString();
        }
    }
}
