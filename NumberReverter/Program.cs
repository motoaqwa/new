Console.WriteLine("Enter number: ");
string num = Console.ReadLine();

for (int i = num.Length - 1; i >= 0; i--)
{
    Console.Write(num[i]);
}