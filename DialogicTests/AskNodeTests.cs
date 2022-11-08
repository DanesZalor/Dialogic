using DialogicLogic;
namespace DialogicTests;

public class AskNodeTests
{
    public class ChoiceKey
    {

        [Fact]
        public void ShouldThrowExceptionWhenGetWithoutSet()
        {
            IAskNode an = new AskNode("aa");

            Action act = () => Console.Write(an.ChoiceKey);

            var error = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("ChoiceKey must be set before get", error.Message);
        }

        [Fact]
        public void ShouldThrowExceptionWhenSetWithExistingKey()
        {
            Action act = () => {
                IDialogueNode an = new SayNode("Hello greetings lad")
                .Ask("Are you a boy/girl")
                .IfReplies("boy")
                    .Say("okay you're a boy")
                    .Fi()
                .IfReplies("boy")
                    .Say("yes i see");
            };

            Assert.ThrowsAny<Exception>(act);
        }
    }

    [Fact]
    public void IfBranchTests()
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
        ;

        Assert.Equal("Hello", tree.Root.Content);
        Assert.Equal("ok cool", (tree.Root.Next.Next as IAskNode).GetNext("boy").Content);
    } 
}
