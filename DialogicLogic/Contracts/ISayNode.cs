namespace DialogicLogic
{
    public interface ISayNode : IDialogueNode, IFiAble
    {
        ISayNode Say(string message);

        IAskNode Ask(string message);
    }
}