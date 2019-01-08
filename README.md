# LinkedList

To join the lists non-destructively you can use `System.Linq` to create an `IEnumerable` object that enumerates the first list and then the second.

Output:

    We have the following 4 items in the is the list.
    Node's data is Dudeo
    Node's data is Smell
    Node's data is 10
    Node's data is 9

This isn't giving you a list, but an intermediate object than captures the action of joining the lists together. You can see this by adding an item to the end `LLs` after performing the `Concat` operation, for example.
