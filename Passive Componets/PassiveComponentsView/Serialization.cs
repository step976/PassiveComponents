using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;
using Passive_Componets;

namespace PassiveComponentsView
{
    public static class Serialization
    {
        static BinaryFormatter formatter = new BinaryFormatter();

        public static void Serialize(string fileName, List<IElement> file)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, file);
            }
        }


        public static List<IElement> Deserialize(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                List<IElement> file = (List<IElement>)formatter.Deserialize(fs);
                return file;
            }
        }
    }
}