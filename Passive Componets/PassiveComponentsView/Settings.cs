using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PassiveComponentsView
{
    public class Settings
    {
        public static Settings GetElements()
        {
            Settings settings = null;
            string filename = Globals.ElementsFile;
            if ( File.Exists(filename) )
            {
                using (var fileStream = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(Settings));
                    settings = (Settings)xser.Deserialize(fileStream);
                    fileStream.Close();
                }
            }
            else
            {
                settings = new Settings();   
            }
            return settings;
        }

        public void Save()
        {
            string filename = Globals.ElementsFile;

            if ( File.Exists(filename) )
            {
                File.Delete((filename));
            }

            using (var filestrem = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Settings));
                xser.Serialize(filestrem, this);
                filestrem.Close();
            }
        }

        public  DataGridViewTextBoxColumn Name { get; set; }

        public DataGridViewTextBoxColumn Nominal { get; set; }

        public  DataGridViewTextBoxColumn Impedance { get; set; }
    }
}