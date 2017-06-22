using System;
using System.Collections.Generic;
using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {

        [Test]
        public void CalculateASum()
        {
            List<IOperationInterface> interfaces = new List<IOperationInterface>();
            OperationInterfaceMult mult = new OperationInterfaceMult();
            OperationInterfaceDiv div = new OperationInterfaceDiv();
            OperationInterfaceSum sum = new OperationInterfaceSum();
            OperationInterfaceSub sub = new OperationInterfaceSub();
            interfaces.Add(mult);
            interfaces.Add(div);
            interfaces.Add(sum);
            interfaces.Add(sub);
            var calculator = new Calculator(interfaces);
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(Convert.ToDecimal(3.3));
        }
        [Test]
        public void CalculateASub()
        {
            List<IOperationInterface> interfaces = new List<IOperationInterface>();
            OperationInterfaceMult mult = new OperationInterfaceMult();
            OperationInterfaceDiv div = new OperationInterfaceDiv();
            OperationInterfaceSum sum = new OperationInterfaceSum();
            OperationInterfaceSub sub = new OperationInterfaceSub();
            interfaces.Add(mult);
            interfaces.Add(div);
            interfaces.Add(sum);
            interfaces.Add(sub);
            var calculator = new Calculator(interfaces);
            var result = calculator.Calculate("2-1");
            Check.That(result).IsEqualTo(Convert.ToDecimal(1.0));
        }
        [Test]
        public void CalculateADiv()
        {
            List<IOperationInterface> interfaces = new List<IOperationInterface>();
            OperationInterfaceMult mult = new OperationInterfaceMult();
            OperationInterfaceDiv div = new OperationInterfaceDiv();
            OperationInterfaceSum sum = new OperationInterfaceSum();
            OperationInterfaceSub sub = new OperationInterfaceSub();
            interfaces.Add(mult);
            interfaces.Add(div);
            interfaces.Add(sum);
            interfaces.Add(sub);
            var calculator = new Calculator(interfaces);
            var result = calculator.Calculate("1/2");
            Check.That(result).IsEqualTo(Convert.ToDecimal(0.5));
        }
        [Test]
        public void CalculateAMult()
        {
            List<IOperationInterface> interfaces = new List<IOperationInterface>();
            OperationInterfaceMult mult = new OperationInterfaceMult();
            OperationInterfaceDiv div = new OperationInterfaceDiv();
            OperationInterfaceSum sum = new OperationInterfaceSum();
            OperationInterfaceSub sub = new OperationInterfaceSub();
            interfaces.Add(mult);
            interfaces.Add(div);
            interfaces.Add(sum);
            interfaces.Add(sub);
            var calculator = new Calculator(interfaces);
            var result = calculator.Calculate("1*2");
            Check.That(result).IsEqualTo(Convert.ToDecimal(2.0));
        }
        [Test]
        public void CalculateException()
        {
            List<IOperationInterface> interfaces = new List<IOperationInterface>();
            OperationInterfaceMult mult = new OperationInterfaceMult();
            OperationInterfaceDiv div = new OperationInterfaceDiv();
            OperationInterfaceSum sum = new OperationInterfaceSum();
            OperationInterfaceSub sub = new OperationInterfaceSub();
            interfaces.Add(mult);
            interfaces.Add(div);
            interfaces.Add(sum);
            interfaces.Add(sub);
            var calculator = new Calculator(interfaces);
            var result = calculator.Calculate("1*2-9");
            Check.That(result).IsEqualTo(Convert.ToDecimal(0.0));
        }
    }
}
