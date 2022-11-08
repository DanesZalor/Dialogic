using System;
using System.Collections.Generic;

namespace DialogicLogic
{
    public sealed class IfRepliesNode : IIfRepliesNode
    {
        private IAskNode _parentRef;
        private Dictionary<string, IDialogueNode> _parentChoicesRef;
        public IfRepliesNode(IAskNode parent, Dictionary<string, IDialogueNode> choices)
        {
            _parentRef = parent;
            _parentChoicesRef = choices;
        }

        public ISayNode Say(string message)
        {
            if(_parentChoicesRef.ContainsKey(message))
                throw new InvalidOperationException($"Duplicate key '{message}'");

            _parentChoicesRef.Add(message, new SayNode(message, _parentRef));
            return _parentChoicesRef[message] as ISayNode;
        }

        public IAskNode Ask(string message)
        {
            _parentChoicesRef.Add(message, new AskNode(message, _parentRef));
            return _parentChoicesRef[message] as IAskNode;
        }
    }
}