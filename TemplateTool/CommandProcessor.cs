using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace TemplateTool
{
    public class CommandProcessor
    {
        private const int COMMAND_WAIT_TIME = 60000;
        private WitToolProperties _WitToolProperties;

        public CommandProcessor(WitToolProperties pwt)
        {
            this._WitToolProperties = pwt;
        }

        public List<string> ObterComandos(Template[] templates, List<Project> projetos)
        {
            List<string> commands = new List<string>();

            Array.ForEach<Template>(templates, template =>
            {
                projetos.ForEach((project) =>
                {
                    string templateFolder = this._WitToolProperties.GetTemplateFolder(template);
                    string toolFolder = this._WitToolProperties.GetToolFolder(template);

                    TemplateDecorator decorador = GetTemplateDecorator(templateFolder, toolFolder, project);

                    commands.Add(decorador.Decorate(template));
                });
            });

            return commands;
        }

        public ExecutedCommand ExecuteCommand(string command)
        {
            Process process = new System.Diagnostics.Process();

            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.FileName = command;

            try
            {
                process.Start();
                process.WaitForExit(COMMAND_WAIT_TIME);
                string saida = process.ExitCode == 0 ? process.StandardOutput.ReadToEnd() : process.StandardError.ReadToEnd();
                return new ExecutedCommand(process.ExitCode, saida);
            }
            catch (Exception ex)
            {
                return new ExecutedCommand(-1, ex.Message);
            }
        }

        private TemplateDecorator GetTemplateDecorator(string templateFolder, string toolFolder, Project project)
        {
            string tfsUrl = this._WitToolProperties.TfsUrl;

            return new TemplateDecorator(
                tfsUrl,
                project.Collection.Name,
                project.Nome,
                toolFolder,
                templateFolder);
        }
    }
}
