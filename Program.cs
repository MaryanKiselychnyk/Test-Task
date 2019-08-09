using Newtonsoft.Json;
using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryName = "";
            DirectoryInfo directoryInfo;

            while (true)
            {
                Console.WriteLine("Please input directory name.");
                directoryName = Console.ReadLine();
                directoryInfo = new DirectoryInfo(directoryName);
                if (directoryInfo.Exists)
                    break;
                Console.WriteLine("There isn't any directory with this name. Please try again.");
            }

            Folder folder = new Folder(directoryInfo);

            string res = JsonConvert.SerializeObject(folder, Formatting.Indented);

            //using (var sw = new StreamWriter(@"Test.txt", false, System.Text.Encoding.Default))
            using (var sw = new StreamWriter(@"Test.json", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(res);
            }
            Console.WriteLine("Sucsessful!");
            Console.ReadKey();
        }
    }
}
