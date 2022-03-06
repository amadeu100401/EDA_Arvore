using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

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
            node.Level = 0;
            return node;
        }

        public Node InsertNode(Node root, int value)
        {
            if (root == null)
            {
                root = newNode(value);
            }
            else
            {
                if (root.LeftNode == null)
                {
                    root.LeftNode = newNode(value);
                    root.LeftNode.Father = root;
                    root.LeftNode.Level = root.Level + 1;
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
                return true;
            }
            return false;
        }

        public int NodeHeight(Node root,int value)
        {
            if (root is null)
            {
                return -1;
            }

            int LeftHeight = NodeHeight(root.LeftNode, value);
            int RightHeight = NodeHeight(root.RightNode,value);
            int aux = Math.Max(LeftHeight, RightHeight) + 1;

            if (root.Value == value)
            {
                int Height = aux;
                return Height;
            }

            return aux;
        }

        public int NodeDepth(Node node)
        {
            var depth = 0;
            if (node.Father is not null)
            {
                NodeDepth(node.Father);
                depth += 1;
                return depth;
            }
            return depth;
        }

        public bool Subarvore(Node node, int valorNode)
        {

            if (node == null)
                return false;

            if (node.Value == valorNode)
                return true;

            if (Subarvore(node.LeftNode, valorNode) || Subarvore(node.RightNode, valorNode))
            {
                Console.WriteLine("Esse ná faz parte da Subárvore " + node.Value + " ");
                return true;
            }

            return false;
        }
    }
}
