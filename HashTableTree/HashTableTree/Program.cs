using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HashTableTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree(3);
            tree.Insert(56);
            tree.Insert(70);
            tree.Insert(30);
        }
    }
}
