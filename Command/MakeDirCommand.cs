namespace Command
{
    public sealed class MakeDirCommand: Command
    {
        private Kernel kernel = new Kernel();
        private string path;

        public override string Path { get { return path; } set { path = value; } }

        public override void execute() {
            kernel.MkDirAPI(path);
        }
    }
}
