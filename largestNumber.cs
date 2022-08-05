using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace largestNumber
{
    class large
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Largest number in array is "+largestNumber.array.findLargestArray()); 
            Console.WriteLine("Largest number in arrayList is "+largestNumber.arrayList.findLargestArrList());        
            // largestNumber.linkedList.push(12);
            // largestNumber.linkedList.push(14);
            // largestNumber.linkedList.push(54);
            // largestNumber.linkedList.push(67);
            Console.WriteLine("Largest number in linkedList is "+largestNumber.linkedList.findLargestLlist()); 

        }   

    }

    public class array
    {
        static int []arr = {12,3,4,9,7,34,20,17,13,23};
        public static int findLargestArray()
        {  
           int i;
           int max = arr[0];
           for(i=0; i<arr.Length-1; i++)
           {
            if(arr[i]>max)
            {
                max=arr[i];
            }
           }
           return max;
        

        }
    }

public class arrayList
    {
         
        
        public static int findLargestArrList()
        {   var arrlist = new ArrayList() {5,3,66,35,34,2,3,76,9,12};
            int max =0;
            // // List<int> list = new List<int>(){5,3,66,35,34,2,3,76,9,12};
            
            // int max = int.MinValue;
            foreach (int i in arrlist)
            {
                if(i>max)
                {
                    max = i;
                }
            }
            return max;

        }
    }
    

    public class linkedList
    {   public static int findLargestLlist()
        {
            LinkedList<int> Llist = new LinkedList<int>();
            Llist.AddLast(12);
            Llist.AddLast(23);
            Llist.AddLast(43);
            Llist.AddLast(2);
            Llist.AddLast(32);
            Llist.AddLast(25);
            Llist.AddLast(55);
            return Llist.Max();

        }
        // class node
        // {
        //     public int data;
        //     public Node next;
        // }
        // static Node head = null;

        // static void push(int data)
        // {
        //     Node newNode = new Node();
        //     newNode.data = data;
        //     newNode.next = (head);
        //     (head)= newNode;
        // }

        // static int largeElement(Node head)
        // {
        //     int max = int.MinValue;
        //     while(head!=null)
        //     {
        //         if(max<head.data)
        //         {
        //             max= head.data;
        //         }
        //         head= head.next;
        //     }
        //     return max;
        // } 

    }
    
}