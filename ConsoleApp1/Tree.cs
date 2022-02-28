using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
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
            }
            else
            {
                if (root.LeftNode == null)
                {
                    root.LeftNode = newNode(value);
                    root.Grade += 1;
                }
                else if (root.RightNode == null)
                {
                    root.RightNode = newNode(value);
                    root.Grade += 1;
                }
                else
                {
                    InsertNode(root.LeftNode, value);
                }
            }
            return root;
        }
    }
}
