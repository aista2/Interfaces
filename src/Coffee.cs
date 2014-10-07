using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5
{
   public class Coffee:InterfaceMilk
    {
       public void AddMilk()
       {
           Console.WriteLine("Milk has been added");
       }
       public void AddSugar()
       {
           Console.WriteLine("Sugar has been added");
       }
    }
}
