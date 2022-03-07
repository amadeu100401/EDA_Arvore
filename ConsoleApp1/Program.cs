using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaGenetica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree tree = new Tree();

            var root = new Node(10,true);
            var node1 = new Node(20, false);
            var node2 = new Node(30,false);
            var node3 = new Node(40,false);
            var node4 = new Node(50,false);
            var node5 = new Node(60, false);
            var node6 = new Node(70, false);
            var node7 = new Node(80, false);

            root.InsertNode(root,node1);
            root.InsertNode(root,node2);
            node1.InsertNode(node1,node3);
            node1.InsertNode(node1,node4);
            node2.InsertNode(node2,node5);
            node3.InsertNode(node3,node6);
            node4.InsertNode(node4,node7);


            //if (tree.LeafNode(root.LeftNode.LeftNode.LeftNode))
            //{
            //    Console.WriteLine("folha");
            //};
            //tree.SubTree(root.LeftNode);
            //Console.WriteLine(tree.NodeHeight(root,10));

            Console.WriteLine(tree.NodeDepth(root.LeftNode));

            Console.WriteLine(root.LeftNode.Father.Value);
        }
    }

}
