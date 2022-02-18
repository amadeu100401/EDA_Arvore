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

        public bool AddNodeTree(int value)
        {
            Node bfr = null, aft = this.NodeRoot;

            while (aft != null)
            {
                if ( value < aft.Value )
                {
                    aft = aft.LeftNode; //Se o novo novo tiver valor menor, fiaca na esquerda
                    
                }
                else if ( value > aft.Value ) {
                    aft = aft.RightNode; // Nodo com valor maior, fica na direita 
                }
                else
                {
                    //Caso exista valor igual
                    Console.WriteLine("Já existe um nodo com este valor");
                    return false;
                }

            }

            Node NNode = new Node(); //instanciândo um novo Nodo 
            NNode.Value = value;

                if (this.NodeRoot == null)
                {
                    this.NodeRoot = NNode; //Se nodo root estiver vazio, recebe o novo nodo instanciado
                    Console.WriteLine("Raiz criada");
                }
                else
                {
                    if (value < bfr.Value) //Caso valor do novo nodo seja menor, nodo lado esquerdo
                    {
                        bfr = bfr.LeftNode;
                    }
                    else //caso nodo maior, nodo lado direito
                    {
                        bfr = bfr.RightNode;
                    }

                }
            return true;
        }
    }
}
