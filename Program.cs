using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace practiceproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText("C:\\Users\\Gayathri\\Desktop\\practice project\\studentdata.txt");
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
