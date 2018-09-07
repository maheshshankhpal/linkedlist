using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SinglyLinkedList
    {
        public Node head = null;
        public SinglyLinkedList()
        {

        }

        public void insert(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;

                temp.next = node;
            }
        }

        public void print(Node startNode)
        {
            Node temp = startNode;

            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine("\nList is :");
                while (temp != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.next;
                }
                Console.Write("NULL");
            }
        }

        public Node reverse(Node startNode)
        {
            Node current = startNode; Node temp = null;
            Node prev = null;


            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            return prev;
        }

        public Node getMiddleNode(Node head)
        {
            Node middle = head;

            Node last = head;

            //while (last != null)
            //{
            //    if (last.next != null)
            //    {
            //        last = last.next.next;
            //        middle = middle.next;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            int cnt = 1;
            while(last != null)
            {
                last = last.next;

                if (cnt % 2 == 0)
                    middle = middle.next;

                cnt++;
                    
            }

            if (middle != null)
                middle.next = null;
            return middle;
        }
    }
}
