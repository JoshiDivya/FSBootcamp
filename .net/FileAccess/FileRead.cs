class FileAccess
{
    public string url = "numbers.txt";

    public void readFile()
    {
       using (StreamReader reader = new StreamReader(url)){
        string line;
        while((line = reader.ReadLine())!= null){
            Console.WriteLine(line);
        }
       }
    }
}

