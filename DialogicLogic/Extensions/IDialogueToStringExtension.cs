using System;

namespace DialogicLogic
{
    public static class IDialogueToStringExtension
    {
        public static string ToString(this IDialogueNode inode, int level) 
        {
            if(inode.IsIAskNode()) 
                return inode.ToIAsk().ToString(level);
            
            else if(inode is ISayNode) return (inode as ISayNode).ToString(level);

            else return "";
        }

        public static string ToString(this ISayNode inode, int level)
        {
            string s = new string(' ', level) + $"{inode.Content}\n";
            if(inode.Next!=null) s += $"{inode.Next.ToString(level)}";
            return s;
        }

        public static string ToString(this IAskNode inode, int level)
        {
            string s = new string(' ', level) + $"{inode.Content}\n";

            foreach(var key in inode.Choices)
            {
                s += new string(' ', level+2) + $"if({key}):\n";
                s += $"{inode.GetNext(key).ToString( level + 4)}";
            }

            return s ;
        }
    }
}