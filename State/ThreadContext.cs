using System;

namespace State
{
    class ThreadContext
    {
        private IThreadState state;
        public IThreadState State { get { return state;} set { state = value; } }

        public ThreadContext()
        {
            Console.WriteLine("Thread yaratıldı ve henüz çalışmıyor");
            state = new StoppedState();
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
