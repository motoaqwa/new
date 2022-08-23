        Console.WriteLine("enter number:");
        int[] array;
        array = new int[6];
        array[0] = Convert.ToInt32(Console.ReadLine());
        array[1] = Convert.ToInt32(Console.ReadLine());
        array[2] = Convert.ToInt32(Console.ReadLine());
        array[3] = Convert.ToInt32(Console.ReadLine());
        array[4] = Convert.ToInt32(Console.ReadLine());
        array[5] = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < array.Length; i++) ;
        {
            Console.WriteLine($"your numbers look like this:" + (array[0],+ array[1],+ array[2],+ array[3],+ array[4],+ array[5]));
    }
            if(array[0]> array[1]&& array[0]> array[2]&& array[0]> array[3] && array[0] > array[4] && array[0] > array[5])
            {
                Console.WriteLine("max of number =" +array[0]);
            }
            else if (array[1] > array[0] && array[1] > array[2] && array[1] > array[3] && array[1] > array[4] && array[1] > array[5])
            {
                Console.WriteLine("max of number =" +array[1]);
            }
            else if(array[2] > array[0] && array[2] > array[1] && array[2] > array[3] && array[2] > array[4] && array[2] > array[5])
            {
                Console.WriteLine("max of number =" +array[2]);
            }
            else if(array[3] > array[0] && array[3] > array[1] && array[3] > array[2] && array[3] > array[4] && array[3] > array[5])
            {
                Console.WriteLine("max of number =" +array[3]);
            }
            else if (array[4] > array[0] && array[4] > array[1] && array[4] > array[1] && array[4] > array[3] && array[4] > array[5])
            {
                Console.WriteLine("max of number =" +array[0]);
            }
            else if (array[5] > array[0] && array[5] > array[1] && array[5] > array[2] && array[5] > array[3] && array[5] > array[4])
            {
                Console.WriteLine("max of number =" +array[5 ]);
            }
            Console.ReadLine();
            