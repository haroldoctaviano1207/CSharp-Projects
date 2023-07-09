namespace SignalRIntro.API
{
    public interface IChatClient
    {
        Task ReceivedMessage(string message);
    }
}
