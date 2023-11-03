/*
//                          Напишите программу которая на вход принимает число и выдает его квадрат
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
// математически 
int sqr = number * number;
Console.WriteLine(sqr);
// библиотека Math
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат данного числа, равен = {sqr1} (вот так прописывается с добавлением доллара)");


//                                    Напишите программу которая на вход принимает 2 числа 
//                                    и проверяет, является ли первое число квадратом 2го
Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number1 = int.Parse(Console.ReadLine()!);

int sqr = Convert.ToInt32(Math.Pow(number1, 2));

if(sqr == number)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

//                      Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.Write("Введите номер загаданного дня недели: ");
int date = int.Parse(Console.ReadLine()!);

if(date == 1)
{
    Console.WriteLine("Сегодня Понедельник. ");
}
if(date == 2)
{
    Console.WriteLine("Сегодня Вторник. ");
}
if(date == 3)
{
    Console.WriteLine("Сегодня Среда. ");
}
if(date == 4)
{
    Console.WriteLine("Сегодня Четверг. ");
}
if(date == 5)
{
    Console.WriteLine("Сегодня Пятница. ");
}
if(date == 6)
{
    Console.WriteLine("Сегодня Суббота. ");
}
if(date == 7)
{
    Console.WriteLine("Сегодня Воскресенье. ");
}
if(date < 1)
{
    Console.WriteLine("Иди на хуй, нет такого дня недели. ");
}
if(date > 7)
{
    Console.WriteLine("Иди на хуй, нет такого дня недели. ");
}


//                                  Напишите программу, которая на вход принимает одно число N, 
//                                 а на выходе показывает все целые числа в промежутке от -N  до N

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int N_minus = -N;
while (N_minus <=N)
{
    Console.Write($"{N_minus} ");
    N_minus += 1;
}

//                          Напишите программу, которая принимает на вход трехзначное число и на выходе 
//                            показывает  последнюю цивру этого числа

Console.Write("Введите восьмизначное число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine(num % 10);


// Задача 1.
//          Написать программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("большее число "  +a+ " меньшее число " + b);
}
else 
{
    Console.WriteLine("большее число "  +b+ " меньшее число " + a);
} 


// Задача 2.
// Напишите задачу, которая принимает на вход 3 числа и выдает максимально из этих чисел
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.WriteLine($"Mаксимальное из этих чисел {max}");
//Console.WriteLine(max);


// Задача 3.
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
{
    Console.WriteLine("Число " +a+ " Четное");
}
else
{
    Console.WriteLine("Число: " +a+" нечетное");
}


// Задача 4.
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);

// Первое решение
for(int i = 1; i <= N; i++)
{
    if(i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
}

// Второе решение

int k = 2;
while (k <= N)
{
    Console.Write($"{k} ");
    k += 2;
}


//              Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
//              1. Установить счетчик index в позициию 0
//              2. Если array [index] = find, алгоритм завершил работу успешно
//              3. Увеличить индекс на 1
//              4. index < n. то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.
int[] array = {12, 6, 5, 15, 18, 2, 4};
int n = array.Length;
int find = 5;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


//      Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

int number = new Random().Next(10, 100);
int num1 = number / 10; // 78 -> 7,8 = 7
int num2 = number % 10; // 78 -> 7,8 = 8
int max = num1;
if(max < num2)
{
    max = num2;
}
Console.WriteLine($"Наибольшее цифра числа {number} = {max}");


//          Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int r = new Random().Next(100, 1000);
int a = r / 100;
int b = r % 10;

// int x = a * 10 + b;   Пример: что бы на выходе получить число, умноженое на 10 и + n
// Console.WriteLine($"Первая и третья цифры числа {r} = {x} ");

Console.WriteLine($"Первая и третья цифры числа {r} = {a} и {b}");

//          Кратное-это деление, т.е делится ли первое число на второе
//          Напишите программу, которая на вход будет принимать 2 числа и выводить, является ли второе число кратным 
//          первому. Если 2е число не кратно 1му числу, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()!);
int kratno = num1 % num2;
if(kratno == 0)
{
    Console.WriteLine($"Кратно: ");
}
else
{
    Console.WriteLine($"Не кратно, остаток {kratno}: ");
}


//               Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 - нет
// 46 - нет 
// 161 - да

// || - или
// && - и 

Console.Write($"Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine()!);
if(num1 % 7 == 0 && num1 % 23 == 0)
{
    Console.WriteLine("Да:");
}
else Console.WriteLine("Нет: ");


//       Напишите программу, которая принимает на вход 2 числа и проверяет, является ли одно число квадратом другого
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine()!);
// Вводим 4 и 2
if (num1 / num2 == num2 || num2 / num1 == num1)
{
    Console.WriteLine("Является: ");
}
else
Console.WriteLine("Не вляется: ");
*/


