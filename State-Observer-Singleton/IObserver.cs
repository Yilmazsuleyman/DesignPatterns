namespace State_Observer_Singleton
{
    interface IObserver
    {
        void Handle(string ThreadID, ThreadStateMachine tsm);
    }
}
