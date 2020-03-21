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
	using Function = org.mariuszgromada.math.mxparser.Function;
	using FunctionArgument = org.mariuszgromada.math.mxparser.Argument;
	using FunctionArguments = List<org.mariuszgromada.math.mxparser.Argument>;

	public class PowellsAlgorythm
	{
		public PowellsAlgorythm()
		{
			optimizedFunction = new Function("");
			arguments = new FunctionArguments();
		}

		public void minimize()
		{
			// algorytm
		}

		public void setParameters(SortedDictionary<String, String> parameters)
		{
			optimizedFunction.setFunction(parameters["Equation"]);
			setFunctionArguments(int.Parse(parameters["VariablesCount"]));
			accuracy = float.Parse(parameters["Accuracy"]);
			iterationCount = int.Parse(parameters["IterationCount"]);
		}

		private void setFunctionArguments(int variablesCount)
		{
			for (int i = 0; i < variablesCount; i++)
			{
				arguments[i] = new FunctionArgument("x" + (i + 1).ToString() + " = ");
			}
		}

		Function optimizedFunction;
		FunctionArguments arguments;
		float accuracy;
		int iterationCount;
	}
}

