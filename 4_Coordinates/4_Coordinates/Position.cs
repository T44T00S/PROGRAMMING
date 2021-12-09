using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Coordinates
{
    public struct Pos
    {
        public Pos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public char getChar(int x, int y)
        {
            return this.x == 1 && this.y == 1 ? 'X' : 'O';

            //if (this.x == 1 && this.y == 1)
            //{
            //    return 'X';
            //}
            //else if (this.x != 1 && this.y != 1)
            //{
            //    return 'O';
            //}
            //else
            //{
            //    return 'F';
            //}
        }

        public int x { get; set; }
        public int y { get; set; }
    }
}
