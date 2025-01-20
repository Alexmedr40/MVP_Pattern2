using MVP_Pattern2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Pattern2
{
    public partial class CalculatorForm : Form, ICalculatorView
    {
        public CalculatorForm()
        {
            InitializeComponent();
            btnAdd.Click += (sender, e) => AddRequested?.Invoke(sender, e);
            btnSubtract.Click += (sender, e) => SubtractRequested?.Invoke(sender, e);
            btnMultiply.Click += (sender, e) => MultiplyRequested?.Invoke(sender, e);
            btnDivide.Click += (sender, e) => DivideRequested?.Invoke(sender, e);
        }
        public string FirstNumber => txtFirstNumber.Text;
        public string SecondNumber => txtSecondNumber.Text;
        public string Result { set => lblResult.Text = value; }

        public event EventHandler AddRequested;
        public event EventHandler SubtractRequested;
        public event EventHandler MultiplyRequested;
        public event EventHandler DivideRequested;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
