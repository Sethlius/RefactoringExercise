using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RefactoringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //REFAKTORISERA KODEN
            //Fixa koden så den blir bättre att läsa och underhålla.
            //Lägg fokus på:
            //1- Undvik Repeterad kod. Ersätt den för metoder
            //2- Lägg kommentarer. Du kan väl gyssa vad koden gör och lägga den som kommentärer
            //3- Validera input. dvs, parsa och kolla att det är i rätt typ
            //4- Hantera errors. Informera om fel och/eller skapa kod som inte crashar.
            //5- Ge feedback till användaren. Om den skriver fel ska den få veta varför.
            bool isRunninf = true;
            int answer;
            
            void MakeLine(int lineLengt = 6) //makse line, has a defult parameter of six (like the orginal code)
            {
                for (int i = 0; i < lineLengt; i++)
                {
                    Console.Write(" # ");
                }
            }
            void MaxHashtags(int number) //Hashatag counter thingy
            {
                if (number <= 10 && answer == 2)
                {
                    MakeLine(number);
                }
                else if (number <= 10 && answer == 4)
                {
                    MakeSquare(number);
                }
                else
                {
                    Console.WriteLine("You have writen an invalid number for the hashatag amount");
                }
            }
            void MakeSquare(int squarius = 5) //makse the squares, has a defult parameter of 5 (like the original code)
            {
                for (int i = 0; i < squarius; i++)
                {
                    for (int j = 0; j < squarius; j++)
                    {
                        Console.Write("##");
                    }
                    Console.WriteLine();
                }
            }
            void BorderControll(string textInBorder = " Static Border ") //makse the border (it has the same deuflt parameter as the orignial code)
            {
                if (textInBorder.Length < 21)
                {
                    for (int i = 0; i < textInBorder.Length + 4; i++)
                    {
                        Console.Write(" # ");
                    }
                    Console.WriteLine($"\n# {textInBorder} #");
                    for (int i = 0; i < textInBorder.Length + 4; i++)
                    {
                        Console.Write(" # ");
                    }
                }
                else
                {
                    Console.WriteLine("You have written to many letters, please write less letters");
                }
               
            }

            int hatagCOntroll(int theParseIsTryed = 0) //to make sure hastag is a number
            {
                string theLine = Console.ReadLine();
                if (theLine == "1" || theLine == "2" || theLine == "3" || theLine == "4" || theLine == "5" || theLine == "6" || theLine == "7" || theLine == "8" || theLine == "9" || theLine == "10")
                {
                    return theParseIsTryed = int.Parse(theLine);
                }
                else
                {
                    Console.WriteLine("You have failed to give a valid number, the number range 1-10 (not letters)");
                    return 0;
                }
                
            }
            
            while (isRunninf)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?\n 1. A line\n 2. My Line\n 3. A Square\n 4. My Square\n 5. A border\n 6. My border\n 0. Exit");


                string theAnswer = Console.ReadLine();
                
                if (theAnswer == "0" || theAnswer == "1" || theAnswer == "2" || theAnswer == "3" || theAnswer == "4" || theAnswer == "5" || theAnswer == "6")
                {
                    answer = int.Parse(theAnswer);
                } 
                else
                {
                    answer = 7;
                }
                

                switch (answer)
                {
                    case 0:
                        isRunninf = false;
                        break;
                    case 1:
                        MakeLine();
                        break;
                    case 2:
                        Console.WriteLine("How many hashtags (max 10)");
                        MaxHashtags(hatagCOntroll());
                        break;
                    case 3:
                        MakeSquare();
                        break;
                    case 4:
                        Console.WriteLine("How many hashtags (max 10)");
                        MaxHashtags(hatagCOntroll());
                        break;
                    case 5:
                        BorderControll();
                        break;
                    case 6:
                        Console.WriteLine("Write a sentence (max 20 letters)");
                        BorderControll(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You have failed to give a valid number, try typing an number from 0-6 (not letters)");
                        break;
                }
                Console.ReadLine();

            }

        }
    }
}