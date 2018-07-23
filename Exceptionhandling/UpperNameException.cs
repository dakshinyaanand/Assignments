using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhandling
{
    class UpperNameException:Exception
    {
        string msg;
        public UpperNameException()
        {
            msg = "Name has to be in Upper Case";
        }
        public UpperNameException(string msg)
        {
            this.msg = msg;
        }
        public override string Message
        {
            get
            {
                return msg;
            }
        }

        
    }
}
