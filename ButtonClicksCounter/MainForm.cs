using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOverView
{
    public partial class MainForm : Form
    {
        private int counter = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CounterBtn_Click(object sender, EventArgs e)
        {
            counter++;
            CounterLbl.Text = counter.ToString();
        }

        private void CounterBtn_MouseEnter(object sender, EventArgs e)
        {
            CounterBtn.BackColor = Color.Green;
        }

        private void CounterBtn_MouseLeave(object sender, EventArgs e)
        {
            CounterBtn.BackColor = Color.Gray;
        }

        
    }
}
