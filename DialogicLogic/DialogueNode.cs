using System;
namespace DialogicLogic
{
    public abstract class DialogueNode : IDialogueNode
    {
        private string _content;
        public string Content { get => _content;} 
        
        private IDialogueNode _previousNode;
        
        public IDialogueNode Previous { get => _previousNode; }

        public abstract IDialogueNode Next { get; }

        public IDialogueNode Root { 
            get {
                IDialogueNode curr = this;
                while(curr.Previous != null) curr = curr.Previous;
                return curr;
            }
        }

        public DialogueNode(string content, IDialogueNode parent = null)
        {
            if( string.IsNullOrWhiteSpace(content) )
            {
                throw new ArgumentNullException("content should not be null or empty");
            }

            _content = content.Trim();
            _previousNode = parent;
        }
        
        public IAskNode Fi()
        {
            IDialogueNode curr = this.Previous;
            while(curr != null && !curr.IsIAskNode()) curr = curr.Previous;

            return curr.IsIAskNode() ? curr.ToIAsk() : throw new InvalidOperationException();
        }
        
    }
}
