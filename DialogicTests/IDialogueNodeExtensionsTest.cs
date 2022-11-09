using DialogicLogic;

namespace DialogicTests;

public class IDialogueNodeExtensionsTest
{
    public class IsIAskNode
    {
        [Fact]
        public void ShouldReturnTrueIfObjectIsIAskNode()
        {
            IDialogueNode node = new AskNode("Amogus?");

            Assert.True(node.IsIAskNode());
        }

        [Fact]
        public void ShouldReturnFalseIfObjectIsNotIIAskNode()
        {
            IDialogueNode node = new SayNode("amogus");

            Assert.False(node.IsIAskNode());
        }
    }

    public class ToIAsk
    {
        [Fact]
        public void ShouldConvertAnAskNodeCastedAsIDialogueToIAskNode()
        {
            IDialogueNode node = new AskNode("amogus?");

            Assert.True( node.ToIAsk() is IAskNode );
        }

        [Fact]
        public void ShouldThrowExceptionWhenTryingToConvertNoneAskNodeToIAskNode()
        {
            Action act = () => new SayNode("amogus").ToIAsk();

            var error = Assert.ThrowsAny<InvalidCastException>(act);

            Assert.Equal("Cannot cast SayNode to IAskNode",error.Message);
        }
    }
}
