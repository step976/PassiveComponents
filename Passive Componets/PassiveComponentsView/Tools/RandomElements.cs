using System;
using Passive_Componets;

namespace PassiveComponentsView.Tools
{
    public class RandomElements
    {
        /// <summary>
        /// Рандом элементов
        /// </summary>
        /// <returns></returns>
        public static IElement CreateRandomElement()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 3);

            switch (i)
            {
                case 0:
                {
                    var res = new Resistor
                    {
                        Value = rnd.Next(1, 20),
                        Name = "R"
                    };
                    return res;
                }
                case 1:
                {
                    var cap = new Capacitor
                    {
                        Name = "C",
                        Value = rnd.Next(1, 20)
                    };
                    return cap;
                }
                case 2:
                {
                    var ind = new Inductor
                    {
                        Name = "I",
                        Value = rnd.Next(1, 20)
                    };
                    return ind;
                }
            }
            return null;
        }
    }
}