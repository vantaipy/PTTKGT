using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoiTien
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Import> list = new List<Import>();
            User user = new User();
            user.tien(5880);
            Console.WriteLine("To"+" "+user.tien()+"K");
            list = user.Test(user.tien());
            foreach (Import o in list)
            {
                Console.WriteLine("Rut duoc" + " " + o.sl() + " " + "to" + " " + o.mg() + "K");
            }
            Console.ReadLine();
        }
    }
}
