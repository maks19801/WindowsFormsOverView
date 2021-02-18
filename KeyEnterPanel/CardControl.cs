using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyEnterPanel
{
    public partial class CardControl : UserControl
    {
        private TextBox inputTextBox;
        public CardControl()
        {
            InitializeComponent();
            inputTextBox = CardNumberTxt;
            PinTxt.Enabled = false;

            //for fun

            var buttons = Controls
                .Cast<Control>()
                .Where(c => c is Button)
                .Cast<Button>();

            foreach(var button in buttons)
            {
               
                 button.Enabled = false;
            }
        }

        private void KeyBoardBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                inputTextBox.Text += button.Text;
            }
            // var btn = sender as Button;
        }

        private void CardNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if (CardNumberTxt.Text.Length == 16 && CardNumberTxt.Text.All(c => char.IsDigit(c)))
            {
                inputTextBox = PinTxt;
                PinTxt.Enabled = true;
                CardNumberTxt.Enabled = false;
            }
           
        }

        private void PinTxt_TextChanged(object sender, EventArgs e)
        {
            if(PinTxt.Text.Length == 4)
            {
                PinTxt.Enabled = false;
            }

        }
    }
}
