using System;
using System.Collections.Generic;

namespace State_Observer_Singleton
{
    class ThreadContext : IObservable
    {
        private string ThreadID;
        private IThreadState state;
        private List<IObserver> observers;

        public string ThreadId { get { return ThreadID; } }
        public IThreadState State{ get { return state; } set { state = value; } }

        public ThreadContext()
        {
            Console.WriteLine("Thread yaratıldı ve henüz çalışmıyor");
            ThreadID = Guid.NewGuid().ToString();
            state = StoppedState.create();
            observers = new List<IObserver>();
        }
        public void Notify(string ThreadID, ThreadStateMachine tsm)
        {
            for (int i = 0; i < observers.Count-1; i++)
            {
                observers[i].Handle(ThreadID, tsm);
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Start()
        {
            state.Run(this);
        }
        public void Abort()
        {
            state.Stop(this);
        }
        public void Sleep()
        {
            state.Wait(this);
        }

    }
}
