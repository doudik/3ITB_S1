using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeCompany
{
    internal interface ICompany
    {
        void Add(ICompany item);
        void Remove(ICompany item);
        void GetAllInformation();

    }
}
