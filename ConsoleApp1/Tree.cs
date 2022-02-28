using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaGenetica
{
    class Tree
    {
        public Node newNode(int value)
        {
            Node node = new Node();
            node.Value = value;
            node.LeftNode = null;
            node.RightNode = null;
            return node;
        }

        public Node InsertNode(Node root, int value)
        {
            if (root == null)
            {
                root = newNode(value);
                root.Height = 0;
            }
            else
            {
                if (root.LeftNode == null)
                {
                    root.LeftNode = newNode(value);
                    root.LeftNode.Father = root;
                    root.LeftNode.Height = root.Height + 1;
                    root.Grade += 1;
                }
                else if (root.RightNode == null)
                {
                    root.RightNode = newNode(value);
                    root.LeftNode.Father = root;
                    root.Grade += 1;
                }
                else
                {
                    InsertNode(root.LeftNode, value);
                }
            }
            return root;
        }

        public bool LeafNode(Node node)
        {
            if (node.LeftNode is null && node.RightNode is null)
            {
                Console.WriteLine("Passou por aqui");
                return true;
            }
            return false;
        }
    }
}
