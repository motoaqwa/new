// Прогама допомагає вирахувати зміну на заводі.
// У місяці 31 день. 1 го числа починається ранкова зміна (з 7:00).
// Графік 4 на 1(4 ранкові, 1 вихідний, 4 з 15:00, вихідний і т.д.).
// Користувач вводить число місяця - програма має розрахувати, в яку зміну працює робітник

Console.WriteLine("work or day off!!!");
int i = Convert.ToInt32(Console.ReadLine());
if (i >= 4 && i < 0)
{
    Console.WriteLine("yor working day in the morning: at 7:00 ");
}
else if (i == 5)
{
    Console.WriteLine("day off");
}
else if (i >= 6 && i < 9)
{
    Console.WriteLine("yor working day in the morning: at 15:00 "); 
}
else if (i == 10)
{
    Console.WriteLine("day off");
}
else if (i >= 11 && i < 14)
{
    Console.WriteLine("yor working day in the morning: at 23:00 ");
}
else if (i == 15)
{
    Console.WriteLine("day off");
}
else if (i >= 16 && i < 19 )
{
    Console.WriteLine("yor working day in the morning: at 7:00 ");
}
else if (i == 20)
{
    Console.WriteLine("day off");
}
else if (i >= 21 && i < 24)
{
    Console.WriteLine("yor working day in the morning: at 15:00 ");
}
else if (i == 25)
{
    Console.WriteLine("day off");
}
else if (i >= 26 && i < 29)
{
    Console.WriteLine("yor working day in the morning: at 23:00 ");
}
else if (i == 30)
{
    Console.WriteLine("day off");
}
else if (i == 31)
{
    Console.WriteLine("yor working day in the morning: at 23:00 ");
}
else if (i > 31)
{
    Console.WriteLine("unidentified number");
}
