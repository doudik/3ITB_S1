using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFirmManager
{
    public interface IAcessible
    {
        public void Add(IAcessible accessible);
        public void Remove(IAcessible accessible);
        public void GetAllInformation();
    }
}
