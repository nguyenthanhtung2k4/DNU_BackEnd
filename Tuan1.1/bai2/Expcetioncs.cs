using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Expcetioncs: Exception
    {
        public Expcetioncs(String message):base(message)
        { 
        }

    }
}
