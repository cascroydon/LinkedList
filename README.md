# LinkedList

To fix the error we can convert the lists to `LinkedList<object>`.

This allows us to compile and run. However now our output is:

    We have the following 3 items in the is the list.
    Node's data is Dudeo
    Node's data is Smell
    Node's data is System.Collections.Generic.LinkedList`1[System.Object]

The line:

    LLs.AddLast(LLi);

It isn't joining lists `LLi` and `LLs` together, it's adding list `LLi` as an element to the end of list `LLs`. `LinkedList<object>` is also a type of `object` and is added like any other element.

Is there an alternative function that we call to join these lists instead? [Unfortunately not](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=netframework-4.7.2]):

> The `LinkedList<T>` class does not support chaining, splitting, cycles, or other features that can leave the list in an inconsistent state. The list remains consistent on a single thread. The only multithreaded scenario supported by `LinkedList<T>` is multithreaded read operations.