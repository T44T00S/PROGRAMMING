using System;
using System.Collections.Generic;

namespace _12_Depth_first_search
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Node> nody = new List<Node>();

            nody.Add(new Node(1));
            nody.Add(new Node(2));
            nody.Add(new Node(3));
            nody.Add(new Node(4));
            nody.Add(new Node(5));
            nody.Add(new Node(6));
            nody.Add(new Node(7));

            nody.Find(m => m.id == 1).sousedi.Add();

            //NajitNode(1).sousedi.Add(NajitNode(1));
            //NajitNode(4).sousedi.Add(NajitNode(2));
            //NajitNode(4).sousedi.Add(NajitNode(3));
            //NajitNode(4).sousedi.Add(NajitNode(4));
            //NajitNode(4).sousedi.Add(NajitNode(5));
            //NajitNode(4).sousedi.Add(NajitNode(6));

            PridatSouseda(1, 4);
            PridatSouseda(4, 2);
            PridatSouseda(4, 6);
            PridatSouseda(2, 1);
            PridatSouseda(2, 3);
            PridatSouseda(2, 3);

            void PridatSouseda(int x, int y)
            {
                nody.Find(m => m.id == x).sousedi.Add(nody.Find(m => m.id == x));
            }
        }
    }
}
