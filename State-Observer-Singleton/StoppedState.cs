using System;

namespace State_Observer_Singleton
{
    class StoppedState : IThreadState
    {
        private static StoppedState ss = null;

        private StoppedState() { }
        public static StoppedState create()
        {
            if (ss == null)
            {
                ss = new StoppedState();
            }
            return ss;
        }
        
        public void Run(ThreadContext context)
        {
            context.State = RunnigState.create();
            Console.WriteLine("Thread çalıştırıldı");
            context.Notify(context.ThreadId, ThreadStateMachine.StartState);
        }

        public void Stop(ThreadContext context)
        {
            Console.WriteLine("Thread zaten durduruldu");
        }

        public void Wait(ThreadContext context)
        {
            
            Console.WriteLine("Durdurulmuş thread beklemeye alınamaz");
            
        }
    }
}
