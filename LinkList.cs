using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_LinkedList
{
    class LinkList
    {

        public Link list = null; //default value – empty list


        


        public void AddItem(int item)
        {
            list = new Link(item, list);
        }


        public void DisplayItems()
        {
            Link temp = list;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

        }


        public int NumberOfItems() // returns number of items in list
        {
            Link temp = list;
            int count = 0;

            while (temp != null) // move one link and add 1 to count
            {
                count++;

                temp = temp.Next;
            }
            Console.WriteLine("Number Of Items: " + count + ".");


            return count;
        }

        public bool IsPresentItem(int item)
        {
            bool txf;
            Link temp = list;
            int count = 0;
            while (temp != null)
            {
                if (item.Equals(temp.Data))
                {
                    count++;
                }
                temp = temp.Next;
            }
                if (count > 0)
                {
                    Console.WriteLine("There are " + " instances of " + item + ".");
                    txf = true;

                }

                else
                {

                    Console.WriteLine("There are no instances of " + item + ".");
                    txf = false;

                }

                return txf;

            }


        public void RemoveItem(int item)
        {
           
            Link temp = list;
            

            
                while (temp != null)
                {
                    if (item.Equals(temp.Data))
                    
                        temp = temp.Next;

                        Console.WriteLine(temp.Data);
                        temp = temp.Next;
                        
                    
                }

        
    }
}
