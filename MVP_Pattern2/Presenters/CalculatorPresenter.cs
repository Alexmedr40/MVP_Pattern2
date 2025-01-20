using MVP_Pattern2.Models;
using MVP_Pattern2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Pattern2.Presenters
{
    public class CalculatorPresenter
    {
        private readonly ICalculatorView _view;
        private readonly CalculatorModel _model;

        public CalculatorPresenter(ICalculatorView view, CalculatorModel model)
        {
            _view = view;
            _model = model;

            _view.AddRequested += OnAddRequested;
            _view.SubtractRequested += OnSubtractRequested;
            _view.MultiplyRequested += OnMultiplyRequested;
            _view.DivideRequested += OnDivideRequested;
        }

        private void OnAddRequested(object sender, EventArgs e) => Calculate((a, b) => _model.Add(a, b));
        private void OnSubtractRequested(object sender, EventArgs e) => Calculate((a, b) => _model.Subtract(a, b));
        private void OnMultiplyRequested(object sender, EventArgs e) => Calculate((a, b) => _model.Multiply(a, b));
        private void OnDivideRequested(object sender, EventArgs e) => Calculate((a, b) => _model.Divide(a, b));

        private void Calculate(Func<double, double, double> operation)
        {
            try
            {
                if (double.TryParse(_view.FirstNumber, out double firstNumber) &&
                    double.TryParse(_view.SecondNumber, out double secondNumber))
                {
                    double result = operation(firstNumber, secondNumber);
                    _view.Result = result.ToString();
                }
                else
                {
                    _view.ShowError("Por favor, introduce números válidos.");
                }
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
    }
}
