namespace DialogicLogic
{
    public interface IAskNode : IDialogueNode
    {
        string ChoiceKey {get; set;}

        IIfRepliesNode IfReplies(string reply);

        IDialogueNode GetNext(string key);
    }
}