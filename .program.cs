
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            LinkList testList = new LinkList();
            testList.AddItem(1);
            testList.AddItem(2);
            testList.AddItem(3);
            testList.AddItem(2);
            testList.AddItem(5);
            testList.AddItem(6);
            testList.AddItem(7);
            testList.AddItem(8);
            testList.DisplayItems();
            testList.NumberOfItems();
            testList.IsPresentItem(2);
            testList.RemoveItem(4);
            Console.ReadKey();

           


        }
    }
}
