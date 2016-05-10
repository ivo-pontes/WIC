namespace WIC
{
    partial class NewInterface
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
            this.ipAddressTbox = new System.Windows.Forms.TextBox();
            this.subnetMaskTbox = new System.Windows.Forms.TextBox();
            this.gatewayTbox = new System.Windows.Forms.TextBox();
            this.dns1Tbox = new System.Windows.Forms.TextBox();
            this.dns2Tbox = new System.Windows.Forms.TextBox();
            this.setStaticIPBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert an IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subnet Mask:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gateway:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Primary DNS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Secondary DNS:";
            // 
            // ipAddressTbox
            // 
            this.ipAddressTbox.Location = new System.Drawing.Point(130, 40);
            this.ipAddressTbox.Name = "ipAddressTbox";
            this.ipAddressTbox.Size = new System.Drawing.Size(100, 20);
            this.ipAddressTbox.TabIndex = 6;
            // 
            // subnetMaskTbox
            // 
            this.subnetMaskTbox.Location = new System.Drawing.Point(130, 72);
            this.subnetMaskTbox.Name = "subnetMaskTbox";
            this.subnetMaskTbox.Size = new System.Drawing.Size(100, 20);
            this.subnetMaskTbox.TabIndex = 7;
            // 
            // gatewayTbox
            // 
            this.gatewayTbox.Location = new System.Drawing.Point(130, 106);
            this.gatewayTbox.Name = "gatewayTbox";
            this.gatewayTbox.Size = new System.Drawing.Size(100, 20);
            this.gatewayTbox.TabIndex = 8;
            // 
            // dns1Tbox
            // 
            this.dns1Tbox.Location = new System.Drawing.Point(130, 141);
            this.dns1Tbox.Name = "dns1Tbox";
            this.dns1Tbox.Size = new System.Drawing.Size(100, 20);
            this.dns1Tbox.TabIndex = 9;
            // 
            // dns2Tbox
            // 
            this.dns2Tbox.Location = new System.Drawing.Point(130, 176);
            this.dns2Tbox.Name = "dns2Tbox";
            this.dns2Tbox.Size = new System.Drawing.Size(100, 20);
            this.dns2Tbox.TabIndex = 10;
            // 
            // setStaticIPBtn
            // 
            this.setStaticIPBtn.Location = new System.Drawing.Point(86, 213);
            this.setStaticIPBtn.Name = "setStaticIPBtn";
            this.setStaticIPBtn.Size = new System.Drawing.Size(75, 23);
            this.setStaticIPBtn.TabIndex = 0;
            this.setStaticIPBtn.Text = "Add";
            this.setStaticIPBtn.Click += new System.EventHandler(this.setStaticIPBtn_Click_1);
            // 
            // NewInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 250);
            this.Controls.Add(this.setStaticIPBtn);
            this.Controls.Add(this.dns2Tbox);
            this.Controls.Add(this.dns1Tbox);
            this.Controls.Add(this.gatewayTbox);
            this.Controls.Add(this.subnetMaskTbox);
            this.Controls.Add(this.ipAddressTbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewInterface";
            this.Text = "NewInterface";
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
        private System.Windows.Forms.TextBox ipAddressTbox;
        private System.Windows.Forms.TextBox subnetMaskTbox;
        private System.Windows.Forms.TextBox gatewayTbox;
        private System.Windows.Forms.TextBox dns1Tbox;
        private System.Windows.Forms.TextBox dns2Tbox;
        private System.Windows.Forms.Button setStaticIPBtn;
    }
}