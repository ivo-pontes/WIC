using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIC
{
    public partial class CurrentInterface : Form
    {
        MyNetworkInterface netIf;
        IList<MyNetworkInterface> interfaces;

        public CurrentInterface()
        {
            InitializeComponent();
            netIf = new MyNetworkInterface();
            this.interfaces = new List<MyNetworkInterface>();
            this.buildForm();
        }

        private void buildForm()
        {
            MyNetworkInterface iface = new MyNetworkInterface();

            if (iface.loadInterfaces() != null)
            {
                String[] ip;
                String[] ifaces = iface.loadInterfaces();
                foreach (String item in ifaces)
                {
                    ip = item.Split(' ');
                    interfaceCbox.Items.Add(ip[0]);
                    MyNetworkInterface ifacex = new MyNetworkInterface();
                    ifacex.Ip = ip[0];
                    ifacex.Subnet = ip[1];
                    ifacex.Gateway = ip[2];
                    ifacex.Dns1 = ip[3];
                    ifacex.Dns2 = ip[4];
                    interfaces.Add(ifacex);
                }
                interfaceCbox.SelectedIndex = 0;
            }

        }

        private void interfaceCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dns1lbl.Text = this.interfaces[interfaceCbox.SelectedIndex].Dns1;
            dns2lbl.Text = this.interfaces[interfaceCbox.SelectedIndex].Dns2;
            iplbl.Text = this.interfaces[interfaceCbox.SelectedIndex].Ip;
            subnetlbl.Text = this.interfaces[interfaceCbox.SelectedIndex].Subnet;
            gatewaylbl.Text = this.interfaces[interfaceCbox.SelectedIndex].Gateway;
        }
    }
}
