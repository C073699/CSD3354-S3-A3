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
            new Blue().SayFavouriteFood(Red.FavouriteFood);

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
                //post condition of while is:
                //we now have a data member  named names which is in queue
                PlayingWithStacks.Run(names);
            }
        }
    }
    class PlayingWithStacks
    {
        public static void Run( Queue<string> tangerine)
        {
            Stack<string> names = new Stack<string>();
            //how can I access the queue variables"names" here in this class

            // iterate over  queue
            //get each element
            //push it into Stack
            foreach (var item in tangerine)
            {
                names.Push(tangerine.Dequeue());

                //Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }

    class Workbench
    {

    }
    class Red
    {
        public static string FavouriteFood = "carrots";
    }
    class Blue
    {
        public void SayFavouriteFood(string FavFood)
        {
            Console.WriteLine(Red.FavouriteFood);
        }
        
        
    }
    
}


