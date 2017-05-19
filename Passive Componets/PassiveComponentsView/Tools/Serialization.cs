using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Passive_Componets;
using System.Numerics;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace PassiveComponentsView.Tools
{
    class Serialization
    {
        private BinaryFormatter _formatter = new BinaryFormatter();

        /// <summary>
        /// Сериализация
        /// </summary>
        /// <param name="elementsProject"></param>
        public void Serialize(ElementsProject elementsProject)
        {
            using (var fs = new FileStream(elementsProject.FileName, FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, elementsProject);
            }
        }

        /// <summary>
        /// Десериализация
        /// </summary>
        /// <returns></returns>
        public ElementsProject Deserialize()
        {
            string filename = string.Empty;
            var openFileDilog = new OpenFileDialog();
            if (openFileDilog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDilog.FileName;
            }
            else
            {
                return null;
            }

            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                var elementsProject = (ElementsProject)_formatter.Deserialize(fs);

                return elementsProject;
            }
        }
    }
}
