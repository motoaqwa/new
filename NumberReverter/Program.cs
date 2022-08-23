Console.WriteLine("Enter number: ");
uint num = Convert.ToUInt32(Console.ReadLine());

string result = "";
uint a = num % 10;
num = num / 10;
result += a;

a = num % 10;
num = num / 10;
result += a;
//як змінити повторення в голову не приходить
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