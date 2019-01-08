# LinkedList

To get the behaviour we want exactly we must write or use a different list class. The expected behaviour is that concatenating two lists should be an O(1) operation. That can be achieved with a lot of extra work.

In this version I have made the `Concatenate` function destructive, that is, it moves the contents of one list into the other. The input list `LLi` will be empty after the operation. This is desirable to prevent the two list instances corrupting the other's content. For example, if the list `LLi` was not cleared by the `Concatenate` function, additional elements could be added to it afterwards which would then invalidate the `tail` and `count` parameters of `LLs`.
