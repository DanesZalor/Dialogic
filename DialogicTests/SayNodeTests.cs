using DialogicLogic;

namespace DialogicTests;

public class SayNodeTests
{
    [Fact]
    public void ShouldReturnPreviousAndNextNode()
    {
        var sn = new SayNode("First Message").Say("Second Message");

        Assert.Equal("Second Message", sn.Content);
        Assert.Equal("First Message", sn.Previous.Content);
        Assert.Equal("Second Message", sn.Previous.Next.Content);
    }

    [Fact]
    public void ShouldReturnRootNode()
    {
        var sn = new SayNode("First").Say("Second").Say("Third");

        Assert.Equal("Third", sn.Content);
        Assert.Equal("First", sn.Root.Content);
    }
}