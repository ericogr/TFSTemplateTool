using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace TemplateTool
{
    [DataContract]
    public class Template
    {
        private const string FILENAME = "templates.json";
        public Template(string name, string command)
        {
            this.Name = name;
            this.Command = command;
        }

        [DataMember]
        public string Name
        {
            get;
            set;
        }

        [DataMember]
        public string Command
        {
            get;
            set;
        }

        public static Template[] CarregarTemplates()
        {
            return CarregarTemplates(Path.Combine(Application.StartupPath, FILENAME));
        }

        public static Template[] CarregarTemplates(string file)
        {
            DataContractJsonSerializer serial = new DataContractJsonSerializer(typeof(Template[]));
            Stream s = new FileStream(file, FileMode.Open);
            Template[] templates = (Template[])serial.ReadObject(s);

            s.Close();

            return templates;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
