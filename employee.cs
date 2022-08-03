using System;

namespace employee
{
    class test
    {
        public static void Main(string[] args)
        {
            string name1= "Vikram Rao";
            string addr1= "Kandivali";
            string name2= "John Cena";
            string addr2= "Usa";
            employee.emp.list(name1, addr1, name2, addr2);

        }
    }

    public class emp
    {
        public static void list(string str1,string addr1, string str2, string addr2)
        {
            string details1, details2;
            details1 = "Name:"+str1+" Address:"+addr1+" ";
            details2 = "Name:"+str2+" Address:"+addr2;
            Console.WriteLine("Emp Details:");
            Console.WriteLine("1."+details1);
            Console.WriteLine("2."+details2);

        }
    }
    }