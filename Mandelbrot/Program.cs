/***********************************************************************************************
 * Name: Twymun Safford
 * 
 * Purpose: Simple implementation of Mandelbrot as a console application.
 * 
***********************************************************************************************/
using System;

namespace Mandelbrot
{
    class Program
    {
        static void Main(string[] args)
        {
            double za = 0;
            double zb = 0;
            double za_temp = 0;
            const double X_MIN = -2;
            const double X_MAX = 1;
            const double Y_MIN = -1.5;
            const double Y_MAX = 1.5;
            const int X_WIDTH = 120;
            const int Y_HEIGHT = 60;
            const int ITERATIONS = 20;
            int index = 0;
            string[] DISPLAY = { "i", "-", "v", "m", "W", "O", "&", "%", "$", " " };

            double ca;
            double cb;
            for (int y = Y_HEIGHT; y > 0; y--)
            {
                cb = Y_MAX - y * (Y_MAX - Y_MIN) / Y_HEIGHT;
                for (int x = 0; x < X_WIDTH; x++)
                {
                    ca = X_MIN + x * (X_MAX - X_MIN) / X_WIDTH;
                    za = ca;
                    zb = cb;
                    //Console.WriteLine($"{ca,17:f17}, {cb,17:f17}");
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        za_temp = za * za - zb * zb + ca;
                        zb = 2 * za * zb + cb;
                        za = za_temp;
                        index = i;
                        if ((za * za + zb * zb) > 4)
                        {
                            break;
                        }
                    }
                    index = (int)((double)index / ((double)ITERATIONS / 10));
                    Console.Write($"{DISPLAY[index]}");
                }
                Console.WriteLine();
            }
        }
    }
}
