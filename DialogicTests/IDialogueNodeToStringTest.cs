using DialogicLogic;
namespace DialogicTests;

public class IDialogueNodeToStringTest
{
    [Fact]
    public void ToStringTest()
    {
        IDialogueNode tree = new SayNode("こんにちは")
            .Say("よろしく")
            .Ask("君のちんちんは大きいですか？")
            .IfReplies("いいえ、小さいです。")
                .Say("あ、そう。")
                .Say("かなしい。")
                .Fi()
            .IfReplies("ええ、そう")
                .Say("いいね。")
                .Ask("見せてください")
                    .IfReplies("はい、みって")
                        .Say("それは大きい。")
                        .Say("いいね。")
                        .Fi()
                    .IfReplies("だめ")
                        .Say("すみません。")
                        .Fi()
        .Root;

        System.Console.WriteLine(tree.TreeString());
        Assert.True(true);
    }
}