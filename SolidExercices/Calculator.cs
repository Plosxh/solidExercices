using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SolidExercices
{
    public class Calculator
    {
        public readonly string[] symboles = { "+", "-", "/", "*" };
        public double Calculate(string operation)
        {
            double res = 0.0;
            var operationPlus = operation.Split('+');
            for (int i = 0; i < symboles.Length; i++)
            {
                var operandes = operation.Split(Convert.ToChar(symboles[i]));
                if (operandes.Length>1)
                {
                    if (symboles[i]=="+")
                    {
                        res = Convert.ToDouble(operandes[0]) + Convert.ToDouble(operandes[1]);
                    }
                    else if (symboles[i] == "-")
                    {
                        res = Convert.ToDouble(operandes[0]) - Convert.ToDouble(operandes[1]);
                    }
                    else if (symboles[i] == "/")
                    {
                        res = Convert.ToDouble(operandes[0]) / Convert.ToDouble(operandes[1]);
                    }
                    else if (symboles[i] == "*")
                    {
                        res = Convert.ToDouble(operandes[0]) * Convert.ToDouble(operandes[1]);
                    } 
                }
            }
            return res;
        }
    }
}