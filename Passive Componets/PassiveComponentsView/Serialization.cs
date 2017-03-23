using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;

using Passive_Componets;

namespace PassiveComponentsView
{
    public static class Serialization
    {
        private static readonly BinaryFormatter _formatter = new BinaryFormatter();

        public static void Serialize(string fileName, List<IElement> file)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, file);
            }
        }

        public static List<IElement> Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var file = (List<IElement>)_formatter.Deserialize(fs);
                return file;
            }
        }
    }
}