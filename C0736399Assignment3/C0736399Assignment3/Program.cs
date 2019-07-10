using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0736399Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new TextProcessing();
            tp.Run();
        }

    }
    class TextProcessing
    {
        Queue<string> names = new Queue<string>();
        public void Run()
        {
            
            // open the names file and acess the data
            using (StreamReader file = new StreamReader("C:/Users/gurin_9drx78b/Assignment3/C0736399Assignment3/C0736399Assignment3/names.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    names.Enqueue(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
    }
}
