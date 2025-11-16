using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationsProject
{
    public partial class CalculationForm : Form
    {
        public CalculationForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textResultNum.Text = Calculations.add2Numbers((int)numVal1.Value, (int)numVal2.Value).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            textResultNum.Text = Calculations.divide2Numbers((int)numVal1.Value, (int)numVal2.Value).ToString();
        }

        private void btnStarts_Click(object sender, EventArgs e)
        {
            textResultText.Text = Calculations.StartsWithUpper(textCheckText.Text).ToString();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            textResultText.Text = Calculations.ConvertToUpper(textChar.Text.ElementAt<char>(0)).ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            textResultText.Text = Calculations.ContainsChar(textCheckText.Text, textChar.Text.ElementAt<char>(0)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numVal1.Value = 0;
            numVal2.Value = 0;
            textChar.Clear();
            textCheckText.Clear();
            textResultNum.Clear();
            textResultText.Clear();
        }
    }
}
