using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
        public class OperationInterfaceSub : IOperationInterface
        {
            public double Calculate(string operation)
            {
                string[] operande = operation.Split(Convert.ToChar("-"));
                return Convert.ToDouble(operande[0]) - Convert.ToDouble(operande[1]);
            }
        }
    
}
