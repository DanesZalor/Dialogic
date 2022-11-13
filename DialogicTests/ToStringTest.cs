using DialogicLogic;

namespace DialogicTests;

public class ToStringTest
{
    [Fact]
    public void ShouldReturnString()
    {
        IDialogueNode tree = new SayNode("Hello")
                .Say("Nice to meet you")
                .Ask("Are you a boy or a girl")
                    .IfReplies("boy")
                        .Say("ok cool")
                        .Say("gtg man")
                        .Fi()
                    .IfReplies("girl")
                        .Say("oh hmmm")
                        .Ask("are you single?")
                            .IfReplies("yes")
                                .Say("im single too btw")
                                .Fi()
                            .IfReplies("no")
                                .Say("ayt cool")
                                .Fi()
                        .Fi()
                    .IfReplies("prefer not to say")
                        .Say("damn im sorry").Root;
        
        System.Console.WriteLine(tree.ToString(0));
        Assert.True(true);
    }
}