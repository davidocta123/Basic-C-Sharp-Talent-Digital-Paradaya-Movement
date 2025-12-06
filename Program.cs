// FizzBuzz
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine("Fizz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
// }

int sum = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}
Console.WriteLine($"Total angka genap 1-100 = {sum}");

Console.Write("Masukkan kata: ");
string input = Console.ReadLine();

// Buat string terbalik
string reversed = "";

for (int i = input.Length - 1; i >= 0; i--)
{
    reversed += input[i];
}

// Bandingkan (ignore huruf besar/kecil)
if (input.ToLower() == reversed.ToLower())
    Console.WriteLine("Ini palindrome");
else
    Console.WriteLine("Bukan palindrome");



  
