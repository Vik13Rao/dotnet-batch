using System;

namespace swapstring
{
    class Test
    {
        public static void Main(string[] args)
        {
            string i= "a";
            string j = "b";
            SwapS(ref i , ref j);
            Console.WriteLine("i="+i);
            Console.WriteLine("J="+j);
            
        }
    

    
    
        public static void SwapS(ref string str1, ref string str2)
        {
            str1= "b";
            str2= "a";
        }
    
    }
    
}