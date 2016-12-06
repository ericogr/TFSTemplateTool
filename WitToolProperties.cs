using System.Collections.Generic;
using System.IO;
using System;
using System.Runtime.Serialization.Json;

namespace TemplateTool
{
    public class WitToolProperties
    {
        private const string FILENAME = "propriedades.json";

        private const string PROP_TFS_URL = "tfs_url";
        private const string PROP_TOOLS_FOLDER = "tools_folder";
        private const string PROP_TEMPLATE_FOLDER = "template_folder";

        private Dictionary<string, string> m_Properties;

        public WitToolProperties()
        {
            m_Properties = LoadProperties();
        }

        public Dictionary<string, string> Get()
        {
            return m_Properties;
        }

        public string Get(string propriedade)
        {
            return Get(propriedade, string.Empty);
        }

        public string Get(String propriedade, Template template)
        {
            return Get(propriedade, template.Name);
        }

        public string Get(string propriedade, string modificador)
        {
            string propriedadeEspecificaNormalizada = ToNormalizedProperty(propriedade + "_" + modificador);
            string propriedadeNormalizada = ToNormalizedProperty(propriedade);

            if (m_Properties.ContainsKey(propriedadeEspecificaNormalizada))
            {
                return m_Properties[propriedadeEspecificaNormalizada];
            }

            return (m_Properties.ContainsKey(propriedadeNormalizada)
                ? m_Properties[propriedadeNormalizada]
                : string.Empty);
        }

        public string Set(string propriedade, string valor)
        {
            string propriedadeNormalizada = ToNormalizedProperty(propriedade);

            m_Properties[propriedade] = valor;

            return propriedadeNormalizada;
        }

        public void Remove(string propriedade)
        {
            m_Properties.Remove(propriedade);
        }

        private string ToNormalizedProperty(string property)
        {
            return property.Trim().ToLower().Replace(' ', '_');
        }

        public string GetTemplateFolder(Template template)
        {
            return Get(PROP_TEMPLATE_FOLDER, template);
        }

        public string GetToolFolder(Template template)
        {
            return Get(PROP_TOOLS_FOLDER, template);
        }

        public string TfsUrl
        {
            get
            {
                return m_Properties[PROP_TFS_URL].ToString();
            }
            set
            {
                m_Properties[PROP_TFS_URL] = value;
            }
        }

        public string ToolsFolder
        {
            get
            {
                return m_Properties[PROP_TOOLS_FOLDER];
            }
            set
            {
                m_Properties[PROP_TOOLS_FOLDER] = value;
            }
        }

        public void Save()
        {
            string arquivo = GetPropertiesFilename();
            DataContractJsonSerializer serial = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            Stream s = null;

            CreateFolderIfNotExist(arquivo);

            try
            {
                s = new FileStream(arquivo, FileMode.OpenOrCreate);
                serial.WriteObject(s, m_Properties);
            }
            finally
            {
                if (s != null) {
                    s.Close();
                }
            }
        }

        private void CreateFolderIfNotExist(string path)
        {
            string folder = Path.GetDirectoryName(path);

            if (!System.IO.Directory.Exists(folder))
            {
                System.IO.Directory.CreateDirectory(folder);
            }
        }

        private Dictionary<string, string> LoadDefaultProperties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();

            properties[PROP_TFS_URL] = "http://localhost:8080/tfs";
            properties[PROP_TOOLS_FOLDER] = @"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE";
            properties[PROP_TEMPLATE_FOLDER] = @"C:\Templates";

            return properties;
        }

        private Dictionary<string, string> LoadProperties()
        {
            string arquivo = GetPropertiesFilename();

            if (File.Exists(arquivo))
            {
                try
                {
                    return LoadProperties(arquivo);
                }
                catch(Exception ex)
                {
                    File.Delete(arquivo);
                    Console.WriteLine($"Erro ao carregar propriedades: {ex.Message}");
                }
            }

            return LoadDefaultProperties();
        }

        private Dictionary<string, string> LoadProperties(string file)
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();
            DataContractJsonSerializer serial = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            Stream s = null;

            try
            {
                s = new FileStream(file, FileMode.Open);
                ret = (Dictionary<string, string>)serial.ReadObject(s);

                return ret;
            }
            finally
            {
                if (s != null)
                {
                    s.Close();
                }
            }
        }

        private string GetPropertiesFilename()
        {
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                System.Reflection.Assembly.GetEntryAssembly().GetName().Name,
                FILENAME);
        }
    }
}
