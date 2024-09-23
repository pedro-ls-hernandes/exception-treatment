using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizedException
{
    public class CustomException:Exception
    {
        public CustomException() { }

        public CustomException(string message) : base(message) { }

        public CustomException(string message, Exception inner) : base(message, inner) { }

        public override string Message
        {
            get
            {
               return "Essa é a nova mensagem";
            }
        }
    }
}
