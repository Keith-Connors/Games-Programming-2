using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songDetails = { "I say a little Prayer.", "Aretha Franklin", "Aretha Now", "1968", "2" };

            float songDuration = 3.36f;
            songDuration = 3 * 60 + 36;

            Console.WriteLine("Song name is: " + songDetails[0]);
            Console.WriteLine("Song duration is: " + songDuration + " seconds");
            Console.WriteLine("Artist name is: " + songDetails[1]);
            Console.WriteLine("Album name is: " + songDetails[2]);
            Console.WriteLine("Album year is: " + songDetails[3]);
            Console.WriteLine("Album track index is: " + songDetails[4]);

            songDuration = songDuration / 60;
            double durationFloor = Math.Floor(songDuration);
            songDuration = (songDuration % 60) * 10;

            Console.WriteLine("Song duration is: " + durationFloor.ToString() + ":" + songDuration + " minutes");
            Console.ReadKey();
        }
    }
}
