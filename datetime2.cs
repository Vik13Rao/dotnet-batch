using System;
namespace datetime2

{
    class Difftime{
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime (2022,08,02);
            DateTime date2 = new DateTime(2000,11,13);
            datetime2.difference.diff(date1,date2);
        }
    }

    class difference{
        public static void diff(DateTime date1, DateTime date2)
        {
            
            TimeSpan t = date1-date2;
            Console.WriteLine("Timespan:"+t);

        }
    }
    
}