using System;

namespace State
{
    class StoppedState : IThreadState
    {

        public void Stop(ThreadContext context)
        {
            Console.WriteLine("Thread zaten durdurulmuştu");
        }

        public void Wait(ThreadContext context)
        {
            Console.WriteLine("Thread duraklatılmış, beklemeye alınamaz");
        }

        public void Run(ThreadContext context)
        {
            context.State = new RunnigState();
            Console.WriteLine("Thread  çalışırmaya başladı");
            
            
        }
    }
}
