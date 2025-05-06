namespace PersistenteDatenspeicherungAHK2028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\test.txt";
            string[] readLines;
            if (File.Exists(path))
            {
                readLines = File.ReadAllLines(path);
                Console.WriteLine($"Welche Zeile soll gelöscht werden?\n" +
                    $" Geben Sie eine Zahl ein von 0- {readLines.Length}:\n" +
                    $"Zeile 1 ist dabei 0!\n");
                int zahl = 0;
                while(Int32.TryParse(Console.ReadLine(),out zahl))
                for (int i = zahl; i < readLines.Length; i++)
                {
                        readLines[i] = readLines[i + 1];
                }
                readLines[3]=readLines[3];
            }
                


            File.AppendAllText(path,);
            var readText=File.ReadAllText(path);
            Console.WriteLine(readText);
            
            Console.WriteLine(readLines);
            foreach (var item in readLines)
            {
                Console.WriteLine(item);
            }

            

        }
    }
}
