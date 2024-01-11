namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zamestnanec Pepa = new Zamestnanec("Pepa", "Chudák", 68);
            Zamestnanec Jarda = new Zamestnanec("Jaroslav", "Nový", 19);
            Zamestnanec Karel = new Zamestnanec("Karel", "Dlouhý", 15);
            Zamestnanec Milan = new Zamestnanec("Milan", "Krátký", 48);

            Manazer Frantisek = new Manazer("František", "Nedotisha", 21);
            Frantisek.PridatPodrizeneho(Pepa);
            Frantisek.PridatPodrizeneho(Jarda);
            Frantisek.PridatPodrizeneho(Karel);

            SpravaZamestnancu.spravaZamestnancu.PridatZamestnance(Milan);
            SpravaZamestnancu.spravaZamestnancu.PridatZamestnance(Pepa);
            SpravaZamestnancu.spravaZamestnancu.PridatZamestnance(Jarda);
            SpravaZamestnancu.spravaZamestnancu.PridatZamestnance(Karel);
            SpravaZamestnancu.spravaZamestnancu.PridatZamestnance(Frantisek);

            SpravaZamestnancu.spravaZamestnancu.OdeberZamestnance(Pepa);

            SpravaZamestnancu.spravaZamestnancu.VypisZamestnance();

        }
    }
}