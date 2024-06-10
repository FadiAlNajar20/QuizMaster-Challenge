namespace QuizMaster_Challenge
{
    internal class Program
    {
        public static void StartQuiz()
        {

            List<string> question = new List<string>() {
                "How many time zones are there in Russia?\n" +
                " Choose the correct answer: 11 12 38 98",
                "How many stripes are there on the US flag?\n" +
                " Choose the correct answer: 88 22 13 101",
                "What’s the national animal of Australia?\n" +
                " Choose the correct answer: Red Kangaroo, Lion, rabbit, hawk",
                "How many days does it take for the Earth to orbit the Sun?\n " +
                "Choose the correct answer: 365 90 780 1000",
                "Which of the following empires had no written language?\n" +
                " Choose the correct answer: Incan, Aztec, Egyptian, Roman",
                "Until 1923, what was the Turkish city of Istanbul called?\n" +
                " Choose the correct answer: Constantinople, Izmir, Carappok, nhummus"
            };

            List<string> answer = new List<string>() {
                "11",
                "13",
                "red kangaroo",
                "365",
                "incan",
                "constantinople"
            };

            int score = 0;
            //int time = 10;


            for (int i = 0; i < question.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {question[i]}");
                bool isAnswer = false;
                while (!isAnswer)
                {
                    Console.Write("Your answer: ");
                    string userAnswer = Console.ReadLine().ToLower();

                    if (!string.IsNullOrEmpty(userAnswer))
                    {
                        if (userAnswer.Equals(answer[i]))
                        {
                            score++;
                            isAnswer = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Your answer is correct\n");
                            Console.ResetColor();
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Oops! The answer is not correct.\n");
                            Console.ResetColor();
                            isAnswer = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your answer is invalid try agin!\n");
                    }
                }
            }

            Console.WriteLine($"Your score is: {score} - Question is: {question.Count}");

        }
        static void Main(string[] args)
        {
            try
            {
                StartQuiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nThank you for answering! You did great work ");
            }

        }
    }
}