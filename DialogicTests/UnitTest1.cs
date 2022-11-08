using DialogicLogic;

namespace DialogicTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        new DialogueTree()
            .Say("greetings fellow citizen")
            .Ask("Are you a boy or a girl")
                .IfReplies("boy")
                    .Say("ayt cool")
                .IfReplies("girl")
                    .Ask("are you single")
                        .IfReplies("yes").Say("nice")
                        .IfReplies("no").Say("ayt cool")
                    .EndIf()
                .EndIf()
            ;
                
    }
}