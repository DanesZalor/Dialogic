namespace DialogicLogic
{
    public interface IAskNode
    {
        IIfRepliesNode IfReplies(string message);
    }
}