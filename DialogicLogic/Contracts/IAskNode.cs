namespace DialogicLogic
{
    public interface IAskNode : IDialogueNode
    {
        IIfRepliesNode IfReplies(string message);
    }
}