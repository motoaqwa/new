// TODO:  Почитай про List



Console.WriteLine("enter number:");
int[] array;

// LINQ
// TODO: Працює тільки для 6ти чисел, розібратись, як те, що ввів користувач (строка '1,2,3,4') перетворити на масив
int max = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}

Console.WriteLine($"Максимальне число {max}");
Console.ReadLine();
