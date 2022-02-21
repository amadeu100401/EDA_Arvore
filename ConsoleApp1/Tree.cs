using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    class Tree
    {
        public class Node
        {
            public int Value { get; set; }
            public Node? LeftNode { get; set; }
            public Node? RightNode { get; set; }
        };

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
            Node newnode = newNode(value);
            Node rn = root;

            Node aux = null;

            while (rn != null)
            {
                rn = aux;
                if (value < rn.Value)
                {
                    rn = rn.LeftNode;
                }
                else
                    rn = rn.RightNode;
            }

            if (aux != null)
            {
                aux = newnode;
                Console.WriteLine("Raiz criada");
            }
            else if (value < aux.Value)
            {
                aux.LeftNode = newnode;
            }
            else
            {
                aux.RightNode = newnode;
            }

            return aux;

        }
    }
}
