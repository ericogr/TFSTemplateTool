namespace TemplateTool
{
    public class ExecutedCommand
    {
        public ExecutedCommand(int code, string returnedText)
        {
            this.Code = code;
            this.ReturnedText = returnedText;
        }

        public int Code
        {
            get;
        }

        public string ReturnedText
        {
            get;
        }
    }
}