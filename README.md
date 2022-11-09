# Dialogic

Making my own implementation of dialogue tree that is code readable.

Let's say we want to make a dialogue tree like


```
├─ どぞよろしく。
└─ 君のちんちんは大きいですか？
    ├── いいえ、小さいです。
    │   ├─ あ、そう。
    │   └─ かなしい。
    └── ええ、そう
        ├── いいね。
        └── 見せてください？
            ├── はい、みって
            │   ├─ それは大きい。
            │   └─ いいね
            └── だめ
                └── すみあせん。
```

### Generic Way
```C#
new Say("どぞよろしく",
    new Ask("君のちんちんは大きいですか？"
        new Choice("いいえ、小さいです", 。。。)
    )
)
```
Reliable; has compile-time error checking with delimiters and proper state shifts BUT compromises readability.

### My Solution
```C#
 new Say("どぞよろしく")
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
                    .Fi();
```

Readable; has proper state shift using state machines BUT compromises error-checking. `Fi()` delimiter is checked on run-time.