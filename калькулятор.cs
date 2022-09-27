Console.WriteLine("выберите тип операции:" +
    " 1. Сложить 2 числа" +
    " 2. Вычесть первое из второго" +
    " 3. Перемножить два числа" +
    " 4. Разделить первое на второе" +
    " 5. Возвести в степень N первое число" +
    " 6. Найти квадратный корень из числа" +
    " 7. Найти 1 процент от числа" +
    " 8. Найти факториал из числа" +
    " 9. Выйти из программы");

int c = Convert.ToInt32(Console.ReadLine()); 
for (; c < 9; c = Convert.ToInt32(Console.ReadLine()))
{ 
    switch (c)
    {
        case 1:
            Console.WriteLine("введите первое число");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите второе число");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a + b);
            break;

        case 2:
            Console.WriteLine("введите первое число");
            double a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите второе число");
            double b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(b1 - a1);
            break;

        case 3:
            Console.WriteLine("введите первое число");
            double a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите второе число");
            double b2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a2 * b2);
            break;

        case 4:
            Console.WriteLine("введите первое число");
            double a3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите второе число");
            double b3 = Convert.ToInt32(Console.ReadLine());
            
            if (b3 == 0) Console.WriteLine("ne nado");
            Console.WriteLine(a3 / b3);
            break;

        case 5:
            Console.WriteLine("введите первое число");
            double a4 = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());
            double ctepen = 1;
            for (int peremennaya = 1; peremennaya <= n; peremennaya++)
                ctepen *= a4;
            Console.WriteLine(ctepen);
            break;

        case 6:
            Console.WriteLine("введите первое число");
            double a5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите второе число");
            double b5 = Convert.ToInt32(Console.ReadLine());

            if (a5 <= 0) Console.WriteLine("ne nado");
            int koren = 0;
            int x = 1;
            while (x <= a5)
            {
                a5 -= x;
                x += 2;
                koren += 1;
            }
            Console.WriteLine(koren);

            if (b5 <= 0) Console.WriteLine("ne nado");
            int koren1 = 0;
            int x1 = 1;
            while (x1 <= b5)
            {
                b5 -= x1;
                x1 += 2;
                koren1 += 1;
            }
            Console.WriteLine(koren1);
            break;

        case 7:
            Console.WriteLine("введите первое число");
            double a6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите второе число");
            double b6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a6 / 100);
            Console.WriteLine(b6 / 100);
            break;

        case 8:
            Console.WriteLine("введите первое число");
            double a7 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите второе число");
            double b7 = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            int peremennaya2 = 2;
            do
            {
                factorial *= peremennaya2;
                peremennaya2++;
            } while (peremennaya2 <= a7);
            Console.WriteLine(factorial);

            int factorial1 = 1;
            int peremennaya3 = 2;
            do
            {
                factorial1 *= peremennaya3;
                peremennaya3++;
            } while (peremennaya3 <= b7);
            Console.WriteLine(factorial1);
            break;
    }
}

if (c == 9) Console.WriteLine("poka");
if (c >= 9) Console.WriteLine("oshibka");