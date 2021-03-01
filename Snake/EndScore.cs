using System;
using System.Diagnostics;
using System.IO;

namespace Snake
{
    public class EndScore
    {
        public EndScore(int score, string pathToResources)
        {
            Console.Clear();
            Console.WriteLine("Write your name or nickname: ");
            string name = Console.ReadLine();
            StreamWriter file = new StreamWriter(pathToResources + "scores.txt", true);
            file.WriteLine(name + " - " + score + " ");
            file.Close();
        }
    }
}