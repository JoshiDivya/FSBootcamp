// See https://aka.ms/new-console-template for more information


string path = @"D:\fullstack_bootcamp\.net\FileAccess\numbers.txt"; // relative path

int sum = 0;

IEnumerable<string> lines = File.ReadLines(path);
Console.WriteLine(lines);

foreach (string line in lines)
{
    int num = int.Parse(line);
    sum += num;
}
Console.WriteLine(sum);


// using (StreamReader reader = new StreamReader(path))
// {
//     string line;
//     int sum = 0;
//     while ((line = reader.ReadLine()) != null)
//     {
//       sum = sum+ int.Parse(line);
//     }
//     Console.WriteLine(sum);
// }