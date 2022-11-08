namespace DialogicLogic
{
    public interface IIfRepliesNode : IDialogueNode
    {
        ISayNode Say(string message);

        IAskNode Ask(string message);
    }
}