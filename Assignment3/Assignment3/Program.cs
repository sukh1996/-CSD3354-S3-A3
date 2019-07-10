using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment3
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

            // Open the names file and access the data
            using (StreamReader file = new StreamReader("U:/Users/736051/Assignment3/Assignment3/Assignment3/names.txt"))
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
    class PlayingWithStacks
    {
        public static void Run(Queue<string> tangerine)
        {
            Stack<string> names = new Stack<string>();
            // how can I access the Queue variables "names" here in this class???
            // iterate OVER our Queue 
            // get each element
            // push it into the Stack
            foreach (var item in tangerine)
            {
                names.Push(tangerine.Dequeue());
            }
        }
    }

    class Workbench { }

    class Red
    {
        public static string FavoriteFood = "Carrots";
    }

    class Blue
    {
        public void SayFavoriteFood(string FavFood)
        {
            Console.WriteLine(Red.FavoriteFood);
        }
    }
}
