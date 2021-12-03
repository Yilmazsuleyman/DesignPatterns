namespace Command
{
    public sealed class QuitCommand : Command
    {
        private Kernel kernel = new Kernel();
        private string path;

        public override string Path { get { return ""; } set { } }

        public override void execute()
        {
            kernel.QuitAPI();
        }
    }
}
