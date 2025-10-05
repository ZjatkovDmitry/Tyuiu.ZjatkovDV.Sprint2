using System.Text;
using Tyuiu.ZjatkovDV.Sprint2.Task1.V2.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #2 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу из операций сравнений (==, !=, <, >, <=,    *");
Console.WriteLine("* >=, последовательность можно чередовать, но использовать один раз в     *");
Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                   *");
Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
Console.WriteLine("* арифметических выражений, которая вернет логическую                     *");
Console.WriteLine("* последовательность(массив): (True, True, True, True, True, False),      *");
Console.WriteLine("* при a = 135, b = 156, c = 154, d = 174                                  *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: a = 135, b = 156, c = 154, d = 174                     *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

Console.Write("(");
foreach (bool element in result.GetLogicOperations(135, 156, 154, 174))
{
    Console.Write($"{element.ToString()}, ");
}
Console.WriteLine("\b\b)");

Console.WriteLine(new string('*', 75));
Console.ReadKey();