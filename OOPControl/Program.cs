using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControl
{
    class Program
    {
        static void Main(string[] args)
        {
            FileClass file;
      
            string text = @"Text:Kursach.txt(1B);Solid water
             Image:img.bmp(19MB);1920x1080
             Movie:Logan.2017.mkv(19GB);1920x1080;2h12m
             Text:File.txt(6B);Some string content
             Movie:The.Hateful.Eight.mkv(19GB);1920x1080;3h12m";


            string[] collection = text.Split('\n');

            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }

         

            
            


            Console.ReadKey();
        }

       
            
        

        
    }
}
