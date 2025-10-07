using System.Text;
using Tyuiu.ZjatkovDV.Sprint2.Task4.V9.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #2 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу, которая вычисляет требуемое значение       *");
Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит значение *");
Console.WriteLine("* переменных x, y с клавиатуры, если x + 5 < y / 2, то                    *");
Console.WriteLine("* z = (7 + 1/(x^2))^y, иначе z = x^4 - (3/y). Ответ округлить до 3 знаков *");
Console.WriteLine("* после запятой.                                                          *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: z = (7 + 1/(x^2))^y; z = x^4 - (3/y)                   *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("y = ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.Calculate(x, y).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();