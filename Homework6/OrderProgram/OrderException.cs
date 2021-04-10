using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram
{
    public class OrderException:Exception
    {
        private int code;
        public OrderException(String message,int code):base(message)
        {
            this.code = code;
        }
        public int Code { get => code; }
    }
}
