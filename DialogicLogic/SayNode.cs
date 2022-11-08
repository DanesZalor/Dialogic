using System;

namespace DialogicLogic
{
    public sealed class SayNode : DialogueNode, ISayNode
    {
        
        private IDialogueNode _next;
        
        public override IDialogueNode Next { get => _next; }


        public SayNode(string content, IDialogueNode parent = null) : base(content, parent) {}

        public ISayNode Say(string message)
        {
            _next = new SayNode(message, this);
            return _next as ISayNode;
        }

        public IAskNode Ask(string message)
        {
            _next = new AskNode(message, this);
            return _next as IAskNode;
        }

        public IAskNode Fi()
        {
            try{
                IDialogueNode curr = this.Previous;
                while(curr != null && !(curr is IAskNode)) 
                    curr = curr.Previous;
                return curr as IAskNode;
            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}