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

// Задача №4 
// Напишите программу которая перевернет одномерный массив (последний элеент будет на первом месте а первый на поледнем
// [1 2 3 4 5] ---> [5 4 3 2 1]

// int[] array = new int[5] { 1, 2, 3, 4, 5 };

// int temp = 0;
// for (int i = 0; i < array.Length / 2; i++)
// {
//     temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
// }

// Console.WriteLine(String.Join("", array));



// Homework
// Задание №1
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] array = new int[5] { 1, 2, 0, 4, 5 };
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");


// Задание №2
//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1) / (-k1 + k2);
// double y = k2 * x + b2;

// Console.Write(x);
// Console.WriteLine(y);