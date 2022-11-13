using System;
using System.Collections.Generic;

namespace DialogicLogic
{
    public sealed class AskNode : DialogueNode, IAskNode
    {

        private Dictionary<string, IDialogueNode> _children;

        private string _choiceKey;


        public IEnumerable<string> Choices => _children.Keys;
        
        public string ChoiceKey 
        {
            get {
                if( string.IsNullOrEmpty(_choiceKey) ) 
                    throw new InvalidOperationException("ChoiceKey must be set before get");
                
                return _choiceKey;
            }
            set {
                if( !_children.ContainsKey(value) )
                    throw new InvalidOperationException("ChoiceKey doesn't exist among the choices");

                _choiceKey = value;
            }
        }

        public AskNode(string content, IDialogueNode parent = null) 
        : base(content, parent) 
        {
            _children = new Dictionary<string, IDialogueNode>();
        }

        public override IDialogueNode Next => _children[ChoiceKey];

        public IDialogueNode GetNext(string reply)
            => _children[reply];

        public IIfRepliesNode IfReplies(string reply)
        {
            _children.Add(reply, null);

            return new IfRepliesNode(reply, this, _children);           
        }
    }
}