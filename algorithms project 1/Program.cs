using System;
using System.Collections.Generic;
using System.Collections;

namespace algorithms_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> words = new List<string> {"car", "caramel", "hey", "hello","helloeverybody", "CSC204"};
            var list = new Trie();
            list.Add("car");
            list.Add("caramel");
            list.Add("hey");
            list.Add("hello");
            list.Add("helloeverybody");
            list.Add("CSC204");

            Console.WriteLine(list.GetWordsForPrefix("he"));
            Console.WriteLine(list.GetWordsForPrefix("cara"));
            Console.WriteLine(list.Delete("hello"));
            Console.WriteLine(list.Delete("hola"));
            Console.WriteLine(list.GetAllWords());
            list.Add("car");
            Console.ReadLine();

        }

        
    }
}
