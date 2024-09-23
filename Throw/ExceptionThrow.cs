using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    public class A
    {
        public static void ProcessarA()
        {
            B.ProcessarB();
        }
    }
    public class B
    {
        public static void ProcessarB()
        {
            C.ProcessarC();
        }
    }
    public class C
    {
        public static void ProcessarC()
        {
            throw new NotImplementedException("Método não implementado");
        }
    }
}
