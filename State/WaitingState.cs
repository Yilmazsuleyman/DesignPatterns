using System;

namespace State
{
    internal class WaitingState : IThreadState
    {
        public void Run(ThreadContext context)
        {
            context.State = new RunnigState();
            Console.WriteLine("Thread  beklemeden, çalışma durumuna çekildi");
        }

        public void Stop(ThreadContext context)
        {
            context.State = new StoppedState();
            Console.WriteLine("Thread beklemeden, durduruldu durumuna çekildi");
        }

        public void Wait(ThreadContext context)
        {
            Console.WriteLine("Thread Zaten Beklemede");
        }
    }
}
