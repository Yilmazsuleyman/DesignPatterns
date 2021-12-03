using System;

namespace State_Observer_Singleton
{
    class ThreadMonitor : IObserver
    {

        public void Handle(string ThreadID, ThreadStateMachine tsm)
        {
            switch (tsm)
            {
                case ThreadStateMachine.StartState:
                    Console.WriteLine("ThreadID: {0} running", ThreadID);
                    break;
                case ThreadStateMachine.StopState:
                    Console.WriteLine("ThreadID: {0} stopped", ThreadID);
                    break;
                case ThreadStateMachine.WaitState:
                    Console.WriteLine("ThreadID: {0} waiting", ThreadID);
                    break;
            }
        }
    }
}
