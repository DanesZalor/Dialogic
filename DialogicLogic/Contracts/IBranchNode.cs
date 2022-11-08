namespace DialogicLogic
{
    public interface IBranchNode
    {
        ISplittingNode Ask(string message);
        
        IBranchNode Say(string message);

        IBranchNode IfReplies(string message);

        IBranchNode EndIf();
    }
}

