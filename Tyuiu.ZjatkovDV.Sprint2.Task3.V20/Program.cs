using System.Text;
using Tyuiu.ZjatkovDV.Sprint2.Task3.V20.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #2 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу, которая вычисляет требуемое значение       *");
Console.WriteLine("* функции Y с использованием вложенных оператор if-else, где пользователь *");
Console.WriteLine("* вводит значение переменной X с клавиатуры. Округлить полученное         *");
Console.WriteLine("* значение до трех знаков после запятой.                                  *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.Calculate(x).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();