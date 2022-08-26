// See https://aka.ms/new-console-template for more information

//Using string array to fill names, can emit "new string[]" on line 5

string[] names = new string[] { "Karl", "Caleb", "Ian", "Jack", "Sam", "James", "Billy", "Josh" };
Console.WriteLine($"{names[0]}, {names[1]}, {names[2]}, {names[3]}, {names[4]}, {names[5]}, {names[6]}, {names[7]}");


//Several options for using arrays that do the same thing

int[] scores2 = new int[] { 95, 97, 100, 93, 100 };
Console.WriteLine($"{scores2[0],5}, {scores2[1],5}, {scores2[2],5}, {scores2[3],5}, {scores2[4],5} ");


int[] scores = new int[5];
scores[0] = 100;
scores[1] = 95;
scores[2] = 97;
scores[3] = 100;
scores[4] = 100;

Console.WriteLine($"{scores[0],5}, {scores[1],5}, {scores[2],5}, {scores[3],5}, {scores[4],5}");

//Array example using bowling scores and adding them together to display

int[] games = { 145, 264, 244 };
int score = games[0] + games[1] + games[2];
Console.WriteLine(score);

//Console input from user and displaying it back to them

Console.Write("Enter a string: "); //"Write" insteand of WriteLine will keep input on same line
string? response = Console.ReadLine(); //ReadLine only returns a string
Console.WriteLine($"You typed {response}");

//Changing string to an int for user input
Console.Write("Guess a number between 1 to 10: ");
string answer = Console.ReadLine();
int MyNumber = Convert.ToInt32(answer);
Console.WriteLine($"The number is {MyNumber}");

//Bowling score enhancement, allow user to enter game scores and calculates the total score

Console.Write("What is your game 1 score:");
string? game1 = Console.ReadLine();
int score1 = Convert.ToInt32(game1);
Console.WriteLine($"Your first game score is: {score1}");

Console.Write("What is your game 2 score:");
string? game2 = Console.ReadLine();
int score2 = Convert.ToInt32(game2);
Console.WriteLine($"Your second game score is: {score2}");

Console.Write("What is your game 3 score:");
string? game3 = Console.ReadLine();
int score3 = Convert.ToInt32(game3);
Console.WriteLine($"Your third game score is: {score3}");

//int[] AllGames = { 145, 264, 244 };, IGNORE
int TotalScore = score1 + score2 + score3;
Console.WriteLine($"Your total score is {TotalScore}");

//Greg example

int[] scores = new int[3];

Console.Write("Enter 1st score:");
string answer = Console.ReadLine();
scores[0] = Convert.ToInt32(answer);

Console.Write("Enter 1st score:");
string answer = Console.ReadLine();
scores[1] = Convert.ToInt32(answer);

Console.Write("Enter 1st score:");
string answer = Console.ReadLine();
scores[2] = Convert.ToInt32(answer);

int total = scores[0] + scores[1] + scores[2]
Console.WriteLine($"The total of the scores {scores[0]}, {scores[1]}, and {scores[2]} is {total}");