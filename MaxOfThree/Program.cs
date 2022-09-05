Console.WriteLine("Hello, users!!! \n A simple task is to enter three numbers and find the largest possible value\n Enter numer: ");

int userInput1;
userInput1 = Convert.ToInt32(Console.ReadLine());
int userInput2;
Console.WriteLine($"Enter the second number: ");
userInput2 = Convert.ToInt32(Console.ReadLine());
int userInput3;
Console.WriteLine($"Enter the third number: ");
userInput3 = Convert.ToInt32(Console.ReadLine());

if (userInput1 > userInput2 && userInput1 > userInput3)
    Console.WriteLine($"maximum number : {userInput1}");

else if (userInput2 > userInput1 && userInput2 > userInput3)
    Console.WriteLine($"maximum number : {userInput2}");

else if (userInput3 > userInput1 && userInput3 > userInput2)
    Console.WriteLine($"maximum number : {userInput3}");


// Код працює
