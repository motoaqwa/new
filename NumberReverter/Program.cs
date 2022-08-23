Console.WriteLine("Enter number: ");

// TODO: Програма не працює для великих чисел, наприклад 3147483647
// Підказка: почитати, що таке Int32, яке найбільше значення він має. Які ще є типи
uint num = Convert.ToUInt32(Console.ReadLine());
string result = "";
int a = num % 10;
num = num / 10;
result += a;

// TODO: Цей код повторюється 5 разів, подумай, як усунути цю проблему
a = num % 10;
num = num / 10;
result += a;

Console.WriteLine(result);