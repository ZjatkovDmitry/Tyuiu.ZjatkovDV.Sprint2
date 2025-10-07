using System.Text;
using Tyuiu.ZjatkovDV.Sprint2.Task6.V13.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #2 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Получение результата из switch                                    *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дата некоторого дня характеризуется тремя натуральными         *");
Console.WriteLine("* числами: g (год), m (порядковый номер месяца) и n (число). По заданным  *");
Console.WriteLine("* g, n и m определить дату следующего дня. Заданный год является          *");
Console.WriteLine("* високосным.                                                             *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: n = 28, m = 2, g = 2024                                *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.FindDateOfNextDay(2024, 2, 28).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();