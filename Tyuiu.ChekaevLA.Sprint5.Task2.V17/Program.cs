using System.Numerics;
using Tyuiu.ChekaevLA.Sprint5.Task2.V17.Lib;

namespace Tyuiu.ChekaevLA.Sprint5.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 5 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("* 2; 1; 7                                                                 *");
            Console.WriteLine("* 1; 2; 4                                                                 *");
            Console.WriteLine("* 2; 3; 4                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            for (int x = 0; x<3; x++) 
            {
                for (int i = 0; i<3; i++) 
                {
                    Console.Write($"Введите значение элемента [{x},{i}] матрицы:");
                    matrix[x, i] = Convert.ToInt16(Console.ReadLine()); 
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string y = dataService.SaveToFileTextData(matrix);
            Console.WriteLine(y);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            File.WriteAllText(path, y);


            Console.ReadKey();
        }
    }
}
