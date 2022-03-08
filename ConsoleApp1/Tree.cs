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
        public void ShowTree (Node node)
        {
            if (node == null)
            {
                return;
            }

            if (node.Root)
            {
                Console.WriteLine($"Nodo raiz da árvore: {node.Value}");
                ShowTree(node.LeftNode);
                ShowTree(node.RightNode);
            }
            else
            {
                Console.Write($"Nodo caule: {node.Value} ");
                Console.Write($"Nodo pai: {node.Father.Value} ");
                if (node.Father.LeftNode.Value == node.Value)
                {
                    Console.Write("Posição: Filho esquerdo " );
                }
                else
                {
                    Console.Write("Posição: Filho direito " );
                }
                Console.WriteLine($"Nível do nodo: {node.Level} ");
                ShowTree(node.LeftNode);
                ShowTree(node.RightNode);
            }
        }

        public bool LeafNode(Node node)
        {
            if (node.LeftNode is null && node.RightNode is null)
            {
                return true;
            }
            return false;
        }

        public int NodeLevel(Node node)
        {
            if (node == null) Console.WriteLine("Nodo inexistente.");
            return node.Level;
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

        public int NodeGrade(Node node)
        {
            if (node == null) return -1;

            if (node.LeftNode == null || node.RightNode == null)
            {
                node.Grade = 1;
            }
            else if (node.LeftNode != null && node.RightNode != null)
            {
                node.Grade = 2;
            }
            return node.Grade;
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
