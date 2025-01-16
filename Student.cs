
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appptteme
{
    public class Student : IUser
    {


        public void Display()
        {
            Console.WriteLine("Connected as student");
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
