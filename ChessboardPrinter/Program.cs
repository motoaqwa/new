Console.WriteLine("enter broard dimension: ");

int dimension = int.Parse(Console.ReadLine());

for (int i = 0; i < dimension; i++)
{
    for (int j = 0; j < dimension; j++)
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
