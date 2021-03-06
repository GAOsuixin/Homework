﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4project1
{

    class Program
    {
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data  { get; set; }
            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }
        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;
            public GenericList()
            {
                tail = head = null;
            }
            public Node<T> Head
            {
                get => head;
            }
            public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if(tail==null)
                {
                    head = tail = n;
                }else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
            public void Foreach(Action<T> act)
            {
                Node<T> temp;
                temp = head;
                if (temp == null)
                    return;
                act(temp.Data);
                while(temp!=tail)
                {
                    temp = temp.Next;
                    act(temp.Data);
                }
            }
        }
        static void Main(string[] args)
        {
            int sum = 0, max = 0, min = int.MaxValue;
            GenericList<int> intlist = new GenericList<int>();
            for(int x=0;x<10;x++)
            {
                intlist.Add(x);
            }
            Console.WriteLine("打印链表元素：");
            intlist.Foreach(x => Console.Write(x + " "));
            Console.WriteLine();
            intlist.Foreach(x => sum += x);
            Console.WriteLine("总和为：" + sum);
            intlist.Foreach(x => max = x > max ? x : max);
            intlist.Foreach(x => min = x < min ? x : min);
            System.Console.ReadKey();
        }
    }
}
