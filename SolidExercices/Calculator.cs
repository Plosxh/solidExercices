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
                    try
                    {
                        double operande1 = Convert.ToDouble(operandes[0]);
                        double operande2 = Convert.ToDouble(operandes[1]);

                        if (i == 0)
                        {
                            res = operande1 + operande2;
                        }
                        else if (i == 1)
                        {
                            res = operande1 - operande2;
                        }
                        else if (i == 2)
                        {
                            res = operande1 / operande2;
                        }
                        else if (i == 3)
                        {
                            res = operande1 * operande2;
                        } 
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Mauvaise opération");
                    }

                }
            }
            return res;
        }
    }
}