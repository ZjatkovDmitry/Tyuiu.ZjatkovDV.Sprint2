using System.Text;
using Tyuiu.ZjatkovDV.Sprint2.Task0.V10.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #2 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу из операций сравнений (==, !=, <, >, <=,    *");
Console.WriteLine("* >=, последовательность операций не должна нарушаться) и арифметических  *");
Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
Console.WriteLine("* (False, True, False, True, False, True), при x = 1305, y = 475          *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: x = 1305, y = 475                                      *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

Console.Write("(");
foreach (bool element in result.GetCompareOperations(1305, 475))
{
    Console.Write($"{element.ToString()}, ");
}
Console.WriteLine("\b\b)");

Console.WriteLine(new string('*', 75));
Console.ReadKey();