using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDeConsolaBE
{
    public class Common
    {
        public int var1;
        public bool var2;

        public void setearEstado(int p)
        {
            if (p >= 10)
                var1 = 2;
            else
                var2 = false;
        }

    }

}
