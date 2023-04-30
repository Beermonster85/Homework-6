// Задача №1
// Напишите программу которая принимает на вход три числа и проверяет может ли существовать треугольник со сторонами такой длины
// Теорема о неравенстве треуголника: каждая сторона треугольника меньше суммы двух других сторон

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите первое число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите первое число");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (((num1 < (num2 + num3)) && (num2 < (num1 + num3)) && (num3 < (num1 + num2))))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// Задача №2
// Написать программу которая преобразовывает десятичные числа в двоичные
// 45 ----> 101101
// 3 -----> 11
// 2 -----> 10

// Console.WriteLine("Введите первое число");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = "";

// while (num > 0)
// {
//     result = num % 2 + result;
//     num = num / 2;
// }

// Console.WriteLine(result);

// Задача № 3
// Не используя рекурсию выведите первые N чисел Фибоначи.
// Первые 2 числа Фибоначи 0 и 1.
// Если N = 5 ---> 01123

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] fib = new int[num];
// fib[0] = 0;
// fib[1] = 1;
// int i = 2;
// Console.Write($"{fib[0]}  {fib[1]}");

// while (i < num)
// {
//     fib[i] = fib[i - 1] + fib[i - 2];
//     Console.Write($"{fib[i]}");
//     i++;
// }