namespace DialogicLogic
{
    public interface ISayNode : IDialogueNode
    {
        ISayNode Say(string message);

        IAskNode Ask(string message);
    }
}