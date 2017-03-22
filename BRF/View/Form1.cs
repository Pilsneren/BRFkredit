using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BRF.Controller;

namespace BRF.View
{
    public partial class Form1 : Form
    {
        private readonly FormController _controller = new FormController();
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatorButton_Click(object sender, System.EventArgs e)
        {
            ErrorHandling();

        }
       
        /// <summary>
        /// Fejlhåndtering af text samt håndtering af konverterings-forbindelsen.
        /// </summary>
        public void ErrorHandling()
        {
            Regex RX = new Regex("^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
            if (!RX.IsMatch(talBox.Text))
            {
                MessageBox.Show("Ups det passede vidst ikke helt!");
            }
            if (RX.IsMatch(talBox.Text))
            {
                outputBox.Text = _controller.RomanToValue(talBox.Text).Sum().ToString();
            }
        }

        private void talBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        private void talBox_Click(object sender, System.EventArgs e)
        {
            talBox.Text = "";
        }
    }
}
