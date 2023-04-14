using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Transactions;

static bool RectDouble(in double A)
{
    return (A > 0 && A % 2 == 0);
}

static bool RectCulc(in double A)
{
    return (A > 0 && A % 2 == 0);
}

static string RectCultString(string inputString)
{
    char[] symbolsArray = inputString.ToCharArray();

    for (int i = 2; i < symbolsArray.Length; i += 3)
    {
        if (Char.IsLetter(symbolsArray[i]))
        {
            symbolsArray[i] = Char.ToUpper(symbolsArray[i]);
        }
    }

    string resultString = new string(symbolsArray);

    return resultString;
}

try
{
    int p;
    do
    {
        Console.WriteLine("Выберите задание от 1 до 3, чтобы выйти введите 0");
        Console.Write("Задание - ");

        p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (p)
        {
            case 0:
                {
                    Console.WriteLine("Выход осуществлен");
                }
                break;

            case 1:
                {
                    Console.Write("Введите число - ");
                    int x = Convert.ToInt32(Console.ReadLine());

                    if (RectDouble(x))
                        Console.WriteLine("Число " + x + " положительное и четное.");
                    else
                        Console.WriteLine("Число " + x + " не подходит под условия.");

                    Console.WriteLine();
                    Console.WriteLine("========================================================================================================================");
                }
                break;

            case 2:
                {
                    Console.Write("Введите размер массива - ");
                    int X = Convert.ToInt32(Console.ReadLine());

                    int[] mass = new int[X];
                    Random rnd = new Random();

                    for (int i = 0; i < mass.Length; i++)
                    {
                        mass[i] = rnd.Next(-9, 10);
                    }

                    Console.Write("Массив: ");
                    for (int i = 0; i < mass.Length; i++)
                    {
                        Console.Write(mass[i] + " ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("========================================================================================================================");
                }
                break;

            case 3:
                {
                    Console.WriteLine("Введите строку :");
                    string str = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();

                    str = RectCultString(str);
                    Console.WriteLine(str);

                    Console.WriteLine();
                    Console.WriteLine("========================================================================================================================");
                }
                break;

            default:
                Console.WriteLine("Неверный номер задания");
                break;
        }
    }
    while (p != 0);
}
catch
{
    Console.WriteLine("========================================================================================================================");
    Console.WriteLine("КРИТИЧЕСКАЯ ОШИБКА!");
    Console.WriteLine("-Вводите корректные данные-");
    Console.WriteLine("[Требуется перезапуск программы]");
    Console.ReadLine();
}