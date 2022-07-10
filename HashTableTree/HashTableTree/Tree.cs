using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableTree
{
    public class Tree:IComparable
    {

        public int NodeData { get; set; }
        public Tree LeftTree { get; set; }
        public Tree RightTree { get; set; }

        public Tree()
        {
        }
        public Tree(int nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = LeftTree;
            this.RightTree = RightTree;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(int item)
        {
            int currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new Tree(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new Tree(item);
                else
                    this.RightTree.Insert(item);
            }
        }

        public void Display(Tree binarytree)
        {
            if (this.LeftTree != null)
            {
                binarytree.leftCount++;
                this.LeftTree.Display(binarytree);

            }

            if (this.RightTree != null)
            {
                binarytree.rightCount++;
                this.RightTree.Display(binarytree);
            }

            Console.WriteLine(this.NodeData.ToString());
        }
        public void GetSize(Tree binarytree)
        {
            //Display(binarytree);
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExists(int element, Tree node)
        {
            if (node == null)
            {
                result = false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

    }
}
