using System;

namespace ChordFinder
{
    public class Finder
    {
        static void Main(string[] args)
        {
            string input = null;

            Console.WriteLine("Type notes separated by a space or type quit:");

            while (!String.Equals(input ,"quit"))
            {
                input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(FindChord(input));
                }

                else
                {
                    Console.WriteLine("Error");
                }
            }
          
        }

        public static string FindChord(string input)
        {
            switch (input)
            {
                case "C E G":
                    return "C major";
                case "C# E# G#":
                    return "C# major";
                case "D F# A":
                    return "D major";
                case "Eb G Bb":
                    return "Eb major";
                case "E G# B":
                    return "E major";
                case "F A C":
                    return "F major";
                case "F# A# C#":
                    return "F# major";
                case "G B D":
                    return "G major";
                case "Ab C Eb":
                    return "Ab major";
                case "A C# E":
                    return "A major";
                case "Bb D F":
                    return "Bb major";
                case "B D# F#":
                    return "B major";
                case "quit":
                    return "Bye!";
                default:
                    return "Invalid input.";
            }

        }
    }
}
