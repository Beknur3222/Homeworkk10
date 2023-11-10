using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonAssembly
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

        void Print();
        string ToString();
    }
}
