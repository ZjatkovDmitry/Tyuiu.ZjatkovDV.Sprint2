using System.Text;
using Tyuiu.ZjatkovDV.Sprint2.Task7.V13.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #2 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу на C#, которая запрашивает исходные данные  *");
Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
Console.WriteLine("* X,Y в заштрихованной области.                                           *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("x = ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("y = ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.CheckDotInShadedArea(x, y).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();