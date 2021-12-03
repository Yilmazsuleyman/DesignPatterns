using System;

namespace State_Observer_Singleton
{
    class RunnigState : IThreadState
    {
        private static RunnigState rs = null;
        private RunnigState()
        {

        }
        public static RunnigState create()
        {
            if (rs == null)
            {
                rs = new RunnigState();
            }
            return rs;
        }

        public void Run(ThreadContext context)
        {
            Console.WriteLine("Thread zaten çalışır durumda");
        }

        public void Stop(ThreadContext context)
        {
            context.State = StoppedState.create();
            Console.WriteLine("Thread durduruldu");
            context.Notify(context.ThreadId, ThreadStateMachine.StopState);
        }

        public void Wait(ThreadContext context)
        {
            context.State = WaitingState.create();
            Console.WriteLine("Thread bekelmeye alındı");
            context.Notify(context.ThreadId, ThreadStateMachine.WaitState);
        }
    }
}
