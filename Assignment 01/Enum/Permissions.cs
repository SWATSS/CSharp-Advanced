using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01.Enum
{
    [Flags]
    internal enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
}
