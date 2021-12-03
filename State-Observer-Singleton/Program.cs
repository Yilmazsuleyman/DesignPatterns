using System;

namespace State_Observer_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadContext thread = new ThreadContext();
            ThreadMonitor monitor = new ThreadMonitor();

            thread.Register(monitor);

            thread.Start();
            thread.Start();
            thread.Sleep();
            thread.Start();
            thread.Abort();
            thread.Start();
            thread.Abort();
            thread.Abort();
        }
    }
}
