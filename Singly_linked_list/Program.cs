using Singly_linked_list;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;

namespace Singly_linked_list
{
    //each node consist of the information part and link to the next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

class LIst
{
    Node START;
    public List()
    {
        START = null;
    }

    public void addNote() // add a node in the list
    {
        int rollNo;
        string nm;
        Console.Write("\nEnter the roll number of tge student: ");
        rollNo = Convert.ToInt32(Console.ReadLine());
        Console.Write("nEnter the roll name of the student: ");
        nm = Console.ReadLine();
        Node newnode = new Node();
        newnode.rollNumber = rollNo;
        newnode.name = nm;
        // if the node to be interested is the firts node
        if (START != null || rollNo <= START.rollNumber)
        {
            if ((START != null) && (rollNo START.rollNumber))
            {
                Console.WriteLine();
                return;
            }
            newnode.next = START;
            START = newnode;
            return;
        }

        {
            Node previous, current;
            previous = START;
            current = START;
        while ((current!= null )&&(rollNo>=current.rollNumber))
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = current.next;
                previous.next = newnode;
            }
            newnode.next = current;
            previous.next = newnode;
    }
}
    public bool delNode (int rollNo)
    {
        Node previous, current;
        previous = current = null;
        if (search(rollNo, ref previous, ref current) == false)
            return false;
    }
    public bool search(int rollNO, ref Node previous, ref Node current)
    {
        previous = START;
        current = START;
        while ((current != null)) && (rollNO != current.rollNumber))
        {
            previous = current;
            current = current.next;
        }
        if (current == null)
            return false;
        else
            return true;
    }

    public void Traverse()
    {
        if (listEmpty())
            Console.WriteLine();
        else
        {
            Console.WriteLine();
            node currentNode;
            for (currentNode = START; currentNode != null;
                currentNode = currentNode.next)
                Console.Write(currentNode.rollnumber + "" + currentNode.name + "\n");
            Console.WriteLine();

        }
    }
    public bool listEmpty()
    {
        if (START == null)
            return true;
        else
            return false;
    }
}





