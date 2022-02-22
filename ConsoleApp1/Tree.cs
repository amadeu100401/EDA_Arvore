using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BT.Tree;

namespace BT
{
    class Tree
    {
        public class Node
        {
            public int Value { get; set; }
            public Node? LeftNode { get; set; }
            public Node? RightNode { get; set; }
        }

        static Node newNode(int value)
        {
            Node tn = new Node();
            tn.Value = value;
            tn.LeftNode = null;
            tn.RightNode = null;

            return tn;
        }

        public static Node InsertNode (Node root,int value)
        {
            if (root == null)
            {
                root = newNode(value);
                Console.WriteLine("Raiz criada");
            }
            else if (value < root.Value)
            {
                if (root.LeftNode == null)
                {
                    root.LeftNode = newNode(value);
                }

                else
                {
                    InsertNode(root,value);
                }
            }
            else if (value > root.Value)
            {
                if (root.RightNode == null) 
                {
                    root.RightNode = newNode(value);
                }

                else
                {
                    InsertNode(root, value);
                }
            }

            return root;
        }

        public static void Main(String[] args)
        {
            Node root = null;
            root = InsertNode(root,10);
            InsertNode(root,20);
        }

    }
}
