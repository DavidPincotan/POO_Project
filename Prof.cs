using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appptteme
{
    internal class Prof : IUser
    {


        public void Display()
        {
            Console.WriteLine("connected as professor");
        }
        public bool PassCheck(string pass)
        {
            if (pass == "pass")
                return true;
            else
                return false;
        }
    }
}
