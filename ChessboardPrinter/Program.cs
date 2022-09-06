Console.WriteLine("Привет пользователь с твоей помощью хотел бы построить \n шахматную доску с твоими размерами: \n введи размерность вертикали доски ");

int gor = int.Parse(Console.ReadLine());

for (int i = gor; i > 0; i--)
{
    for (int j = 1; j < gor+1; j++)
    {

        if ((i + j) % 2 == 0)
        {
            Console.Write('*');
        }
        else if ((i + j) % 2! == 0);
        {
            Console.Write(' ');
        }
    }
    Console.WriteLine();

}
