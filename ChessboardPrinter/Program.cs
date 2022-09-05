// TODO: Користувач може ввести число (не більше 20) і така має бути дошка(зараз 8х8)

for (int i = 8; i > 0; i--)
{
    for (int j = 0; j < 8; j++)
    {
        if ((i + j) % 2 == 0)
        {
            Console.Write('*');
        }
        else if ((i + j) % 2! == 0)
        {
            Console.Write(' ');
        }
    }

    Console.WriteLine();
}
