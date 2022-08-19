Console.WriteLine("There are many differences between Ukraine and America, not only in  languages ​​and national mentalities,\n but also in evaluation, for example ,enter the number(grade) that you would like to \n convert to the English grading system ");
int userInput = Convert.ToInt32(Console.ReadLine());
string result = string.Empty;

if (userInput > 0 && userInput <= 19)
{
    result = "F";
}
else if (userInput > 19 && userInput <= 39)
{
    result = "E";
}
else if (userInput > 39 && userInput <= 59)
{
    result = "D";
}
else if (userInput > 59 && userInput <= 74)
{
    result = "C";
}
else if (userInput > 75 && userInput <= 89)
{
    result = "B";
}
else if (userInput > 89 && userInput <= 100)
{
    result = "A";
}
else if (userInput > 100)
{
Console.WriteLine("number is unidentified");
}

Console.WriteLine($"grade :  {result}");
