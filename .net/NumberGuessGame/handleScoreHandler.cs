class HandleScoreHandler
{

    public void displayHighScoreList()
    {
        string path = @"D:\fullstack_bootcamp\.net\NumberGuessGame\results.csv";

        IEnumerable<string> lines = File.ReadLines(path);
         int count = 1;
        foreach (string line in lines)
        {
           
            string[] rank = line.Split(";");
            int numberOfGuess = int.Parse(rank[0]);
            string name = rank[1];
            Console.WriteLine($"Position {count}: {name},number of guesses {numberOfGuess}");
            count++;
        }
    }
}