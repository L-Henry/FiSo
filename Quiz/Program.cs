using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz1 = new Quiz("Eerste quiz.");

            VraagAntwoord va1 = new VraagAntwoord("Wat is de hoogste berg?", "Mount Everest.");
            VraagAntwoord va2 = new VraagAntwoord("Wat is rood en geel tesamen?", "Oranje");
            VraagAntwoord va3 = new VraagAntwoord("Wat is de naam van de koning?", "Filip");

            quiz1.VoegVraagAntwoodToe(va1);
            quiz1.VoegVraagAntwoodToe(va2);
            quiz1.VoegVraagAntwoodToe(va3);


            string command = "";
            do
            {
                Console.WriteLine("Wat wilt u doen?");
                Console.WriteLine("1) Quiz beheren."); //Console.WriteLine("2) Vraag en antwoord toevoegen.");
                Console.WriteLine("2) Quiz spelen.");
                Console.WriteLine();
                Console.WriteLine("9) Exit.");
                Console.WriteLine();
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        string command2 = "";
                        do
                        {
                            Console.WriteLine("1) Nieuwe quiz maken.");
                            Console.WriteLine("2) Quiz verwijderen.");
                            Console.WriteLine();
                            Console.WriteLine("9) Terug.");
                            Console.WriteLine();
                            command2 = Console.ReadLine();
                            switch (command2)
                            {
                                case "1":
                                    Console.WriteLine("Geef quiznaam in.");
                                    string nieuweQuizNaam = Console.ReadLine();
                                    Quiz nieuweQuiz = new Quiz(nieuweQuizNaam);
                                    string input = "";
                                    do
                                    {
                                        Console.WriteLine("Geef vraag in.");
                                        string nieuweVraag = Console.ReadLine();
                                        Console.WriteLine("Geef antwoord in.");
                                        string nieuwAntwoord = Console.ReadLine();
                                        nieuweQuiz.VoegVraagAntwoodToe(new VraagAntwoord(nieuweVraag, nieuwAntwoord));
                                        Console.WriteLine("Nog een vraag en antwoord? y/n");
                                        input = Console.ReadLine();
                                    } while (input.ToLower() != "n");
                                    nieuweQuiz.SchrijfQuizWeg();
                                    break;
                                case "2":
                                    Console.WriteLine("Welke quiz verwijderen?");
                                    string verwijderWelke = Console.ReadLine();
                                    QuizFileStorage.VerwijderQuiz(verwijderWelke);
                                    Console.WriteLine($"{verwijderWelke} is verwijderd.");
                                    break;
                            }
                        } while (command2 != "9");
                        break;

                    case "2":
                        string antwoord = "";
                        Console.WriteLine("Welke quiz wilt u spelen?");
                        QuizFileStorage.ToonAlleQuizNamen();
                        string quizNaam = Console.ReadLine();
                        Quiz actieveQuiz = QuizFileStorage.LeesQuizIn(quizNaam);
                        do
                        {
                            int tempIndex = actieveQuiz.GeefWillekeurigVraag();
                            Console.WriteLine("Geef antwoord.");
                            antwoord = Console.ReadLine();
                            actieveQuiz.CheckAntwoord(antwoord, actieveQuiz.VraagAntwoorden[tempIndex]);
                            Console.WriteLine("Nog een vraag?");
                            antwoord = Console.ReadLine();
                        } while (antwoord.ToLower() != "n");
                        break;
                    default:
                        break;
                }
            } while (command != "9");


            Console.ReadLine();

        }
    }
}
