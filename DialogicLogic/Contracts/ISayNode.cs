namespace DialogicLogic
{
    public interface ISayNode : IDialogueNode
    {
        ISayNode Say(string message);

        IAskNode Ask(string message);

        /// <summary> Goes up the tree to the nearest IfRepliesNode </summary>
        /// <exception>throws SomeException</exception>
        IAskNode Fi();
    }
}