using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BT.Tree;

namespace BT
{
    public class Tree
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
                    Console.WriteLine("Esquerdo criado");
                }

                else
                {
                    InsertNode(root.LeftNode,value);
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
                    InsertNode(root.RightNode, value);
                }
            }   

            return root;
        }

        private static int Verify (Node root, int value)
        {
            var GradeN = 0;

            if (root.Value == value)
            {
                if (root.LeftNode == null && root.RightNode == null)
                {
                    return GradeN;
                }
                else if (root.LeftNode == null && root.RightNode != null || root.LeftNode != null && root.RightNode == null )
                {
                    GradeN = 1;
                    return GradeN;
                }
                else
                {
                    GradeN = 2;
                    return GradeN;
                }
            }
            else
            {
                if (root.LeftNode != null)
                {
                    if (value > root.LeftNode.Value)
                    {
                        Verify(root.RightNode, value);
                    }
                    else
                    {
                        Verify(root.LeftNode, value);
                    }

                }
                else if (root.RightNode != null)
                {
                    if (value < root.RightNode.Value)
                    {
                      Verify(root.LeftNode, value);
                    }
                    else
                    {
                        Verify(root.RightNode, value);
                    }
                }
            }
            return GradeN;
        }

        public string LeafNode (Node root, int value)
        {
            var gradeNode = Verify(root, value);
            if (gradeNode == 0)
            {
                return "O nó é folha";
            }
            return "O nó não é folha";
        }
        
        public int GradeNode(Node root, int value )
        {
            if (root is null)
            {
                Console.WriteLine("A árvore está vazia");
            }
            else
            {
                var obj = Verify(root, value);
                Console.WriteLine(obj); 
                return obj;
            }
            return 98687;
        }

        private void ShowTree(Node root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                ShowTree(root.LeftNode);
                Console.WriteLine(root.Value + " ");
                ShowTree(root.RightNode);
            }

        }

        public void Display(Node root)
        {
            ShowTree(root);
        }

        public static void Main(String[] args)
        {
            Tree bst = new Tree();
            Node root = null;
            root = InsertNode(root,10);
            InsertNode(root,20);
            InsertNode(root, 5);
            InsertNode(root, 40);
            InsertNode(root, 30);

            bst.GradeNode(root, 10);
            Console.WriteLine(bst.LeafNode(root,10));
            bst.Display(root);
        }

    }
}
