using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    [Flags]
    internal enum Permission

    {
        None = 0,
        read =1,
        write=2,
        delete=4,
        Execute=8

    }
}
