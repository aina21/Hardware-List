using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fatemeh_HardWare.BL
{
    class HardWareExeption:Exception
    {
        public HardWareExeption(string messageValue):base(messageValue)
        {
        }
    }
}
