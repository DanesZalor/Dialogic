using System;

namespace DialogicLogic
{
    public static class IDialogueToStringExtension
    {
        public static string TreeString(this IDialogueNode inode) => inode.TreeString(0);
        
        public static string TreeString(this IDialogueNode inode, int level=0) 
        {
            if(inode.IsIAskNode()) 
                return inode.ToIAsk().TreeString(level);
            
            else if(inode is ISayNode) return (inode as ISayNode).TreeString(level);

            else throw new NotImplementedException();
        }

        public static string TreeString(this ISayNode inode, int level=0)
        {
            string prefix = inode.Next == null ? "└──" : "├──";
            string s = new string(' ', level) + $"{prefix} {inode.Content}\n";
            if(inode.Next!=null) s += $"{inode.Next.TreeString(level)}";
            return s;
        }

        public static string TreeString(this IAskNode inode, int level=0)
        {
            string s =  new string(' ', level) + $"└── {inode.Content}\n";

            foreach(var key in inode.Choices)
            {
                s += new string(' ', level+4) + $" if(\"{key}\")\n";
                s += $"{inode.GetNext(key).TreeString( level + 6)}";
            }

            return s ;
        }
    }
}