using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BestOilGasStation
{
    public partial class CafeItem : UserControl
    {
        public event EventHandler<decimal> PriceChanged;
        private readonly CafeItemInfo _cafeItemInfo;
        public CafeItem()
        {
            InitializeComponent();
            FillItemInfo();
        }

        public CafeItem(CafeItemInfo cafeItemInfo)
        {
            _cafeItemInfo = cafeItemInfo;
            InitializeComponent();
            FillItemInfo();
        }

        private void FillItemInfo()
        {
            ItemCheckBox.Text = _cafeItemInfo.Title;
            ItemTextBox.Text = _cafeItemInfo.Price.ToString();
            ItemNumericUpDown.Value = _cafeItemInfo.Count;
        }

        private void ItemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ItemNumericUpDown.Enabled = ItemCheckBox.Checked;
            ReCalculatePrice();
           
        }

        private void ItemNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _cafeItemInfo.Count = (int)ItemNumericUpDown.Value;
            ReCalculatePrice();
        }
        private void ReCalculatePrice()
        {
            _cafeItemInfo.CafeItemTotalPrice = ItemCheckBox.Checked
                ?_cafeItemInfo.Price * _cafeItemInfo.Count
                :  0.0m;

            PriceChanged?.Invoke(this, _cafeItemInfo.CafeItemTotalPrice);

        }

       
    }

    
}
