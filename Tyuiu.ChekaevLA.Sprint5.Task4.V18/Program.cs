using Tyuiu.ChekaevLA.Sprint5.Task4.V18.Lib;

namespace Tyuiu.ChekaevLA.Sprint5.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 5 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из         *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ *");
            Console.WriteLine("* и скопировать в неё файл) в котором есть вещественное значение.         *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле . Вычислить *");
            Console.WriteLine("* значение по формуле (Полученное значение округлить до трёх знаков после *");
            Console.WriteLine("* запятой) и вернуть полученный результат на консоль.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* InPutDataFileTask4V18.txt                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V18.txt");

            Console.WriteLine(dataService.LoadFromDataFile(path));

            Console.ReadKey();
        }
    }
}
