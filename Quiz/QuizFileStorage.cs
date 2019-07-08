using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quiz
{
    static class QuizFileStorage
    {
        static string _filepath { get; set; } = @"C:\Users\Student\source\repos\FiSo\Quiz\";


        public static void SchrijfQuizWeg(this Quiz quiz)
        {
            using (StreamWriter sw = new StreamWriter(_filepath + quiz.Naam + ".txt"))
            {
                for (int i = 0; i < quiz.VraagAntwoorden.Length; i++)
                {
                    sw.WriteLine(quiz.VraagAntwoorden[i].Vraag + ";;" + quiz.VraagAntwoorden[i].Antwoord); //(quiz.Naam + ";;" + 
                }
            }
        }

        public static void ToonAlleQuizNamen()
        {
            string[] fileArray = Directory.GetFiles(_filepath, "*.txt");
            foreach (string item in fileArray)
            {
                Console.WriteLine(Path.GetFileName(item));
            }
        }

        public static Quiz LeesQuizIn(string quiznaam)
        {
            StreamReader sr = new StreamReader(_filepath + quiznaam + ".txt");
            Quiz quiz = new Quiz(quiznaam);
            while (!sr.EndOfStream)
            {
                string[] va = sr.ReadLine().Split(";;");
                quiz.VoegVraagAntwoodToe(new VraagAntwoord(va[0], va[1]));

            }
            return quiz;
        }

        public static void VerwijderQuiz(string welke)
        {
            File.Delete(_filepath + welke + ".txt");
        }



    }
}
