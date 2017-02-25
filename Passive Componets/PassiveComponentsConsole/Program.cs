using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passive_Componets;
using System.Numerics;

namespace PassiveComponentsConsole
{
    class Program
    {
        static void Main()
        {
            var passiveComponents = new List<IElement>();

            var r1=new Resistor(5.3);

            var l1=new Inductor(2.8);

            var c1=new Capacitor(6.9);

            passiveComponents.Add(r1);

            passiveComponents.Add(l1);

            passiveComponents.Add(c1);

            foreach (var comp in passiveComponents)
            {
                Console.WriteLine("{0}. Комплексное сопротивление = {1}.",comp.GetType(),comp.GetImpedance(1));
            }
            Console.Read();
        }
    }
}
