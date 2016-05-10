namespace WIC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.interfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInterfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPChanger10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.networkInterfacesCbox = new System.Windows.Forms.ComboBox();
            this.myIPCbox = new System.Windows.Forms.ComboBox();
            this.staticChangeBtn = new System.Windows.Forms.Button();
            this.dhcpChangeBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interfaceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // interfaceToolStripMenuItem
            // 
            this.interfaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewInterfaceToolStripMenuItem,
            this.viewInterfacesToolStripMenuItem});
            this.interfaceToolStripMenuItem.Name = "interfaceToolStripMenuItem";
            this.interfaceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.interfaceToolStripMenuItem.Text = "Interface";
            // 
            // addNewInterfaceToolStripMenuItem
            // 
            this.addNewInterfaceToolStripMenuItem.Name = "addNewInterfaceToolStripMenuItem";
            this.addNewInterfaceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addNewInterfaceToolStripMenuItem.Text = "&Add New Interface";
            this.addNewInterfaceToolStripMenuItem.Click += new System.EventHandler(this.addNewInterfaceToolStripMenuItem_Click);
            // 
            // viewInterfacesToolStripMenuItem
            // 
            this.viewInterfacesToolStripMenuItem.Name = "viewInterfacesToolStripMenuItem";
            this.viewInterfacesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewInterfacesToolStripMenuItem.Text = "&View Interfaces";
            this.viewInterfacesToolStripMenuItem.Click += new System.EventHandler(this.viewInterfacesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPChanger10ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // iPChanger10ToolStripMenuItem
            // 
            this.iPChanger10ToolStripMenuItem.Name = "iPChanger10ToolStripMenuItem";
            this.iPChanger10ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.iPChanger10ToolStripMenuItem.Text = "IP Changer 1.0";
            this.iPChanger10ToolStripMenuItem.Click += new System.EventHandler(this.iPChanger10ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interfaces:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Addresses:";
            // 
            // networkInterfacesCbox
            // 
            this.networkInterfacesCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.networkInterfacesCbox.FormattingEnabled = true;
            this.networkInterfacesCbox.Location = new System.Drawing.Point(34, 57);
            this.networkInterfacesCbox.Name = "networkInterfacesCbox";
            this.networkInterfacesCbox.Size = new System.Drawing.Size(228, 21);
            this.networkInterfacesCbox.TabIndex = 3;
            this.networkInterfacesCbox.SelectedIndexChanged += new System.EventHandler(this.networkInterfacesCbox_SelectedIndexChanged);
            // 
            // myIPCbox
            // 
            this.myIPCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myIPCbox.FormattingEnabled = true;
            this.myIPCbox.Location = new System.Drawing.Point(84, 113);
            this.myIPCbox.Name = "myIPCbox";
            this.myIPCbox.Size = new System.Drawing.Size(121, 21);
            this.myIPCbox.TabIndex = 4;
            this.myIPCbox.SelectedIndexChanged += new System.EventHandler(this.myIPCbox_SelectedIndexChanged);
            // 
            // staticChangeBtn
            // 
            this.staticChangeBtn.Location = new System.Drawing.Point(34, 147);
            this.staticChangeBtn.Name = "staticChangeBtn";
            this.staticChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.staticChangeBtn.TabIndex = 5;
            this.staticChangeBtn.Text = "Change IP";
            this.staticChangeBtn.UseVisualStyleBackColor = true;
            this.staticChangeBtn.Click += new System.EventHandler(this.staticChangeBtn_Click);
            // 
            // dhcpChangeBtn
            // 
            this.dhcpChangeBtn.Location = new System.Drawing.Point(187, 147);
            this.dhcpChangeBtn.Name = "dhcpChangeBtn";
            this.dhcpChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.dhcpChangeBtn.TabIndex = 6;
            this.dhcpChangeBtn.Text = "DHCP";
            this.dhcpChangeBtn.UseVisualStyleBackColor = true;
            this.dhcpChangeBtn.Click += new System.EventHandler(this.dhcpChangeBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(93, 182);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(108, 23);
            this.reloadBtn.TabIndex = 7;
            this.reloadBtn.Text = "Reload Interfaces";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.dhcpChangeBtn);
            this.Controls.Add(this.staticChangeBtn);
            this.Controls.Add(this.myIPCbox);
            this.Controls.Add(this.networkInterfacesCbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem interfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInterfacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPChanger10ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox networkInterfacesCbox;
        private System.Windows.Forms.ComboBox myIPCbox;
        private System.Windows.Forms.Button staticChangeBtn;
        private System.Windows.Forms.Button dhcpChangeBtn;
        private System.Windows.Forms.Button reloadBtn;
    }
}

