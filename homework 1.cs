string name;
int age;
string hobby;
int favoriteNumber;

Console.Write("Enter your name: ");
name = Console.ReadLine();

Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your favorite hobby? ");
hobby = Console.ReadLine();

Console.Write("What is your favorite number? ");
favoriteNumber = Convert.ToInt32(Console.ReadLine());

int numberSquared = favoriteNumber * favoriteNumber;


Console.Clear();

Console.WriteLine("==== Summary ====");
Console.WriteLine($"Hello {name}!");
Console.WriteLine($"You are {age} years old.");
Console.WriteLine($"Your favorite hobby is {hobby}.");
Console.WriteLine($"Your favorite number is {favoriteNumber} and its square is {numberSquared}.");
Console.WriteLine("Thanks for answering the questions!");