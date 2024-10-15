namespace uke_1_OOP;

class Program
{
    // Methods that implements the interface iCalculator
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.x = 25;
        calculator.y = 5;
        Console.WriteLine(calculator.Power(calculator.y, calculator.x));
        Console.WriteLine(calculator.Add(5, 50)); // 55
        //Console.WriteLine(calculator.Divide(5, 0)); // should fail

        // List datastructures
        List<string> videoGames = new List<string>();

        videoGames.Add("Skyrim");
        videoGames.Add("Helldivers");
        videoGames.Add("Limbo");
        videoGames.Add("League of Legends");
        videoGames.Add("Morrowind");

        Console.WriteLine("A list of videogames");

        foreach (string games in videoGames)
        {
            Console.WriteLine(games);
        }

        List<string> handleListe = new List<string> () {
            "Melk",
            "Egg",
            "Kylling",
            "Brød",
            "Biff",
        };

        Console.WriteLine("My Shopping List:");
        foreach (string elements in handleListe)
        {
            Console.WriteLine(elements);
        }

        Dictionary<int, string[]> myHashMap = new Dictionary<int, string[]>();
            myHashMap.Add(1, ["Hello", "it", "is", "me"]);
            myHashMap.Add(2, ["DID", "YOU", "MISS", "ME"]);
            foreach (var keyValuePairs in myHashMap)
            {
                Console.WriteLine(keyValuePairs.Key);
                foreach (var values in keyValuePairs.Value){
                    Console.WriteLine(values);
                }
            }

        


    }
}
