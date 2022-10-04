using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    interface INavire
    {
         TypeNavire Type { get; }
        bool Coule { get; }

    }
}
