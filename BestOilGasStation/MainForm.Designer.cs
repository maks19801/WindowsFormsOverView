
namespace BestOilGasStation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GasTypeCombobox = new System.Windows.Forms.ComboBox();
            this.GasPriceTextBox = new System.Windows.Forms.TextBox();
            this.GasTypeLbl = new System.Windows.Forms.Label();
            this.GasPriceLbl = new System.Windows.Forms.Label();
            this.CafeItemsPanel = new System.Windows.Forms.Panel();
            this.ToPayCafeTextBox = new System.Windows.Forms.TextBox();
            this.ToPayGasStationTextBox = new System.Windows.Forms.TextBox();
            this.ToPayTotalBtn = new System.Windows.Forms.Button();
            this.ToPayTotalTextBox = new System.Windows.Forms.TextBox();
            this.GasQuantityRadioBtn = new System.Windows.Forms.RadioButton();
            this.GasPaymentRadioBtn = new System.Windows.Forms.RadioButton();
            this.GasQuantityLbl = new System.Windows.Forms.Label();
            this.PaymentUnitsLbl = new System.Windows.Forms.Label();
            this.GasQuantityTextBox = new System.Windows.Forms.TextBox();
            this.GasPaymentTextBox = new System.Windows.Forms.TextBox();
            this.GasPriceUnitsLbl = new System.Windows.Forms.Label();
            this.ToPayGasStationUnitsLbl = new System.Windows.Forms.Label();
            this.ToPayCafeUnitsLbl = new System.Windows.Forms.Label();
            this.ToPayTotalUnitsLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GasGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.GasGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // GasTypeCombobox
            // 
            this.GasTypeCombobox.FormattingEnabled = true;
            this.GasTypeCombobox.Location = new System.Drawing.Point(105, 67);
            this.GasTypeCombobox.Name = "GasTypeCombobox";
            this.GasTypeCombobox.Size = new System.Drawing.Size(182, 33);
            this.GasTypeCombobox.TabIndex = 0;
            this.GasTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.GasTypeCombobox_SelectedIndexChanged);
            // 
            // GasPriceTextBox
            // 
            this.GasPriceTextBox.Location = new System.Drawing.Point(105, 119);
            this.GasPriceTextBox.Name = "GasPriceTextBox";
            this.GasPriceTextBox.ReadOnly = true;
            this.GasPriceTextBox.Size = new System.Drawing.Size(182, 31);
            this.GasPriceTextBox.TabIndex = 1;
            // 
            // GasTypeLbl
            // 
            this.GasTypeLbl.AutoSize = true;
            this.GasTypeLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GasTypeLbl.Location = new System.Drawing.Point(6, 70);
            this.GasTypeLbl.Name = "GasTypeLbl";
            this.GasTypeLbl.Size = new System.Drawing.Size(78, 25);
            this.GasTypeLbl.TabIndex = 2;
            this.GasTypeLbl.Text = "GasType";
            // 
            // GasPriceLbl
            // 
            this.GasPriceLbl.AutoSize = true;
            this.GasPriceLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GasPriceLbl.Location = new System.Drawing.Point(6, 122);
            this.GasPriceLbl.Name = "GasPriceLbl";
            this.GasPriceLbl.Size = new System.Drawing.Size(78, 25);
            this.GasPriceLbl.TabIndex = 3;
            this.GasPriceLbl.Text = "GasPrice";
            // 
            // CafeItemsPanel
            // 
            this.CafeItemsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CafeItemsPanel.Location = new System.Drawing.Point(13, 55);
            this.CafeItemsPanel.Name = "CafeItemsPanel";
            this.CafeItemsPanel.Size = new System.Drawing.Size(369, 221);
            this.CafeItemsPanel.TabIndex = 4;
            this.CafeItemsPanel.Tag = "";
            // 
            // ToPayCafeTextBox
            // 
            this.ToPayCafeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToPayCafeTextBox.Location = new System.Drawing.Point(118, 43);
            this.ToPayCafeTextBox.Name = "ToPayCafeTextBox";
            this.ToPayCafeTextBox.ReadOnly = true;
            this.ToPayCafeTextBox.Size = new System.Drawing.Size(150, 31);
            this.ToPayCafeTextBox.TabIndex = 7;
            this.ToPayCafeTextBox.Text = "0,00";
            this.ToPayCafeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToPayGasStationTextBox
            // 
            this.ToPayGasStationTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToPayGasStationTextBox.Location = new System.Drawing.Point(194, 43);
            this.ToPayGasStationTextBox.Name = "ToPayGasStationTextBox";
            this.ToPayGasStationTextBox.ReadOnly = true;
            this.ToPayGasStationTextBox.Size = new System.Drawing.Size(93, 31);
            this.ToPayGasStationTextBox.TabIndex = 9;
            this.ToPayGasStationTextBox.Text = "0,00";
            this.ToPayGasStationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToPayTotalBtn
            // 
            this.ToPayTotalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ToPayTotalBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToPayTotalBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToPayTotalBtn.Location = new System.Drawing.Point(108, 37);
            this.ToPayTotalBtn.Name = "ToPayTotalBtn";
            this.ToPayTotalBtn.Size = new System.Drawing.Size(240, 50);
            this.ToPayTotalBtn.TabIndex = 10;
            this.ToPayTotalBtn.Text = "To Pay Total";
            this.ToPayTotalBtn.UseVisualStyleBackColor = false;
            this.ToPayTotalBtn.Click += new System.EventHandler(this.ToPayTotalBtn_Click);
            // 
            // ToPayTotalTextBox
            // 
            this.ToPayTotalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ToPayTotalTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToPayTotalTextBox.Location = new System.Drawing.Point(472, 37);
            this.ToPayTotalTextBox.Name = "ToPayTotalTextBox";
            this.ToPayTotalTextBox.ReadOnly = true;
            this.ToPayTotalTextBox.Size = new System.Drawing.Size(150, 47);
            this.ToPayTotalTextBox.TabIndex = 11;
            this.ToPayTotalTextBox.Text = "0,00";
            this.ToPayTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GasQuantityRadioBtn
            // 
            this.GasQuantityRadioBtn.AutoSize = true;
            this.GasQuantityRadioBtn.Checked = true;
            this.GasQuantityRadioBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GasQuantityRadioBtn.Location = new System.Drawing.Point(12, 24);
            this.GasQuantityRadioBtn.Name = "GasQuantityRadioBtn";
            this.GasQuantityRadioBtn.Size = new System.Drawing.Size(105, 29);
            this.GasQuantityRadioBtn.TabIndex = 12;
            this.GasQuantityRadioBtn.TabStop = true;
            this.GasQuantityRadioBtn.Text = "Quantity";
            this.GasQuantityRadioBtn.UseVisualStyleBackColor = true;
            this.GasQuantityRadioBtn.CheckedChanged += new System.EventHandler(this.GasQuantityRadioBtn_CheckedChanged);
            // 
            // GasPaymentRadioBtn
            // 
            this.GasPaymentRadioBtn.AutoSize = true;
            this.GasPaymentRadioBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GasPaymentRadioBtn.Location = new System.Drawing.Point(12, 75);
            this.GasPaymentRadioBtn.Name = "GasPaymentRadioBtn";
            this.GasPaymentRadioBtn.Size = new System.Drawing.Size(105, 29);
            this.GasPaymentRadioBtn.TabIndex = 13;
            this.GasPaymentRadioBtn.Text = "Payment";
            this.GasPaymentRadioBtn.UseVisualStyleBackColor = true;
            this.GasPaymentRadioBtn.CheckedChanged += new System.EventHandler(this.GasPaymentRadioBtn_CheckedChanged);
            // 
            // GasQuantityLbl
            // 
            this.GasQuantityLbl.AutoSize = true;
            this.GasQuantityLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GasQuantityLbl.Location = new System.Drawing.Point(289, 185);
            this.GasQuantityLbl.Name = "GasQuantityLbl";
            this.GasQuantityLbl.Size = new System.Drawing.Size(53, 25);
            this.GasQuantityLbl.TabIndex = 14;
            this.GasQuantityLbl.Text = "Litres";
            // 
            // PaymentUnitsLbl
            // 
            this.PaymentUnitsLbl.AutoSize = true;
            this.PaymentUnitsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PaymentUnitsLbl.Location = new System.Drawing.Point(289, 238);
            this.PaymentUnitsLbl.Name = "PaymentUnitsLbl";
            this.PaymentUnitsLbl.Size = new System.Drawing.Size(49, 25);
            this.PaymentUnitsLbl.TabIndex = 15;
            this.PaymentUnitsLbl.Text = "UAH";
            // 
            // GasQuantityTextBox
            // 
            this.GasQuantityTextBox.Location = new System.Drawing.Point(194, 179);
            this.GasQuantityTextBox.Name = "GasQuantityTextBox";
            this.GasQuantityTextBox.Size = new System.Drawing.Size(93, 31);
            this.GasQuantityTextBox.TabIndex = 16;
            this.GasQuantityTextBox.Text = "0,00";
            this.GasQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GasPaymentTextBox
            // 
            this.GasPaymentTextBox.Location = new System.Drawing.Point(194, 232);
            this.GasPaymentTextBox.Name = "GasPaymentTextBox";
            this.GasPaymentTextBox.ReadOnly = true;
            this.GasPaymentTextBox.Size = new System.Drawing.Size(93, 31);
            this.GasPaymentTextBox.TabIndex = 17;
            this.GasPaymentTextBox.Text = "0,00";
            this.GasPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GasPriceUnitsLbl
            // 
            this.GasPriceUnitsLbl.AutoSize = true;
            this.GasPriceUnitsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GasPriceUnitsLbl.Location = new System.Drawing.Point(289, 125);
            this.GasPriceUnitsLbl.Name = "GasPriceUnitsLbl";
            this.GasPriceUnitsLbl.Size = new System.Drawing.Size(49, 25);
            this.GasPriceUnitsLbl.TabIndex = 18;
            this.GasPriceUnitsLbl.Text = "UAH";
            // 
            // ToPayGasStationUnitsLbl
            // 
            this.ToPayGasStationUnitsLbl.AutoSize = true;
            this.ToPayGasStationUnitsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToPayGasStationUnitsLbl.Location = new System.Drawing.Point(289, 49);
            this.ToPayGasStationUnitsLbl.Name = "ToPayGasStationUnitsLbl";
            this.ToPayGasStationUnitsLbl.Size = new System.Drawing.Size(49, 25);
            this.ToPayGasStationUnitsLbl.TabIndex = 19;
            this.ToPayGasStationUnitsLbl.Text = "UAH";
            // 
            // ToPayCafeUnitsLbl
            // 
            this.ToPayCafeUnitsLbl.AutoSize = true;
            this.ToPayCafeUnitsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToPayCafeUnitsLbl.Location = new System.Drawing.Point(274, 49);
            this.ToPayCafeUnitsLbl.Name = "ToPayCafeUnitsLbl";
            this.ToPayCafeUnitsLbl.Size = new System.Drawing.Size(49, 25);
            this.ToPayCafeUnitsLbl.TabIndex = 20;
            this.ToPayCafeUnitsLbl.Text = "UAH";
            // 
            // ToPayTotalUnitsLbl
            // 
            this.ToPayTotalUnitsLbl.AutoSize = true;
            this.ToPayTotalUnitsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToPayTotalUnitsLbl.Location = new System.Drawing.Point(628, 59);
            this.ToPayTotalUnitsLbl.Name = "ToPayTotalUnitsLbl";
            this.ToPayTotalUnitsLbl.Size = new System.Drawing.Size(52, 25);
            this.ToPayTotalUnitsLbl.TabIndex = 21;
            this.ToPayTotalUnitsLbl.Text = "UAH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GasQuantityRadioBtn);
            this.groupBox2.Controls.Add(this.GasPaymentRadioBtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 119);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // GasGroupBox
            // 
            this.GasGroupBox.Controls.Add(this.ToPayGasStationTextBox);
            this.GasGroupBox.Controls.Add(this.ToPayGasStationUnitsLbl);
            this.GasGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GasGroupBox.Location = new System.Drawing.Point(32, 315);
            this.GasGroupBox.Name = "GasGroupBox";
            this.GasGroupBox.Size = new System.Drawing.Size(348, 93);
            this.GasGroupBox.TabIndex = 23;
            this.GasGroupBox.TabStop = false;
            this.GasGroupBox.Text = "To Pay for Gas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ToPayCafeTextBox);
            this.groupBox3.Controls.Add(this.ToPayCafeUnitsLbl);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(386, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 93);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To Pay for Cafe";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.CafeItemsPanel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(386, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 297);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mini-Cafe";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.GasTypeLbl);
            this.groupBox4.Controls.Add(this.GasTypeCombobox);
            this.groupBox4.Controls.Add(this.GasPriceLbl);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.PaymentUnitsLbl);
            this.groupBox4.Controls.Add(this.GasPaymentTextBox);
            this.groupBox4.Controls.Add(this.GasQuantityLbl);
            this.groupBox4.Controls.Add(this.GasPriceTextBox);
            this.groupBox4.Controls.Add(this.GasQuantityTextBox);
            this.groupBox4.Controls.Add(this.GasPriceUnitsLbl);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(32, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 297);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GasStation";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ToPayTotalBtn);
            this.groupBox5.Controls.Add(this.ToPayTotalTextBox);
            this.groupBox5.Controls.Add(this.ToPayTotalUnitsLbl);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(32, 433);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(754, 103);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "To Pay Total";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GasGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestOil";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GasGroupBox.ResumeLayout(false);
            this.GasGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox GasTypeCombobox;
        private System.Windows.Forms.TextBox GasPriceTextBox;
        private System.Windows.Forms.Label GasTypeLbl;
        private System.Windows.Forms.Label GasPriceLbl;
        private System.Windows.Forms.Panel CafeItemsPanel;
        private System.Windows.Forms.TextBox ToPayCafeTextBox;
        private System.Windows.Forms.TextBox ToPayGasStationTextBox;
        private System.Windows.Forms.Button ToPayTotalBtn;
        private System.Windows.Forms.TextBox ToPayTotalTextBox;
        private System.Windows.Forms.RadioButton GasQuantityRadioBtn;
        private System.Windows.Forms.RadioButton GasPaymentRadioBtn;
        private System.Windows.Forms.Label GasQuantityLbl;
        private System.Windows.Forms.Label PaymentUnitsLbl;
        private System.Windows.Forms.TextBox GasQuantityTextBox;
        private System.Windows.Forms.TextBox GasPaymentTextBox;
        private System.Windows.Forms.Label GasPriceUnitsLbl;
        private System.Windows.Forms.Label ToPayGasStationUnitsLbl;
        private System.Windows.Forms.Label ToPayCafeUnitsLbl;
        private System.Windows.Forms.Label ToPayTotalUnitsLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GasGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

