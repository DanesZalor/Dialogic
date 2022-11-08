namespace DialogicLogic
{
    public class SayNode : DialogueNode, ISayNode
    {
        
        private IDialogueNode _next;
        
        public override IDialogueNode Next { get => _next; }


        public SayNode(string content, DialogueNode parent = null) : base(content, parent) {}

        public ISayNode Say(string message)
        {
            _next = new SayNode(message, this);
            return (_next as ISayNode);
        }

        public IAskNode Ask(string message)
        {
            throw new System.NotImplementedException();
        }

        public IAskNode Fi()
        {
            throw new System.NotImplementedException();
        }
        
    }
}