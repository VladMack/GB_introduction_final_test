using System;
using System.Linq;

Console.Clear();

Console.WriteLine("Введи элементы массива через пробел:");
string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
string[] resultArray = GetLenSelectedArray(array, 3);

Console.WriteLine(string.Join(", ", resultArray));