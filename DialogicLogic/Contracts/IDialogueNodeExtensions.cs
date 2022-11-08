namespace DialogicLogic
{
    public static class IDialogueNodeExtensions
    {
        public static IAskNode ToIAsk(this IDialogueNode inode){
            return inode as IAskNode;
        }
    }
}


