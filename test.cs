while (true)
{
    Random random = new();
    int a = random.Next(1, 4);
    int b = random.Next(1, 4);
    if (a == b)
    {
        continue;
    }
    else
    {
        if (a + b == 3)
        {
            Console.WriteLine("Диллер выложил на стол табак и бумагу");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Курильщик со спичками курит..."+i);
                Thread.Sleep(1000);
            }
        }
        else
        {
            if (a + b == 4)
            {
                Console.WriteLine("Диллер выложил на стол табак и спички");
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine("Курильщик с бумагой курит..." + i);
                    Thread.Sleep(1000);
                }
            }
            else
            {
                Console.WriteLine("Диллер выложил на стол спички и бумагу");
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine("Курильщик с табаком курит..." + i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}