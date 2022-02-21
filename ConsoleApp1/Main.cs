using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BT.Tree;

namespace BT
{
    class Menu
    {
        public static void Main()
        {
            Node root = null;
            root = InsertNode(root, 50);
            InsertNode(root, 40);
            InsertNode(root, 20);
            InsertNode(root, 30);
            InsertNode(root, 80);

            Console.WriteLine(root.RightNode);

        }
    }
}

