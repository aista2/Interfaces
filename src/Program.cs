using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<InterfaceMilk> list = new List<InterfaceMilk>();

            list.Add(new Tea());
            list.Add(new Coffee());

            foreach (var item in list)
            {
                item.AddMilk();
                item.AddSugar();
            }
        }
    }
}
