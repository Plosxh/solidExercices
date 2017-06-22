using System.Collections.Generic;

namespace SolidExercices.Console
{
    public class Program
    {
        public static void Main()
        {
            ConnecteurFichier operationsListe = new ConnecteurFichier();
            List < IOperationInterface > interfaces= new List<IOperationInterface>();
            OperationInterfaceMult mult = new OperationInterfaceMult();
            OperationInterfaceDiv div = new OperationInterfaceDiv();
            OperationInterfaceSum sum = new OperationInterfaceSum();
            OperationInterfaceSub sub = new OperationInterfaceSub();
            interfaces.Add(mult);
            interfaces.Add(div);
            interfaces.Add(sum);
            interfaces.Add(sub);
            var calculatorTrainer = new CalculatorTrainer(operationsListe);
            calculatorTrainer.Run(interfaces);
        }
    }
}
