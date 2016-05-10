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
    public partial class NewInterface : Form
    {
        public NewInterface()
        {
            InitializeComponent();
        }

        private void setStaticIPBtn_Click_1(object sender, EventArgs e)
        {
            String ipAddress = ipAddressTbox.Text;
            String subnetMask = subnetMaskTbox.Text;
            String gateway = gatewayTbox.Text;
            String dns1 = dns1Tbox.Text;
            String dns2 = dns2Tbox.Text;


            MyNetworkInterface iface = new MyNetworkInterface();

            if (!iface.addNewInterface(ipAddress + " " + subnetMask + " " + gateway + " " + dns1 + " " + dns2))
            {
                MessageBox.Show("The Interface could not be saved.");
            }
            else
            {
                MessageBox.Show("Interface Saved!");
            }
        }
    }
}
