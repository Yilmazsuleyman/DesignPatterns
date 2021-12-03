namespace State
{
    internal interface IThreadState
    {
        void Run(ThreadContext context);
        void Stop(ThreadContext context);
        void Wait(ThreadContext context);
    }
}
