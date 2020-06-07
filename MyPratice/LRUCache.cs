using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace MyPratice
{
    class LRUCache
    {
        public Dictionary<int,Node> dic;
        public int size;
        public Node head;
        public Node tail;
        public int Itemcount;


        public class Node
        {
            public int key;
            public int value;
            public Node prev;
            public Node next;

            public Node(int k, int v)
            {
                key = k;
                value = v;
                //prev = null;
                //next = null;
            }
        }
        public LRUCache(int s)
        {
            size = s;
            dic = new Dictionary<int, LRUCache.Node>();
            head = new Node(0, 0);
            tail = new Node(0, 0);
            head.next = tail;
            tail.prev = head;
            head.prev = null;
            tail.next = null;
            Itemcount = 0;
        }

        public void deletenode(Node n)
        {
            n.prev.next = n.next;
            n.next.prev = n.prev;
        }

        public void addnode(Node n)
        {
            n.next = head.next;
            n.next.prev = n;
            n.prev = head;
            head.next = n;
        }

        public int get(int k)
        {
            if (dic.ContainsKey(k))
            {
                Node n = dic[k];
                int result = n.value;
                deletenode(n);
                addnode(n);
                Console.WriteLine("Got the value : " + result + " for the key: " + k);
                return result;
            }
           Console.WriteLine("Did not get any value for the key: " + k);
            return -1;
        }



        public void set(int k, int v)
        {
            Console.WriteLine("Going to set the (key, " + " value) : (" + k + ", " + v + ")");
            if (dic.ContainsKey(k))
            {
                Node n = dic[k];
                n.value = v;
                deletenode(n);
                addnode(n);
            }
            else
            {
                Node n = new Node(k, v);
                dic.Add(k, n);
                if (Itemcount < size)
                {
                  addnode(n);
                  Itemcount++;
                }
                else
                {
                    dic.Remove(tail.prev.key);
                    deletenode(tail.prev);
                    addnode(n);
                }
            }

            
        }
    }
}
