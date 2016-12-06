using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TemplateTool
{
    public class TemplateDecorator
    {
        private const string REGEX_TEMPLATE = @"\{(.+?)\}";
        private const string TFS_URL = "tfs_url";
        private const string TFS_COLLECTION_NAME = "tfs_collection_name";
        private const string TFS_PROJECT_NAME = "tfs_project_name";
        private const string TOOLS_FOLDER = "tools_folder";
        private const string TEMPLATE_FOLDER = "template_folder";

        private Dictionary<string, string> parameters = new Dictionary<string, string>();

        public TemplateDecorator(string urlTfs, string collection, string project, string toolsFolder, string templateFolder)
        {
            parameters.Add(TFS_URL, urlTfs);
            parameters.Add(TFS_COLLECTION_NAME, collection);
            parameters.Add(TFS_PROJECT_NAME, project);
            parameters.Add(TOOLS_FOLDER, toolsFolder);
            parameters.Add(TEMPLATE_FOLDER, templateFolder);
        }


        public string Decorate(Template template)
        {
            return Regex.Replace(template.Command, REGEX_TEMPLATE, m => parameters[m.Groups[1].Value]);
        }

    }
}
