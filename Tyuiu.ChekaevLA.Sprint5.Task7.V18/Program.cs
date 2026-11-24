using Tyuiu.ChekaevLA.Sprint5.Task7.V18.Lib;

namespace Tyuiu.ChekaevLA.Sprint5.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 5 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V18.txt (файл взять из архива *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Заменить *");
            Console.WriteLine("* все буквы \"н\" на \"нн\".Полученный результат сохранить в файл         *");
            Console.WriteLine("* OutPutDataFileTask7V18.txt.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* InPutDataFileTask7V18.txt                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string inputpath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V18.txt");
            string outputpath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V18.txt");

            Console.WriteLine(dataService.LoadDataAndSave(inputpath));

            File.WriteAllText(outputpath, dataService.LoadDataAndSave(inputpath));

            Console.ReadKey();
        }
    }
}
