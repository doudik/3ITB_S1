using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_winapp
{
    internal interface IObserver
    { 
        void Update(float temperature, float humidity, Form1 form);
    }
}
