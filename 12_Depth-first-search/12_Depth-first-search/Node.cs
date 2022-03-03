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
        }

        static void DFS(Node n)
        {
            foreach (var item in n.sousedi)
            {
                if (item.id == konec)
                {

                }
            }
        }

        private static List<Node> fronta;
        static int konec;
        public int id;
        public List<Node> sousedi;
    }
}
