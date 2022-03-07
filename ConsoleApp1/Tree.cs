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

        public void SubTree(Node node)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Value);
            SubTree(node.LeftNode);
            SubTree(node.RightNode);
        }
    }
}
