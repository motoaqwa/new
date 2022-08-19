Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = "";
int a = num % 10;
num = num / 10;
result += a;

a = num % 10;
num = num / 10;
result += a;

a = num % 10;
num = num / 10;
result += a ;

a = num % 10;
num = num / 10;
result += a;

a = num % 10;
num = num / 10;
result += a;

a = num % 10;
num = num / 10;
result += a;

Console.WriteLine(result);
