namespace SingletonIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knihovna knihovna = new Knihovna("Městská knihovna");
            SpravceKnihovny.VratSpravce().PridejKnihuDoSbirky(new Kniha("Harry Potter", "J.K.Rowling"));
            SpravceKnihovny.VratSpravce().VypisVsechnyKnihy();
        
        }
    }
}