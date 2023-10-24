using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Observer_winapp
{
    internal class WeatherStation
    {
        public float temperature { get; private set; }
        public float humidity { get; private set; } 
        public List<IObserver> posluchaci { get; private set; } = new List<IObserver>();
        Form1 form;

        public WeatherStation(float temperature, float humidity, Form1 form) {
            this.temperature = temperature;
            this.humidity = humidity;
            this.form = form;
        }
        public void NoveMereniTeplota(float temperature) {
            this.temperature = temperature;
        }
        public void NoveMereniVlhkost(float humidity) {
            this.humidity = humidity;
        }
        //pridat
        public void PridejPosluchace(IObserver observer) {
            posluchaci.Add(observer);
        }
        //odebrat
        public void OdeberPosluchace(IObserver observer) {
            posluchaci.Remove(observer);
        }
        //notifikace
        public void Notifikuj() {
            foreach (var observer in posluchaci)
            {
                observer.Update(temperature, humidity, form);
            }
        }
    }
}
