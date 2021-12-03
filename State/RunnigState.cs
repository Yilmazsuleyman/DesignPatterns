using System;

namespace State
{
    internal class RunnigState : IThreadState
    {
       
        public void Stop(ThreadContext context)
        {
            context.State = new StoppedState();
            Console.WriteLine("Thread durduruldu");
            
        }

        public void Wait(ThreadContext context)
        {
            context.State = new WaitingState();
            Console.WriteLine("Thread geçici olarak çizelgeleme dışına çıkarıldı");
        }

        public void Run(ThreadContext context)
        {
            Console.WriteLine("Thread zaten çalışır durumda");
        }
    }
}
