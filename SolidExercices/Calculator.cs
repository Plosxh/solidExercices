using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SolidExercices
{
    public class Calculator
    {
        private readonly string[] symboles = { "+", "-", "/", "*" };
        private List<IOperationInterface> _interfaces;
        private IOperationInterface _operation;

        public Calculator(List<IOperationInterface> operation_interface)
        {
            _interfaces = operation_interface;
        }

        public decimal Calculate(string operation)
        {
            decimal res = 0;
            //var operationPlus = operation.Split('+');
            for (int i = 0; i < symboles.Length; i++)
            {
                var operandes = operation.Split(Convert.ToChar(_interfaces[i].GetSymbole()));
                if (operandes.Length>1)
                {
                    try
                    {
                        res = _interfaces[i].Calculate(operation);
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