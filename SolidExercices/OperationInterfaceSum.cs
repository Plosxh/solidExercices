using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class OperationInterfaceSum : IOperationInterface
    {
        private string _symbole="+";

        public decimal Calculate(string operation)
        {
            string[] operande = operation.Split(Convert.ToChar("+"));
            return Convert.ToDecimal(operande[0]) + Convert.ToDecimal(operande[1]);
        }

        public string GetSymbole()
        {
            return _symbole;
        }
    }
}
