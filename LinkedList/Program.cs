using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();

            int[] tempArr = { 10, 20, 30, 40, 50,60 };

            foreach (int temp in tempArr)
            {
                list.insert(temp);
            }

            Node head = list.head;
            list.print(head);


            //head = list.reverse(head);

            list.print(list.getMiddleNode(head));

            Console.ReadKey();
        }
    }
}
