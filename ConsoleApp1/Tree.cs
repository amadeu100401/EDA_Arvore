using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    class Tree
    {
        public Node NodeRoot { get; set; }  

        public bool AddNodeTree(int value, int id)
        {
            Node parent = null, current = this.NodeRoot;

            while (current != null)
            {
                parent = current; 
                if ( value < current.Value )
                {
                    current = current.LeftNode; //Se o novo novo tiver valor menor, fiaca na esquerda
                    current.Id = id;
                    
                }
                else if ( value > current.Value ) {
                    current = current.RightNode; // Nodo com valor maior, fica na direita 
                    current.Id = id;
                }
                else
                {
                    //Caso exista valor igual
                    Console.WriteLine("Já existe um nodo com este valor");
                    return false;
                }

            }

            Node NNode = new Node(); //instanciândo um novo nodo 
            NNode.Value = value;
            NNode.Id = id;

                if (this.NodeRoot == null)
                {
                    this.NodeRoot = NNode; //Se nodo root estiver vazio, recebe o novo nodo instanciado
                    Console.WriteLine("Raiz criada");
                }
                else
                {
                    if (value < parent.Value) //Caso valor do novo nodo seja menor, nodo lado esquerdo
                    {
                        parent = parent.LeftNode;
                    }
                    else //caso nodo maior, nodo lado direito
                    {
                        parent = parent.RightNode;
                    }

                }
            return true;
        }

        public Node ReturnRoot()
        {
            Console.WriteLine(NodeRoot.Value);
            return this.NodeRoot;
        }
    }
}
