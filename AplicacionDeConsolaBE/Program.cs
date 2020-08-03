using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AplicacionDeConsolaBE
{
    class Program
    {
        static void Main(string[] args)
        {
            Common var = new Common();
            var.var1 = 23;
            var.var2 = true;
            int inicial = 22;
            System.Console.Write("Hola Mundo");
            
           //Thread.Sleep(2000);
            System.Console.WriteLine("Antes de la ejecución el valor de var1 y var dos es:"+ var.var1, var.var2);

            var.setearEstado(inicial);

            System.Console.WriteLine("Despues de la ejecución el valor de var1 y var dos es:" + var.var1, var.var2);

            // Thread.Sleep(2000);
            System.Console.Read();
        }
    }
}
