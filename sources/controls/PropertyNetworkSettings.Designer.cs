﻿using nvc.controllers;
namespace nvc.controls
{
    partial class PropertyNetworkSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.panel1 = new System.Windows.Forms.Panel();
			this._tbmDNS = new nvc.controls.IPAddrMaskedTextBox();
			this._tbmGate = new nvc.controls.IPAddrMaskedTextBox();
			this._tbmSubnet = new nvc.controls.IPAddrMaskedTextBox();
			this._tbmIPaddr = new nvc.controls.IPAddrMaskedTextBox();
			this._cbDHCP = new System.Windows.Forms.ComboBox();
			this._lblMACaddr = new System.Windows.Forms.TextBox();
			this._lblDNSaddr = new System.Windows.Forms.TextBox();
			this._lblGateAddr = new System.Windows.Forms.TextBox();
			this._lblSubnetMask = new System.Windows.Forms.TextBox();
			this._lblIPaddress = new System.Windows.Forms.TextBox();
			this._lblDHCP = new System.Windows.Forms.TextBox();
			this._saveCancelControl = new nvc.controls.SaveCancelControl();
			this._tbMACaddr = new System.Windows.Forms.TextBox();
			this._title = new nvc.controls.GroupBoxControl();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this._tbmDNS);
			this.panel1.Controls.Add(this._tbmGate);
			this.panel1.Controls.Add(this._tbmSubnet);
			this.panel1.Controls.Add(this._tbmIPaddr);
			this.panel1.Controls.Add(this._cbDHCP);
			this.panel1.Controls.Add(this._lblMACaddr);
			this.panel1.Controls.Add(this._lblDNSaddr);
			this.panel1.Controls.Add(this._lblGateAddr);
			this.panel1.Controls.Add(this._lblSubnetMask);
			this.panel1.Controls.Add(this._lblIPaddress);
			this.panel1.Controls.Add(this._lblDHCP);
			this.panel1.Controls.Add(this._saveCancelControl);
			this.panel1.Controls.Add(this._tbMACaddr);
			this.panel1.Location = new System.Drawing.Point(3, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(418, 194);
			this.panel1.TabIndex = 17;
			// 
			// _tbmDNS
			// 
			this._tbmDNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._tbmDNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._tbmDNS.DateOnly = false;
			this._tbmDNS.DecimalOnly = false;
			this._tbmDNS.DigitOnly = false;
			this._tbmDNS.IPAddrOnly = true;
			this._tbmDNS.Location = new System.Drawing.Point(166, 107);
			this._tbmDNS.Name = "_tbmDNS";
			this._tbmDNS.PhoneWithAreaCode = false;
			this._tbmDNS.Size = new System.Drawing.Size(232, 20);
			this._tbmDNS.SSNOnly = false;
			this._tbmDNS.TabIndex = 29;
			this._tbmDNS.TextChanged += new System.EventHandler(this._tbmDNS_TextChanged);
			// 
			// _tbmGate
			// 
			this._tbmGate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._tbmGate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._tbmGate.DateOnly = false;
			this._tbmGate.DecimalOnly = false;
			this._tbmGate.DigitOnly = false;
			this._tbmGate.IPAddrOnly = true;
			this._tbmGate.Location = new System.Drawing.Point(166, 81);
			this._tbmGate.Name = "_tbmGate";
			this._tbmGate.PhoneWithAreaCode = false;
			this._tbmGate.Size = new System.Drawing.Size(232, 20);
			this._tbmGate.SSNOnly = false;
			this._tbmGate.TabIndex = 28;
			this._tbmGate.TextChanged += new System.EventHandler(this._tbmGate_TextChanged);
			// 
			// _tbmSubnet
			// 
			this._tbmSubnet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._tbmSubnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._tbmSubnet.DateOnly = false;
			this._tbmSubnet.DecimalOnly = false;
			this._tbmSubnet.DigitOnly = false;
			this._tbmSubnet.IPAddrOnly = true;
			this._tbmSubnet.Location = new System.Drawing.Point(166, 54);
			this._tbmSubnet.Name = "_tbmSubnet";
			this._tbmSubnet.PhoneWithAreaCode = false;
			this._tbmSubnet.Size = new System.Drawing.Size(232, 20);
			this._tbmSubnet.SSNOnly = false;
			this._tbmSubnet.TabIndex = 27;
			this._tbmSubnet.TextChanged += new System.EventHandler(this._tbmSubnet_TextChanged);
			// 
			// _tbmIPaddr
			// 
			this._tbmIPaddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._tbmIPaddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._tbmIPaddr.DateOnly = false;
			this._tbmIPaddr.DecimalOnly = false;
			this._tbmIPaddr.DigitOnly = false;
			this._tbmIPaddr.IPAddrOnly = true;
			this._tbmIPaddr.Location = new System.Drawing.Point(166, 28);
			this._tbmIPaddr.Name = "_tbmIPaddr";
			this._tbmIPaddr.PhoneWithAreaCode = false;
			this._tbmIPaddr.Size = new System.Drawing.Size(232, 20);
			this._tbmIPaddr.SSNOnly = false;
			this._tbmIPaddr.TabIndex = 26;
			this._tbmIPaddr.TextChanged += new System.EventHandler(this._tbmIPaddr_TextChanged);
			// 
			// _cbDHCP
			// 
			this._cbDHCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._cbDHCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cbDHCP.FormattingEnabled = true;
			this._cbDHCP.Location = new System.Drawing.Point(166, 3);
			this._cbDHCP.Name = "_cbDHCP";
			this._cbDHCP.Size = new System.Drawing.Size(249, 21);
			this._cbDHCP.TabIndex = 21;
			this._cbDHCP.SelectedIndexChanged += new System.EventHandler(this._cbDHCP_SelectedIndexChanged);
			// 
			// _lblMACaddr
			// 
			this._lblMACaddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._lblMACaddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lblMACaddr.Location = new System.Drawing.Point(3, 133);
			this._lblMACaddr.Name = "_lblMACaddr";
			this._lblMACaddr.ReadOnly = true;
			this._lblMACaddr.Size = new System.Drawing.Size(157, 20);
			this._lblMACaddr.TabIndex = 20;
			this._lblMACaddr.Text = "MAC";
			// 
			// _lblDNSaddr
			// 
			this._lblDNSaddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._lblDNSaddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lblDNSaddr.Location = new System.Drawing.Point(3, 107);
			this._lblDNSaddr.Name = "_lblDNSaddr";
			this._lblDNSaddr.ReadOnly = true;
			this._lblDNSaddr.Size = new System.Drawing.Size(157, 20);
			this._lblDNSaddr.TabIndex = 19;
			this._lblDNSaddr.Text = "DNS";
			// 
			// _lblGateAddr
			// 
			this._lblGateAddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._lblGateAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lblGateAddr.Location = new System.Drawing.Point(3, 81);
			this._lblGateAddr.Name = "_lblGateAddr";
			this._lblGateAddr.ReadOnly = true;
			this._lblGateAddr.Size = new System.Drawing.Size(157, 20);
			this._lblGateAddr.TabIndex = 18;
			this._lblGateAddr.Text = "Gate";
			// 
			// _lblSubnetMask
			// 
			this._lblSubnetMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._lblSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lblSubnetMask.Location = new System.Drawing.Point(3, 55);
			this._lblSubnetMask.Name = "_lblSubnetMask";
			this._lblSubnetMask.ReadOnly = true;
			this._lblSubnetMask.Size = new System.Drawing.Size(157, 20);
			this._lblSubnetMask.TabIndex = 17;
			this._lblSubnetMask.Text = "Subnet";
			// 
			// _lblIPaddress
			// 
			this._lblIPaddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._lblIPaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lblIPaddress.Location = new System.Drawing.Point(3, 29);
			this._lblIPaddress.Name = "_lblIPaddress";
			this._lblIPaddress.ReadOnly = true;
			this._lblIPaddress.Size = new System.Drawing.Size(157, 20);
			this._lblIPaddress.TabIndex = 16;
			this._lblIPaddress.Text = "IP";
			// 
			// _lblDHCP
			// 
			this._lblDHCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._lblDHCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lblDHCP.Location = new System.Drawing.Point(3, 3);
			this._lblDHCP.Name = "_lblDHCP";
			this._lblDHCP.ReadOnly = true;
			this._lblDHCP.Size = new System.Drawing.Size(157, 20);
			this._lblDHCP.TabIndex = 15;
			this._lblDHCP.Text = "DHCP";
			// 
			// _saveCancelControl
			// 
			this._saveCancelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this._saveCancelControl.Location = new System.Drawing.Point(3, 167);
			this._saveCancelControl.Margin = new System.Windows.Forms.Padding(0);
			this._saveCancelControl.Name = "_saveCancelControl";
			this._saveCancelControl.Size = new System.Drawing.Size(157, 23);
			this._saveCancelControl.TabIndex = 14;
			// 
			// _tbMACaddr
			// 
			this._tbMACaddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._tbMACaddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._tbMACaddr.Location = new System.Drawing.Point(166, 133);
			this._tbMACaddr.Name = "_tbMACaddr";
			this._tbMACaddr.ReadOnly = true;
			this._tbMACaddr.Size = new System.Drawing.Size(249, 20);
			this._tbMACaddr.TabIndex = 11;
			// 
			// _title
			// 
			this._title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._title.BackColor = System.Drawing.SystemColors.ControlLight;
			this._title.Location = new System.Drawing.Point(3, 3);
			this._title.Name = "_title";
			this._title.Size = new System.Drawing.Size(418, 23);
			this._title.TabIndex = 18;
			// 
			// PropertyNetworkSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._title);
			this.Controls.Add(this.panel1);
			this.Name = "PropertyNetworkSettings";
			this.Size = new System.Drawing.Size(422, 224);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox _lblMACaddr;
        private System.Windows.Forms.TextBox _lblDNSaddr;
        private System.Windows.Forms.TextBox _lblGateAddr;
        private System.Windows.Forms.TextBox _lblSubnetMask;
        private System.Windows.Forms.TextBox _lblIPaddress;
        private System.Windows.Forms.TextBox _lblDHCP;
        private SaveCancelControl _saveCancelControl;
        private System.Windows.Forms.TextBox _tbMACaddr;
        private GroupBoxControl _title;
		private System.Windows.Forms.ComboBox _cbDHCP;
		private IPAddrMaskedTextBox _tbmIPaddr;
		private IPAddrMaskedTextBox _tbmDNS;
		private IPAddrMaskedTextBox _tbmGate;
		private IPAddrMaskedTextBox _tbmSubnet;
    }
}
