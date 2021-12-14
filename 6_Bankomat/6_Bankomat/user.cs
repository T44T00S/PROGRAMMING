using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Bankomat
{
    class user
    {
        public user(string jmeno)
        {
            // Random rd = new Random();
            //MD5 md5 = MD5.Create();

            this.jmeno = jmeno;
            //this.pin = md5.ComputeHash(Encoding.ASCII.GetBytes(rd.Next(999, 1000).ToString()));
            // this.pin = rd.Next(999, 1000);
            this.pin = 1111;
            //this.pin = 0000;
            this.zustatek = 10000;
        }

        public string jmeno { get; set; }
        public int pin { get; set; }
        //public byte[] pin;
        public int zustatek { get; set; }
    }
}
