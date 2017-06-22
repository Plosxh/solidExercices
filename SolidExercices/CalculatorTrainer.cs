using System;
using System.Collections.Generic;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        
        private string[] _operations;

        public CalculatorTrainer(ConnecteurFichier operationsListe)
        {
            _operations = operationsListe.GetOperations();
        }

        public void Run(List<IOperationInterface> interfaces)
        {
            var calculator = new Calculator(interfaces);
            foreach (var operation in _operations)
            {
                try
                {
                    var result = calculator.Calculate(operation);
                    Console.WriteLine(operation + " = " + result);
                }
                catch (DivideByZeroException divide)
                {
                    Console.WriteLine("Caught by CalculatorTrainer: " + divide.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message); 
                }
            }
        }
    }
}
