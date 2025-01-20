using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Pattern2.Views
{
    public interface ICalculatorView
    {
        string FirstNumber { get; }
        string SecondNumber { get; }
        string Result { set; }

        event EventHandler AddRequested;
        event EventHandler SubtractRequested;
        event EventHandler MultiplyRequested;
        event EventHandler DivideRequested;
        void ShowError(string message);
    }
}
