Console.WriteLine("A B C D E F G H");
Console.WriteLine("---------------");
for (int i = 8; i > 0; i--)
{
    for (int j = 1; j < 10; j++)
    {
        if (j == 9)
        {
            Console.Write("|" + i);
        }
        else
        {
            if ((i + j) % 2 == 0)
            {
                Console.Write('#' + " ");
            }
            else
            {
                Console.Write(((char)79).ToString() + " ");
            }
        }
    }
    Console.WriteLine();

}
Console.WriteLine();                                                                         