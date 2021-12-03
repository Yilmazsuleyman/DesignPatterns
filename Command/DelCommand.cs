namespace Command
{
    public sealed class DelCommand : Command
    {
        private Kernel kernel = new Kernel();
        private string path;

        public override string Path { get { return path; } set { path = value; } }

        public override void execute()
        {
            kernel.QuitAPI();
        }
    }
}
