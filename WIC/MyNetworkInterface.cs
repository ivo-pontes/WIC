using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIC
{
    class MyNetworkInterface
    {
        public List<String> interfaces { get; set; }
        public String selectedInterface { get; set; }
        public String myIP { get; set; }
        public List<String> ipAddresses { get; set; }
        private String ip { get; set; }
        private String subnet { get; set; }
        private String gateway { get; set; }
        private String dns1 { get; set; }
        private String dns2 { get; set; }


        public MyNetworkInterface()
        {
            this.selectedInterface = " ";
        }

        public bool addNewInterface(String iface)
        {
            bool isValid = true;

            if (this.validateData(iface))
            {
                if (File.Exists("networkInterface.txt"))
                {
                    var content = new List<string>();

                    content.Add(iface);
                    try
                    {
                        File.AppendAllLines("networkInterface.txt", content);
                        return true;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
                else
                {
                    String path = @"networkInterface.txt";
                    var newFile = File.Create(path);
                    newFile.Close();

                    var content = new List<string>();
                    content.Add(iface);
                    try
                    {
                        File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
                        File.AppendAllLines(path, content);
                        return true;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
            else
            {
                MessageBox.Show("You Must Type a Valid Address and Use dots(.) eg: XXX.XXX.XXX.XXX");
                isValid = false;
            }

            return isValid;
        }

        public String[] loadInterfaces()
        {
            String[] ifaces;

            if (File.Exists("networkInterface.txt"))
            {
                try
                {
                    ifaces = File.ReadAllLines("networkInterface.txt");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                Console.WriteLine("BOOM!");
                ifaces = null;
            }

            return ifaces;
        }

        public bool validateData(String iface)
        {
            String[] networkData = iface.Split(' ');
            bool isValid = true;
            string sPattern = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";
            if (System.Text.RegularExpressions.Regex.IsMatch(networkData[0], sPattern))
                this.ip = networkData[0];
            else
                isValid = false;

            if (System.Text.RegularExpressions.Regex.IsMatch(networkData[1], sPattern))
                this.subnet = networkData[1];
            else
                isValid = false;

            if (System.Text.RegularExpressions.Regex.IsMatch(networkData[2], sPattern))
                this.gateway = networkData[2];
            else
                isValid = false;

            if (System.Text.RegularExpressions.Regex.IsMatch(networkData[3], sPattern))
                this.dns1 = networkData[3];
            else
                isValid = false;

            if (System.Text.RegularExpressions.Regex.IsMatch(networkData[4], sPattern))
                this.dns2 = networkData[4];
            else
                isValid = false;

            return isValid;
        }

        public String Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        public String Subnet
        {
            get { return subnet; }
            set { subnet = value; }
        }
        public String Gateway
        {
            get { return gateway; }
            set { gateway = value; }
        }
        public String Dns1
        {
            get { return dns1; }
            set { dns1 = value; }
        }
        public String Dns2
        {
            get { return dns2; }
            set { dns2 = value; }
        }

        public String SelectedInterface
        {
            get { return selectedInterface; }
            set { selectedInterface = value; }
        }

    }
}
