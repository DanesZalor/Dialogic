namespace DialogicLogic
{
    public interface IIfRepliesNode
    {
        ISayNode Say(string message);

        IAskNode Ask(string message);
    }
}