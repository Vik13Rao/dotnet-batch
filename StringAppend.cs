using System;
using System.Text;

namespace StringAppend
{
    class test
    {
    public static void Main()
    {
      string str1= "Vikram";
      string str2= "Rao";
      StringAppend.append.Stringa(str1,str2);
      StringAppend.builder.Stringb(str1,str2);

    }

    }

    public class append
    {
        public static void Stringa(string str1,string str2)
        {   string res;
            res = str1 +str2;
            Console.WriteLine("Concatenate is :"+res);
        }
    }
    public class builder
    {   public static void Stringb(string str1,string str2)
        {
        StringBuilder addWord = new StringBuilder(str1);
        addWord.Append( str2);
        addWord.Append(" StringBuilder");
        Console.WriteLine(addWord);
        }
    }
}