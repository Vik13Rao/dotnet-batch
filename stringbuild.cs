using System;
using System.Text;

namespace stringbuild
{
    class test
    {
    public static void Main()
    {
        StringBuilder addWord = new StringBuilder("Abcd");
        addWord.Append(", dEFGT");
        addWord.Append(",Okay");
        Console.WriteLine(addWord);
    }

    }
}