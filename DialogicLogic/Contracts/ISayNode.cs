namespace DialogicLogic
{
    public interface ISayNode
    {
        ISayNode Say(string message);

        IAskNode Ask(string message);

        /// <summary> Goes up the tree to the nearest IfRepliesNode </summary>
        /// <exception>throws SomeException</exception>
        IAskNode Fi();
    }
}