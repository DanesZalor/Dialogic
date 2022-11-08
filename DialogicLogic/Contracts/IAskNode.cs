namespace DialogicLogic
{
    public interface IAskNode : IDialogueNode
    {
        string ChoiceKey {get; set;}
        IIfRepliesNode IfReplies(string reply);
    }
}