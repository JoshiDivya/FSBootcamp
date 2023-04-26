// See https://aka.ms/new-console-template for more information

Console.WriteLine("Start Game");
int correct = Random.Shared.Next(1,21);
Console.WriteLine(correct);

for (int i = 0; i < 3; i++)
{
    //ask player to guess
    Console.WriteLine("Please enter your guess");
    string guessNumber = Console.ReadLine();
    int guessNum = int.Parse(guessNumber);

    //is it correct
    if(guessNum == correct){
        Console.WriteLine("Correct, you won!");
        break;
    }
    else if(guessNum< correct){
         Console.WriteLine("Number is larger than guess");
    }
    else{
         Console.WriteLine("Number is smaller than guess");
    }
    
}
Console.WriteLine("End game");


HandleScoreHandler handleScoreHandler = new();
handleScoreHandler.displayHighScoreList();
