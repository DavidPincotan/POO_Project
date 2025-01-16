using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appptteme
{
    interface IUser
    {
        void Display()
        {
            Console.WriteLine("Nimic");
        }
        bool PassCheck(string pass)
        {
            return false;
        }
    }
}
