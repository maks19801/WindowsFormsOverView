using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilGasStation
{
    public partial class MainForm : Form
    {
        public readonly List<GasInfo> _gasInfos;
        public readonly List<CafeItemInfo> _cafeItemsInfos;

        public MainForm()
        {
            InitializeComponent();
            _gasInfos = GetGasInfos();
            _cafeItemsInfos = GetCafeItemsInfos();
            GasTypeCombobox.Items.AddRange(_gasInfos.ToArray());
            FillCafeItemInfo();
            GasPaymentTextBox.TextChanged += CalculateToPayGasStationPrice;
            GasQuantityTextBox.TextChanged += CalculateToPayGasStationPrice;
            GasPriceTextBox.TextChanged += CalculateToPayGasStationPrice;
        }

       private List<GasInfo> GetGasInfos()
        {
            return new List<GasInfo>
            {
                new GasInfo("A-92", 28.00m),
                new GasInfo("A-95", 28.90m),
                new GasInfo("Gas", 15.00m),
                new GasInfo("DT", 25.00m)

            };
        }

        private List<CafeItemInfo> GetCafeItemsInfos()
        {
            return new List<CafeItemInfo>
            {
                new CafeItemInfo("Hot-dog", 30.00m),
                new CafeItemInfo("Hamburger", 31.00m),
                new CafeItemInfo("French Fries", 25.00m),
                new CafeItemInfo("Coca-Cola", 15.00m)
            };
        }
        private void FillCafeItemInfo()
        {
            foreach (var cafeItem in _cafeItemsInfos)
            {
                var ci = new CafeItem(cafeItem)
                {
                    Dock = DockStyle.Top
                };
                ci.PriceChanged += CalculateToPayCafePrice;
                CafeItemsPanel.Controls.Add(ci);
            }
        }

        
        private void GasTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = GasTypeCombobox.SelectedIndex;
            var price = _gasInfos[index].Price;
            GasPriceTextBox.Text = price.ToString();
        }

        private void CalculateToPayCafePrice(object sender, decimal price)
        {
            var toPayCafe = _cafeItemsInfos.Sum(c => c.CafeItemTotalPrice);
            ToPayCafeTextBox.Text = toPayCafe.ToString();
        }
        private void CalculateToPayGasStationPrice(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;
            if (GasQuantityRadioBtn.Checked)
            {
                try
                {
                    var index = GasTypeCombobox.SelectedIndex;
                    var price = _gasInfos[index].Price;
                    var toPayGasStation = Math.Round(price * Convert.ToDecimal(GasQuantityTextBox.Text), 2);
                    ToPayGasStationTextBox.Text = toPayGasStation.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please, choose Gas Type!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (GasPaymentRadioBtn.Checked)
            {
                try
                {
                    var index = GasTypeCombobox.SelectedIndex;
                    var price = _gasInfos[index].Price;
                    var toPayGasStation = Math.Round((Convert.ToDecimal(GasPaymentTextBox.Text) / price), 2);
                    ToPayGasStationTextBox.Text = toPayGasStation.ToString();
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Please, choose Gas Type!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void GasQuantityRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           
            GasPaymentTextBox.ReadOnly = true;
            GasQuantityTextBox.ReadOnly = false;
            GasQuantityTextBox.Text = "0,00";
            ToPayGasStationTextBox.Text = "0,00";
            GasGroupBox.Text = "ToPay";
            ToPayGasStationUnitsLbl.Text = "UAH";
            GasQuantityTextBox.Focus();
        }


        private void GasPaymentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            GasPaymentTextBox.ReadOnly = false;
            GasQuantityTextBox.ReadOnly = true;
            GasPaymentTextBox.Text = "0,00";
            ToPayGasStationTextBox.Text = "0,00";
            GasGroupBox.Text = "ToGet";
            ToPayGasStationUnitsLbl.Text = "Litres";
            GasPaymentTextBox.Focus();
        }

        private void ToPayTotalBtn_Click(object sender, EventArgs e)
        {
            if (GasQuantityRadioBtn.Checked)
            {
                var totalPrice = Convert.ToDecimal(ToPayGasStationTextBox.Text) + Convert.ToDecimal(ToPayCafeTextBox.Text);
                ToPayTotalTextBox.Text = totalPrice.ToString();
            }
            if (GasPaymentRadioBtn.Checked)
            {
                var totalPrice = Convert.ToDecimal(GasPaymentTextBox.Text) + Convert.ToDecimal(ToPayCafeTextBox.Text);
                ToPayTotalTextBox.Text = totalPrice.ToString();
            }
        }      
    }
}
