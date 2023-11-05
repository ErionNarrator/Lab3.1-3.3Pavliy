//Сред 3.1 вар 24

//int n;
//Console.WriteLine(" Введите N");
//n = Convert.ToInt32(Console.ReadLine());

//int x = n % 10;
//int y = 0;
//while (n >= 10)
//{
//    y += n % 10;
//    n /= 10;
//}
//y += n;
//Console.WriteLine("Первая и последняя цифра " + n + " ; " + x);
//Console.WriteLine("Сумма цифр: " + y);


//Слож 3.2 вар 24
int i;
int c;
int j;
for (i = 1; i <= 1000; i++)
{
    c = 0;
    for (j = 1; j <= i; j++)
    {
        if ((i % j) == 0)
        {
            c++;
        }
    }
    if (c == 5)
    {
        Console.WriteLine("\n число: {0}", i);
    }
}

// 3.3 вар 23
//try
//{
//    Console.Write("Введите х:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    int y = int.Parse(Console.ReadLine());
//    double s = 0;
//    for (int i = 1; i <= y; i++)
//    {
//        long f = 1;
//        for (int j = 1; j <= y; j++)
//            if (i % 2 == 0)
//            {
//                s += Math.Sin(i * Math.PI / 4) / f;
//            }
//            else
//            {
//                s -= Math.Sin(i * Math.PI / 4) / f;
//            }
//    }
//    Console.Write($"S={s:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);  
//}
//3.4 (,база, не мой варик)
//double x = 0.1;
//Console.ForegroundColor = ConsoleColor.Green;
//Console.Write("|    x    |    y    |");
//while (x <= 3)
//{
//    double y = Math.Sqrt(1 + x) - 3 * Math.Cos(x);
//    Console.WriteLine($"|{x,4:F2}|{y,8:F2}|");
//    x += 0.2;
//}
// 3.4 (, сред,  мой)
//Console.WriteLine("|    x    |    y    |");
//for (double x = -1; x <= 15; x += 0.2)
//{
//    double y;
//    if (x < 3.8) y = 5 * x * Math.Log(Math.Abs(1 + x));
//    else if (2.8 <= x && x <= 3.8) y = Math.Exp(Math.Pow(-x, 2) + 2);
//    else  y = -Math.Sin(x);
//    //else y = x + 1;
//    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
//}





//11.123
//Random random = new Random();
//int n = 10;
//int[] arr = Enumerable.Range(0, n).Select(_ => random.Next(0, 31)).ToArray();
//Console.WriteLine(string.Join(" ", arr));
//int more_than_20 = 0;
//int less_than_50 = 0;
//foreach (int e in arr)
//{
//    if (e > 20)
//    {
//        more_than_20 += e;
//    }
//    if (e < 50)
//    {
//        less_than_50 += e;
//    }
//}
//Console.WriteLine($"верно ли, что сумма элементов, которые больше 20, превышает 100: {more_than_20 > 100}");
//Console.WriteLine($"верно ли, что сумма элементов, которые меньше 50, есть четное число: {less_than_50 % 2}");
