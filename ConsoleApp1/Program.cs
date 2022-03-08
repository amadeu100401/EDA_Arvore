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

            root.InsertSon(root,node1);
            root.InsertSon(root,node2);
            node1.InsertSon(node1,node3);
            node1.InsertSon(node1,node4);
            node2.InsertSon(node2,node5);
            node3.InsertSon(node3,node6);
            node4.InsertSon(node4,node7);

            Console.WriteLine("----------------------------------Árvore----------------------------------");
            Console.WriteLine("Retorna a árvore");
            tree.ShowTree(root);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Verifica se o nodo é um nodo folha");
            if (tree.LeafNode(root.LeftNode.LeftNode))
            {
                Console.WriteLine("folha");
            }
            else Console.WriteLine("Não é um nodo folha");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Retorna a altura do nodo");
            Console.WriteLine($"A altura do nodo é: {tree.NodeHeight(root,40)}");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Retorna a profundidade do nodo");
            Console.WriteLine($"A profundidade do nodo é: {tree.NodeDepth(node3)}");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Retorna o grau do nodo");
            Console.WriteLine($"O grau do nodo é: {tree.NodeGrade(node3)}");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Retorna o nível do nodo");
            Console.WriteLine($"O nível do nodo é: {tree.NodeLevel(node3)}");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Retorna a subarvore do nodo");
            tree.SubTree(node2);
            Console.WriteLine("----------------------------------------------------------------------------");

        }
    }

}
