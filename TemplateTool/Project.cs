namespace TemplateTool
{
    public class Project
    {
        public Project(Collection collection, string nome)
        {
            this.Collection = collection;
            this.Nome = nome;
        }

        public string Nome {
            get;
        }

        public Collection Collection
        {
            get;
        }

    }
}
