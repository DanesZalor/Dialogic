using System;

namespace DialogicLogic
{
    public static class IDialogueNodeExtensions
    {
        public static IAskNode ToIAsk(this IDialogueNode inode)
        {
            return (inode is IAskNode) 
                ? (inode as IAskNode) 
                : throw new InvalidCastException($"Cannot cast {inode.GetType().Name} to IAskNode");
        }
        
        public static bool IsIAskNode(this IDialogueNode inode)
            => inode is IAskNode;
    }
}


