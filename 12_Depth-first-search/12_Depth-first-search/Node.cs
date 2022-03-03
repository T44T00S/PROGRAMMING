using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Depth_first_search
{
    class Node
    {
        public Node(int id)
        {
            this.id = id;
            this.sousedi = new List<Node>();
        }
        public static void Start(Node start, Node finito)
        {
            konec = finito;
            DFS(start);

            foreach (var item in fronta)
            {
                Console.Write(item.id + " ");
            }
        }
        static void DFS(Node n)
        {
            foreach (var item in n.sousedi)
            {
                if (item == konec)
                {
                    break;
                }
                else
                {
                    if (!fronta.Contains(item))
                    {
                        fronta.Add(n);

                        DFS(item);
                    }
                }
            }
        }

        private static List<Node> fronta = new List<Node>();
        static Node konec;
        public int id;
        public List<Node> sousedi;
    }
}
