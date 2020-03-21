using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using org.mariuszgromada.math.mxparser;

namespace PowellsMethod
{
    using InputParameters = SortedDictionary<String, String>;

    public partial class MainWindow : Window
    {
        // Parser FunctionParser
        // Plotter
        // Algorytm Klas

        PowellsAlgorythm algorythm;
        AlgorythmParametersValidator parametersValidator;
        EquationFormater equationFormater;

        public MainWindow()
        {
            algorythm = new PowellsAlgorythm();
            parametersValidator = new AlgorythmParametersValidator();
            equationFormater = new EquationFormater();
            InitializeComponent();
        }


        private void saveParamsButtonClicked(object sender, RoutedEventArgs e)
        {
            InputParameters inputParameters = getInputParameters();
            if (parametersValidator.validate(inputParameters))
            {
               this.logs.Text= equationFormater.formatEquation(inputParameters["Equation"],int.Parse(inputParameters["VariablesCount"]));
                inputParameters["Equation"] = equationFormater.formatEquation(inputParameters["Equation"], int.Parse(inputParameters["VariablesCount"]));
                algorythm.setParameters(inputParameters);

            }
            else
            {
                MessageBox.Show("Błędne wartości parametrów");
            }
        }

        private InputParameters getInputParameters()
        {
            InputParameters inputParameters = new InputParameters();

            inputParameters.Add("Equation", this.rightEquationFormat.Text);
            inputParameters.Add("VariablesCount", this.variablesCount.Text);
            inputParameters.Add("IterationCount", this.iterationCount.Text);
            inputParameters.Add("Accuracy", this.accuracy.Text);

            return inputParameters;
        }
    }
}
