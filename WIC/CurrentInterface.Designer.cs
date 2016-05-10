namespace WIC
{
    partial class CurrentInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dns2lbl = new System.Windows.Forms.Label();
            this.dns1lbl = new System.Windows.Forms.Label();
            this.gatewaylbl = new System.Windows.Forms.Label();
            this.subnetlbl = new System.Windows.Forms.Label();
            this.iplbl = new System.Windows.Forms.Label();
            this.interfaceCbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an Interface:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subnet Mask:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gateway:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNS 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DNS 2:";
            // 
            // dns2lbl
            // 
            this.dns2lbl.AutoSize = true;
            this.dns2lbl.Location = new System.Drawing.Point(92, 131);
            this.dns2lbl.Name = "dns2lbl";
            this.dns2lbl.Size = new System.Drawing.Size(0, 13);
            this.dns2lbl.TabIndex = 10;
            // 
            // dns1lbl
            // 
            this.dns1lbl.AutoSize = true;
            this.dns1lbl.Location = new System.Drawing.Point(92, 115);
            this.dns1lbl.Name = "dns1lbl";
            this.dns1lbl.Size = new System.Drawing.Size(0, 13);
            this.dns1lbl.TabIndex = 9;
            // 
            // gatewaylbl
            // 
            this.gatewaylbl.AutoSize = true;
            this.gatewaylbl.Location = new System.Drawing.Point(92, 101);
            this.gatewaylbl.Name = "gatewaylbl";
            this.gatewaylbl.Size = new System.Drawing.Size(0, 13);
            this.gatewaylbl.TabIndex = 8;
            // 
            // subnetlbl
            // 
            this.subnetlbl.AutoSize = true;
            this.subnetlbl.Location = new System.Drawing.Point(92, 89);
            this.subnetlbl.Name = "subnetlbl";
            this.subnetlbl.Size = new System.Drawing.Size(0, 13);
            this.subnetlbl.TabIndex = 7;
            // 
            // iplbl
            // 
            this.iplbl.AutoSize = true;
            this.iplbl.Location = new System.Drawing.Point(92, 74);
            this.iplbl.Name = "iplbl";
            this.iplbl.Size = new System.Drawing.Size(0, 13);
            this.iplbl.TabIndex = 6;
            // 
            // interfaceCbox
            // 
            this.interfaceCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interfaceCbox.FormattingEnabled = true;
            this.interfaceCbox.Location = new System.Drawing.Point(25, 41);
            this.interfaceCbox.Name = "interfaceCbox";
            this.interfaceCbox.Size = new System.Drawing.Size(159, 21);
            this.interfaceCbox.TabIndex = 11;
            this.interfaceCbox.SelectedIndexChanged += new System.EventHandler(this.interfaceCbox_SelectedIndexChanged);
            // 
            // CurrentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 152);
            this.Controls.Add(this.interfaceCbox);
            this.Controls.Add(this.dns2lbl);
            this.Controls.Add(this.dns1lbl);
            this.Controls.Add(this.gatewaylbl);
            this.Controls.Add(this.subnetlbl);
            this.Controls.Add(this.iplbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CurrentInterface";
            this.Text = "CurrentInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dns2lbl;
        private System.Windows.Forms.Label dns1lbl;
        private System.Windows.Forms.Label gatewaylbl;
        private System.Windows.Forms.Label subnetlbl;
        private System.Windows.Forms.Label iplbl;
        private System.Windows.Forms.ComboBox interfaceCbox;
    }
}