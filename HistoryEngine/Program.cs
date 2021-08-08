using CLIGL;
using System;
using System.Collections.Generic;
using HistoryEngine.Data;

namespace HistoryEngine.Core
{
   
    class Program
    {
        public const int WINDOW_WIDTH = 90;
        public const int WINDOW_HEIGHT = 50;
        public static List<Data.Models.Civilisations.Citizens.People.Individual> citz = new List<Data.Models.Civilisations.Citizens.People.Individual>();
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
            
            Initialise();

            Console.ReadLine();

        }
        public static void Initialise()
        {
            //    RenderingWindow window = new RenderingWindow("Terrain Generator", WINDOW_WIDTH, WINDOW_HEIGHT);
            //    RenderingBuffer buffer = new RenderingBuffer(WINDOW_WIDTH, WINDOW_HEIGHT);
            //    buffer.SetRectangle(13, 16, 10, 10, RenderingPixel.FullPixel);
            //    buffer.SetString(13, 16, "Hello World", ConsoleColor.Black, ConsoleColor.Green);
            //    buffer.SetTexture(16, 17, new RenderingTexture(10, 20).ApplyShader(new RenderingShader(16, 17, 10, 10,)));
            //    do { window.Render(buffer); } while (true);
            
            for (int i = 0; i < 15000; i++)
            {
                citz.Add(new Data.Models.Civilisations.Citizens.People.Individual());
            }
        }
        
    }
}
