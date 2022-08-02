using System;
namespace Math
{
    class Operations
    {   static void Main(string[] args)
        {
        
        add ad =new add();
        sub s = new sub();
        mul m = new mul();
        div d = new div();
        
        Console.WriteLine("Enter first number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition is "+ad.Add(a,b));
        Console.WriteLine("Subtraction is "+s.Subtract(a,b));
        Console.WriteLine("Division is "+d.Divide(a,b));
        Console.WriteLine("Multiplication is "+m.Multiply(a,b));



        }
    }
    public class add
    {
        public int Add(int a,int b)
        {
            return a+b;
            
        } 
    }   
    public class sub
    {
        public int Subtract(int a, int b)
        {
            return a-b;
            
        }    
    }
    public class div
    {
        public int Divide(int a ,int b)
        {
            return  a/b;
            
        }
    }
    public class mul
    {
        public int Multiply(int a, int b)
        {
            return  a*b;
            
        }
    }
    
}
