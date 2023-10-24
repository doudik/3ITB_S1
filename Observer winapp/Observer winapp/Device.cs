using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_winapp
{
    internal class Device : IObserver
    {
        public string name { get; private set; }

        public Device(string name) {
            this.name = name;
        }

        public void Update(float temperature, float humidity, Form1 form)
        {
            form.label1.Text += $"\nDevice {name}, teplota {temperature}°C, vlhkost {humidity}%";
            
        }
    }
}
