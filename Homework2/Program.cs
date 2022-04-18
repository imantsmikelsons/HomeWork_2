// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, my name is Imants!");
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine();

string greeting = ("Sveiks");
Console.WriteLine(greeting);

Console.WriteLine();
Console.WriteLine("=================================1");
Console.WriteLine();


Console.WriteLine("Kā tevi sauc");


string userName = ("Imants");
string userGreeting = ("Sveiks" + userName + "!");

Console.WriteLine(userName);
Console.WriteLine(userGreeting);


Console.WriteLine();
Console.WriteLine("=================================2");
Console.WriteLine();


Console.WriteLine("Lūdzu ieraksti savu vecumu ?");

string userenumberText = (Console.ReadLine());

int userenumber = int.Parse(userenumberText);
int result = (userenumber + 1);


Console.WriteLine(userenumberText);
Console.WriteLine(userenumber);
Console.WriteLine(result);
Console.WriteLine("Tev pēc gada būs" + result);


Console.WriteLine();
Console.WriteLine("=================================3");
Console.WriteLine();

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");

int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi otro skaitli");

int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi trešo skaitli");

int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi ceturto skaitli");

int fourthNumber = int.Parse(Console.ReadLine());




int firstMaxNumber = Math.Max(firstNumber, secondNumber);
int secondMaxNumber = Math.Max(thirdNumber, fourthNumber);
int maxNumber = Math.Max(firstMaxNumber, secondMaxNumber);



Console.WriteLine(firstMaxNumber);
Console.WriteLine(secondMaxNumber);
Console.WriteLine(maxNumber);



Console.WriteLine();
Console.WriteLine("==================================4");
Console.WriteLine();


Console.WriteLine("Lūdzu, ievadi pirmo skaitli");

int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi otro skaitli");

int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi trešo skaitli");

int thirdNumber = int.Parse(Console.ReadLine());

int firstMinNumber = Math.Min(firstNumber, secondNumber);
int secondMinNumber = Math.Min(firstMinNumber, thirdNumber);
int minNumber = Math.Min(firstMinNumber, secondMinNumber);



Console.WriteLine(firstMinNumber);
Console.WriteLine(secondMinNumber);
Console.WriteLine(minNumber);


Console.WriteLine();
Console.WriteLine("==================================5");
Console.WriteLine();


Console.WriteLine("Lūdzu, ievadi pirmo skaitli");

int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi otro skaitli");

int secondNumber = int.Parse(Console.ReadLine());

int result = firstNumber % secondNumber;



Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
Console.WriteLine(result);


Console.WriteLine();
Console.WriteLine("==================================6");
Console.WriteLine();



Console.WriteLine("Lūdzu, ievadi skaitli");

int number = int.Parse(Console.ReadLine());

bool isEven = number % 2 == 0;

Console.WriteLine(number);
Console.WriteLine("Skaitlis ir pāra skaitlis: " + isEven);


Console.WriteLine();
Console.WriteLine("==================================7");
Console.WriteLine();


Console.WriteLine("Lūdzu, ievadi pirmo skaitli");

int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi otro skaitli");

int secondNumber = int.Parse(Console.ReadLine());

int area = firstNumber * secondNumber;

Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
Console.WriteLine(area);



Console.WriteLine();
Console.WriteLine("==================================8");
Console.WriteLine();


Console.WriteLine("Lūdzu, ievadi trijstūra malas garumu");

int number = int.Parse(Console.ReadLine());

int area = number * number / 2;

Console.WriteLine(number);
Console.WriteLine(area);



Console.WriteLine();
Console.WriteLine("==================================9");
Console.WriteLine();


Console.WriteLine("Lūdzu ievadi savu vārdu");

string userName1 = (Console.ReadLine());

Console.WriteLine("Lūdzu ievadi savu veumu");

int userAge = int.Parse(Console.ReadLine());


Console.WriteLine(userName1);
Console.WriteLine(userAge);
Console.WriteLine($"Sveiks {userName1}, tavs vecums ir {userAge}.");
