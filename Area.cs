using System;
using System.Text;

namespace Area
{
    class test
    {
    public static void Main(string[] args)
    {
      int l= 5;
      int b= 9;
      Area.square.AreaS(l);
      Area.rectangle.AreaR(l,b);

    }

    }

    public class square
    {
        public static void AreaS(int l)
        {   int res;
            res = l*l;
            Console.WriteLine("Area of square is :"+res);
        }
    }
    public class rectangle
    {   public static void AreaR(int l,int b)
        {
            Console.WriteLine("Area of rectangle is :"+(l*b));
        }
    }
}