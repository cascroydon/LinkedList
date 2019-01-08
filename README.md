# LinkedList

An example attempting to link two lists of different types.

With line 18 commented out:

    //LLs.AddLast(LLi);

The program will compile and produce the output:

    We have the following 2 items in the is the list.
    Node's data is Dudeo
    Node's data is Smell

However, if we attempt to join the lists with line 18 we get this error:

    Program.cs(18,15): error CS1503: Argument 1: cannot convert from 'System.Collections.Generic.LinkedList<int>' to 'string'

The compiler is complaining that it can't link the LinkedList containing int objects to a LinkedList containing string objects.