using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TeacherProj
{
   class Data_teacher
   {
    public static void Main(string[] args)
    { LinkedList<string>l1 = new LinkedList<string>();
      LinkedList<string>l2 = new LinkedList<string>();
      String path = @"C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\Assessment\Assessment1\TeacherInfo.txt";
      string[] lines;
      lines = File.ReadAllLines(path);
      foreach(string line in lines)
      l1.AddLast(line);
      
      Console.WriteLine("Enter 1. to view data");
      Console.WriteLine("Enter 2. to insert data");
      Console.WriteLine("Enter 3. to delete data");
      
      
      string choice = Console.ReadLine();
      switch(choice)
      {
         case "1":
            Console.WriteLine("Viewing data");
            foreach(string i in l1)
            Console.WriteLine(i);
            break;
         
          case "2":
            Console.WriteLine("Inserting data");
            Console.WriteLine("Enter Teacher ID to insert");
            string  id_insert = Console.ReadLine();
            Console.WriteLine("Enter Teacher Name to insert:");
            string name_insert = Console.ReadLine();
            Console.WriteLine("Enter class to insert");
            string class_insert = Console.ReadLine();

            string data_insert ="TeacherID: " + id_insert +" , TeacherName: " +name_insert + " , Class: " +class_insert;
            l1.AddLast(data_insert);
            Console.WriteLine("Inserted data");

            foreach(string line in l1)
            Console.WriteLine(line);
            TextWriter writer1 = new StreamWriter(path);
            writer1.Flush();
            foreach(string i in l1)
            writer1.WriteLine(i);
            writer1.Close();
            Console.WriteLine("data inserted");
            break;

          case "3":
            Console.WriteLine("Deleting data");
            Console.WriteLine("Enter TeacherID to delete:");
            string id_delete =Console.ReadLine();
            id_delete = "TeacherID: "+id_delete;
            foreach(string line in l1)
            {
              if(line.Contains(id_delete))
              {continue;
              }
            
              else
              {
              l2.AddLast(line);
              }
            }
            foreach(string line in l2)
            Console.WriteLine(line);
            TextWriter writer = new StreamWriter(path);
            writer.Flush();
            foreach(string i in l2)
            writer.WriteLine(i);
            writer.Close();
            Console.WriteLine("Delete successful");
            break;

         default:
            Console.WriteLine("Invalid option");
            
            break;

      }
      

    }
   } 
}