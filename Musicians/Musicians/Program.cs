namespace Musicians
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producent.Instance.generateSong(100);
            Producent.Instance.InfoPisnicka();
        }
    }
}