using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SolidExercices
{
    public class Calculator
    {
        private readonly string[] symboles = { "+", "-", "/", "*" };
        private IOperationInterface _operation;

        public Calculator(IOperationInterface operation_interface)
        {
            _operation = operation_interface;
        }

        public decimal Calculate(string operation)
        {
            decimal res = 0;
            var operationPlus = operation.Split('+');
            for (int i = 0; i < symboles.Length; i++)
            {
                var operandes = operation.Split(Convert.ToChar(symboles[i]));
                if (operandes.Length>1)
                {
                    try
                    {
                        res = _operation.Calculate(operation);
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