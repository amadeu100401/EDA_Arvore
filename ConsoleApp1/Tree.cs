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

        public int NodeHeight(Node node)
        {
            var height = 0;

            if (LeafNode(node) == false)
            {
                if (node.LeftNode == null || node.LeftNode != null && node.RightNode != null)
                {
                    NodeHeight(node.RightNode);
                    height += 1;
                }
                else if (node.RightNode == null)
                {
                    NodeHeight(node.LeftNode);
                    height += 1;
                }
            }
            else if( height != 0)
            {
                height += 1;
            }
            return height;
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
    }
}
