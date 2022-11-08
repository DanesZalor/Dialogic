namespace DialogicLogic
{
    public class DialogueTree : IBranchNode, ISplittingNode
    {
        public ISplittingNode Ask(string message)
        {
            throw new System.NotImplementedException();
        }

        public IBranchNode EndIf()
        {
            throw new System.NotImplementedException();
        }

        public IBranchNode IfReplies(string message)
        {
            throw new System.NotImplementedException();
        }

        public IBranchNode Say(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}
