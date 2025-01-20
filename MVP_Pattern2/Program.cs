using MVP_Pattern2.Models;
using MVP_Pattern2.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Pattern2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = new CalculatorModel();
            var view = new CalculatorForm();
            var presenter = new CalculatorPresenter(view, model);


            Application.Run(view as Form);
        }
    }
}
