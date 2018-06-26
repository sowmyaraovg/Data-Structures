using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Library
{
    public class Linked_Lists
    {
        private MYLLNode head;
        private int count;
       

        public Linked_Lists()
        {
            head = null;
            count = 0;
        }
        public Linked_Lists(object data)
        {
            MYLLNode node = new MYLLNode(data);
            head = node;
            count = 1;
        }
        public Linked_Lists(MYLLNode node)
        {
            head = node;
            count = 1;
        }
        //Insert method -AddFirst,Addlast,Addbefore,AddAfter
        public void AddFirst(object data)
        {
            MYLLNode newnode = new MYLLNode(data);
           
            if (head == null)
            {
                head = newnode;
                count++;
                return;
            }
            newnode.next = head;
            head = newnode;
            count++;
        }

        public void AddLast(object data)
        {
            MYLLNode newnode = new MYLLNode(data);
            
            if(head==null)
            {
                head = newnode;
                count = 1;
                return;
            }
            MYLLNode temp = head;
            while (temp.Next != null)
            { temp = temp.Next; }
            newnode.next = temp.Next;
            count++;

            
        }
        public void AddBefore(MYLLNode beforenode, object data)
        {
            MYLLNode newNode = new MYLLNode(data);
            AddBefore(beforenode, newNode);

        }

        public void AddBefore(MYLLNode beforenode,MYLLNode newnode)
        {
            if(beforenode == null || newnode == null)
                throw new ArgumentNullException();
            if (head == null)
                throw new InvalidOperationException();
            if(head.Next==null|| beforenode !=head)
            {
                //has one node and it is not the before node
                throw new InvalidOperationException();
            }
            if(head.Next==null)
            {
                AddFirst(newnode);
            }
            MYLLNode temp = head;
            while(temp.Next!=beforenode)
            {
                if (temp == null)
                {
                    throw new InvalidOperationException();
                }
                temp = temp.Next;
            }
            newnode.next = beforenode;
            temp.next = newnode;

        }
        public void AddAfter(MYLLNode node, object data)
        {
            MYLLNode newNode = new MYLLNode(data);
            AddAfter(node, newNode);
            
        }

        public void AddAfter(MYLLNode node, MYLLNode newnode)
        {
            if (node == null || newnode == null)
                throw new ArgumentNullException();

            newnode.next = node.Next;
            node.next = newnode;
            count++;
            
        }
        public bool Remove(object data)
       { 
        // return true if found and removed



       }
        public void Remove(MYLLNode node)
        {
            //throw exception 
            if (node == null)
                throw new ArgumentNullException();
            if (head == null)
                throw new InvalidOperationException();
            MYLLNode temp = head;
            MYLLNode prev;
            while (temp != node)
            {
                prev = temp;
                temp = temp.Next;
                if (temp == null)
                    throw new InvalidOperationException();
            }
            if(head.Next==null)
            {
                head = null;
            }
            else if(node.next==null)
            {
                node = null;
            }

            else
            {
                prev.next = temp.Next;
                node.Next = null;
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException();
            MYLLNode temp = head;
            head = head.Next;
            temp.Next = null;
        }
        public void RemoveLast()
        {
            if(head == null)
                throw new InvalidOperationException();
            MYLLNode last = head;
            while(last.next!=null)
            {
                last = last.Next;
            }
            last= null;
            count--;



        }
    public object[] ToArray()
        {
            object[] array = new object[count];
            MYLLNode temp = head;
            int index = 0;
            while(temp!=null)
            {
                array[index] = temp.data;
                temp = temp.Next;
                index++;
            }
            return array;
        }

        public MYLLNode Find(object data)
        {
           
            MYLLNode temp = head;
            while(temp!=null)
            {
                if (temp.data==data)
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;

        }

       
    }

