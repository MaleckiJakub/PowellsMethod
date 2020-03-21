using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowellsMethod
{
    class EquationFormater
    {
        public string formatEquation(string equation, int variablesCount)
        {
            string formatedEquation = "f(";

            for(int i=1;i<=variablesCount;i++)
            {
                formatedEquation+= "x" + i.ToString();
                if(i!=variablesCount)
                {
                    formatedEquation += ",";
                }
            }

            formatedEquation+= ") = " + equation;

            return formatedEquation;
        }
    }
}
