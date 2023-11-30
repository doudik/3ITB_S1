namespace SingletonDBManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectionManager.manager.Connect();
            //ConnectionManager.manager.PridatZaznam(prijmeni: "Karel", jmeno: "Novak");
            ConnectionManager.manager.OdeberZaznam(prijmeni : "l");
            ConnectionManager.manager.Vypis();
            ConnectionManager.manager.Disconect();
        }
    }
}