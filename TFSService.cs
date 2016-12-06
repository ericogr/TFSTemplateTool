using System;
using System.Collections.Generic;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;

namespace TemplateTool
{
    public class TFSService
    {
        public TFSService(string url)
        {
            this.Url = url;
        }

        public string Url
        {
            get;
        }

        public IList<Collection> GetCollections()
        {
            Uri tfsUri = new Uri(this.Url);
            TfsConfigurationServer configuracao = TfsConfigurationServerFactory.GetConfigurationServer(tfsUri);
            ITeamProjectCollectionService tpcService = configuracao.GetService<ITeamProjectCollectionService>();

            IList<TeamProjectCollection> tfsCollections = tpcService.GetCollections();
            IList<Collection> collections = new List<Collection>();

            foreach(TeamProjectCollection tpc in tfsCollections)
            {
                collections.Add(new Collection(tpc.Name));
            }

            return collections;
        }

        public List<Project> GetProjects(string collection)
        {
            return obterProjetos(new Collection(collection));
        }

        public List<Project> GetProjects(List<string> collections)
        {
            List<Project> projetos = new List<Project>();

            collections.ForEach((collection) => {
                List<Project> projetosParcial = GetProjects(collection);

                projetosParcial.ForEach((projeto) =>
                {
                    projetos.Add(projeto);
                });
            });

            return projetos;
        }

        public List<Project> obterProjetos(Collection collection)
        {
            TfsTeamProjectCollection tfs = new TfsTeamProjectCollection(new Uri(this.Url + "/" + collection.Name));

            CatalogNode catalogNode = tfs.CatalogNode;
            IReadOnlyCollection<CatalogNode> tpNodes = catalogNode.QueryChildren(
                new Guid[] { CatalogResourceTypes.TeamProject },
                false,
                CatalogQueryOptions.None);

            List<Project> projetos = new List<Project>();

            foreach (CatalogNode cn in tpNodes)
            {
                projetos.Add(new Project(collection, cn.Resource.DisplayName));
            }

            return projetos;
        }
    }
}
