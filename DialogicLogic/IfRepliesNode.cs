using System;
using System.Collections.Generic;

namespace DialogicLogic
{
    public sealed class IfRepliesNode : IIfRepliesNode
    {
        private IAskNode _parentRef;
        private Dictionary<string, IDialogueNode> _parentChoicesRef;
        private string _replyKey;

        public IfRepliesNode(string replyKey, IAskNode parent, Dictionary<string, IDialogueNode> choices)
        {
            if(parent == null)
                throw new ArgumentNullException("parent cannot be null");

            _replyKey = replyKey;
            _parentRef = parent;
            _parentChoicesRef = choices;
        }

        public ISayNode Say(string message)
        {
            _parentChoicesRef[_replyKey] = new SayNode(message, _parentRef);
            return _parentChoicesRef[_replyKey] as ISayNode;
        }

        public IAskNode Ask(string message)
        {
            _parentChoicesRef[_replyKey] = new AskNode(message, _parentRef);
            return _parentChoicesRef[_replyKey] as IAskNode;
        }
    }
}