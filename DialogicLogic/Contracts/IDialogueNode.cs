namespace DialogicLogic{
    public interface IDialogueNode
    {
        string Content { get; }

        IDialogueNode Previous { get; }

        IDialogueNode Next { get; }

        IDialogueNode Root { get; }

        IAskNode Fi();

        string ToString(int level);
    }

}
