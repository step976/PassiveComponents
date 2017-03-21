using System;

namespace PassiveComponentsView
{
    [Serializable]

    public class Element
    {
        public static string name;
        public static string nominal, impedance;

        public Element(string name, string nominal, string impedance)
        {
            Element.name = name;
            Element.nominal = nominal;
            Element.impedance = impedance;
        }
    }
}