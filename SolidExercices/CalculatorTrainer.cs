using System;
using System.Collections.Generic;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private readonly string[] _operations = new[]
            {"1+2,3", "2 x 3,6", "6-1-3,8", "6,6/3", "6/0", "not an operation", "a+1", "12", ""};

        public void Run()
        {
            List < IOperationInterface > interfaces= new List<IOperationInterface>();
            OperationInterfaceMult mult = new OperationInterfaceMult();
            OperationInterfaceDiv div = new OperationInterfaceDiv();
            OperationInterfaceSum sum = new OperationInterfaceSum();
            OperationInterfaceSub sub = new OperationInterfaceSub();
            interfaces.Add(mult);
            interfaces.Add(div);
            interfaces.Add(sum);
            interfaces.Add(sub);
            var calculator = new Calculator(interfaces);
            foreach (var operation in _operations)
            {
                try
                {
                    var result = calculator.Calculate(operation);
                    Console.WriteLine(operation + " = " + result);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }
    }
}
