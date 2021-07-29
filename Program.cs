﻿using System;
using System.Collections;

namespace Collections
{
    class CollectionDemo
    {
        static void ArrayEg()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Capacity{0}", al.Capacity);
            al.Add("Devi");
            al.Add("100.0f");
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add('a');
            Console.WriteLine("Capacity{0}", al.Capacity);
            foreach (var arrayList in al)
            {
                Console.WriteLine(arrayList);
            }
            Console.WriteLine("Capacity{0}", al.Capacity);
        }
        static void Hashtablefg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("j", "JAVA");
            ht.Add("o", "Operating System");
            ht.Add("u", "Unix");
            ht.Add('n', "Networks");
            ht.Add("U", "Unix");

            Console.WriteLine(ht.Contains("0"));
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }

        }
        static void SortedListEg()
        {
            SortedList ht1 = new SortedList();
            ht1.Add("j", "JAVA");
            ht1.Add("o", "Operating System");
            ht1.Add("u", "Unix");
            ht1.Add('n', "Networks");
            ht1.Add("U", "Unix");

            Console.WriteLine(ht1.Contains("0"));
            foreach (DictionaryEntry d in ht1)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }

        }
        static void Main()
        {
            ArrayEg();
            Console.WriteLine("HashTable");
            Hashtablefg();
            Console.WriteLine("SortedList");
            SortedListEg();
        }
     }
        
 }

