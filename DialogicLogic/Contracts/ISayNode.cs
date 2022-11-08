namespace DialogicLogic
{
    public interface ISayNode
    {
        ISayNode Say(string message);

        IAskNode Ask(string message);

        IAskNode Fi();
    }
}