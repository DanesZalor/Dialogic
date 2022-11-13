using System.Collections.Generic;

namespace DialogicLogic
{
    public interface IAskNode : IDialogueNode
    {
        IEnumerable<string> Choices {get;}
        
        string ChoiceKey {get; set;}

        IIfRepliesNode IfReplies(string reply);

        IDialogueNode GetNext(string key);
    }
}