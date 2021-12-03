namespace State_Observer_Singleton
{
    internal interface IObservable
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify(string ThreadID, ThreadStateMachine tsm);
    }
}
