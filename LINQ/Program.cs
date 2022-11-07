using System.Transactions;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameList = new List<string>
            { "StarWars", "Paper Boy", "Battlefield Four", "Super Mario Three", "Dig Dug"};

            IEnumerable<string> length = videoGameList.OrderBy(x => x.Length).ToList();

            foreach (string videoGame in length)
            {
                Console.WriteLine(videoGame);
            }
        }
    }
}
