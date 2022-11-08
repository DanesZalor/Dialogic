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
                    .Fi();
            };

            Assert.ThrowsAny<Exception>(act);

        }
    }
}
