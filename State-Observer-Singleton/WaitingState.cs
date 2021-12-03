using System;

namespace State_Observer_Singleton
{
    class WaitingState : IThreadState
    {
        private static WaitingState ws = null;
        private WaitingState() { }
        public static WaitingState create()
        {
            if (ws == null)
            {
                ws = new WaitingState();
            }
            return ws;
        }

        public void Run(ThreadContext context)
        {
            context.State = RunnigState.create();
            Console.WriteLine("Duran Thread çalıştırıldı");
            context.Notify(context.ThreadId, ThreadStateMachine.StartState);
        }

        public void Stop(ThreadContext context)
        {
            context.State = StoppedState.create();
            Console.WriteLine("Bekleyen Thread durduruldu");
            context.Notify(context.ThreadId, ThreadStateMachine.StopState);
        }

        public void Wait(ThreadContext context)
        {
            Console.WriteLine("Thread zaten beklemede");
        }
    }
}
