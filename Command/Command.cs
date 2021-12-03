namespace Command
{
    public abstract class Command
    {
        public abstract string Path { get; set; }
        public abstract void execute();
    }
}
