namespace Tyuiu.ChekaevLA.Sprint5.Task3.V27.Lib
{
    public class DataService
    {
        public byte[] SaveToFileTextData(int x)
        {
            double y = Math.Round(Math.Pow((x - 1), 3 * x + 1), 3);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
             
            }
            return File.ReadAllBytes(path);
        }
    }
}
