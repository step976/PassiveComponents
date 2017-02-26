using System;
using System.Collections.Generic;
using Passive_Componets;

namespace PassiveComponentsConsole
{
    static class Program
    {
        private static void Main()
        {
            var passiveComponents = new List<IElement>();

            var r1=new Resistor(5.3);

            var l1=new Inductor(2.8);

            var c1=new Capacitor(3.5);

            passiveComponents.Add(r1);

            passiveComponents.Add(l1);

            passiveComponents.Add(c1);

            foreach (IElement comp in passiveComponents)
            {
                Console.WriteLine("{0}. Комплексное сопротивление = {1}.",comp.Type,comp.GetImpedance(1));
            }
            Console.Read();
        }
    }
}
