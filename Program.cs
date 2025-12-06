// See https://aka.ms/new-console-template for more information
// int score = 90;

// if (score >= 95)
// {
//     Console.WriteLine("A");
// }
// else if (score >= 75)
// {
//     Console.WriteLine("B");
// }
// else
// {
//     Console.WriteLine("C");
// }

var day = "Monday";

switch (day)
{
    case "Monday":
        Console.WriteLine("Weekday");
        break;

    case "Friday":
        Console.WriteLine("Weekend");
        break;

    default:
        Console.WriteLine("Midweek");
        break;
}


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
 
 int n = 0;

 while ( n < 5)
{
    Console.WriteLine("Repeat");
    n++;
}

string[] names = {"Azri Aisyah"};
foreach (var name in names)
{
    Console.WriteLine(name);
}
