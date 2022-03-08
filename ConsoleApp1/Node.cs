using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaGenetica
{
    class Node
    {
        public int Value { get; set; }
        public Node? LeftNode { get; set; }
        public Node? RightNode { get; set; }
        public Node? Father { get; set; }
        public bool Root { get; set; }
        public int Grade { get; set; }
        public int Level { get; set; }

        public Node(int value, bool root)
        {
            Value = value;
            Root = root;
        }

        public void InsertSon(Node father,Node node)
        {

            if (LeftNode == null)
            {
                LeftNode = node;
                LeftNode.Level = father.Level + 1;
                LeftNode.Father = father;
            }
            else
            {
                RightNode = node;
                RightNode.Level = father.Level + 1;
                RightNode.Father = father;
            }

        }

    }
}
