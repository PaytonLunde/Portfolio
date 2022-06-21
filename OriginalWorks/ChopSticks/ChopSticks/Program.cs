using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopSticks
{
    class Program
    {
        public static int AIL = 1;
        public static int AIR = 1;
        public static int PL = 1;
        public static int PR = 1;
        public static bool playing = true;
        static void Main(string[] args)
        {
            Display();
            PlayersTurn();

            Console.ReadLine();
        }
        static void AIsTurn()
        {
            if (playing == true)
            {
                switch (AIcansplit())
                {
                    case 1:
                        AISplit();
                        break;
                    case 2:
                        AISplit();
                        break;
                    case 3:
                        AIattack();
                        break;
                    case 4:
                        PR = Calc(AIL, PR);
                        break;
                    case 5:
                        PR = Calc(AIR, PR);
                        break;
                    case 6:
                        PL = Calc(AIL, PL);
                        break;
                    case 7:
                        PL = Calc(AIR, PL);
                        break;
                }
                Display();
                PlayersTurn();
            }
        }
        static void PlayersTurn()
        {
            if (playing == true)
            {
                string atk = PlayerAtk();
                if (atk == "1" || atk == "2")
                {
                    string def = PlayerDef();
                    if (atk == "1" && def == "1" && PL > 0 && AIL > 0)
                    {
                        AIL = Calc(PL, AIL);
                    }
                    else if (atk == "1" && def == "2" && PL > 0 && AIR > 0)
                    {
                        AIR = Calc(PL, AIR);
                    }
                    else if (atk == "2" && def == "1" && PR > 0 && AIL > 0)
                    {
                        AIL = Calc(PR, AIL);
                    }
                    else if (atk == "2" && def == "2" && PR > 0 && AIR > 0)
                    {
                        AIR = Calc(PR, AIR);
                    }
                    else
                    {
                        Console.WriteLine("Error invalid Input");
                        PlayersTurn();
                    }
                }
                else if (atk == "3")
                {
                    PlayerSplit();
                }
                else
                {
                    Console.WriteLine("***************************\nInvalid Input\n*************************");
                    PlayersTurn();
                }
                
                Display();
                AIsTurn();
            }
        }
        static string PlayerAtk()
        {
            Console.Write("Enter 1 to Attack with the Left. \nEnter 2 to Attack with the Right. \nEnter 3 to Split. ");
            string x = Console.ReadLine();
            x.Replace(" ", "");
            return x;
        }
        static string PlayerDef()
        {
            Console.Write("\nEnter 1 to Attack the Left. \nEnter 2 to Attack the Right. ");
            string x = Console.ReadLine();
            x.Replace(" ", "");
            return x;
        }
        static void Display()
        {
            if (AIL == 0 && AIR == 0)
            {
                Console.WriteLine("YOU WIN!!!!");
                playing = false;
            }
            else if (PL == 0 && PR == 0)
            {
                Console.WriteLine("You Lose :(");
                playing = false;
            }
            Console.WriteLine("\n\n Computer Left = " + AIL + " ||||| Computer Right = " + AIR);
            Console.WriteLine("   Player Left = " + PL + " ||||| Player Right = " + PR);
        }
        static int Calc(int Attack, int Deffend)
        {
            Deffend += Attack;

            if (Deffend >= 5)
            {
                return 0; 
            }
            else
            {
                return Deffend;
            }
        }
        static int AIcansplit()
        {
            if ((PL == 0 && AIL + PR >= 5) || (PL == 0 && AIR + PR >= 5))
            {
                if (AIL > AIR)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
            else if ((PR == 0 && AIL + PL >= 5) || (PR == 0 && AIR + PL >= 5))
            {
                if (AIL > AIR)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
            else if (AIL == 0 && AIR >= 2)
            {
                Console.WriteLine("AIsplit");
                return 1;
            }
            else if (AIR == 0 && AIL >= 2)
            {
                Console.WriteLine("AIsplit");
                return 2;
            }
            else
            {
                return 3;
            }
        }
        
        static void AIattack()
        {
            if (AIL + PL >= 5)
            {
                PL = Calc(AIL, PL);
                Console.WriteLine("AI attacked your Left with his left");
            }
            else if (AIL + PR >= 5)
            {
                PR = Calc(AIL, PR);
                Console.WriteLine("AI attacked you right with his left");
            }
            else if (AIR + PL >= 5)
            {
                PL = Calc(AIR, PL);
                Console.WriteLine("AI attacked your left with his right");
            }
            else if (AIR + PR >= 5)
            {
                PR = Calc(AIR, PR);
                Console.WriteLine("AI attacked your right with his right");
            }
            else if (AIL + PL + AIL < 5 && AIL + PL + AIR < 5 && PL != 0 && AIL != 0)
            {
                PL = Calc(AIL, PL);
                Console.WriteLine("AI attacked your left with his left");
            }
            else if (AIR + PL + AIL < 5 && AIR + PL + AIR < 5 && PL != 0 && AIR != 0)
            {
                PL = Calc(AIR, PL);
                Console.WriteLine("AI attacked your left with his right");
            }
            else if (AIL + PR + AIL < 5 && AIL + PR + AIR < 5 && PR != 0 && AIL != 0)
            {
                PR = Calc(AIL, PR);
                Console.WriteLine("AI attacked your right with his left");
            }
            else if (AIR + PR + AIL < 5 && AIR + PR + AIR < 5 && PR != 0 && AIR != 0)
            {
                PR = Calc(AIR, PR);
                Console.WriteLine("AI attacked your right with his right");
            }
            else if (AIL > 0)
            {
                if (PL > 0)
                {
                    PL = Calc(AIL, PL);
                    Console.WriteLine("AI attacked your Left with his left");
                }
                else
                {
                    PR = Calc(AIL, PR);
                    Console.WriteLine("AI attacked your right with his left");
                }
            }
            else
            {
                if (PL > 0)
                {
                    PL = Calc(AIR, PL);
                    Console.WriteLine("AI attacked your Left with his right");
                }
                else
                {
                    PR = Calc(AIR, PR);
                    Console.WriteLine("AI attacked your right with his right");
                }
            }
        }
        static void AISplit()
        {
            if (AIL == 0)
            {
                if (AIR == 2)
                {
                    AIL = 1;
                    AIR = 1;
                }
                else if (AIR == 3)
                {
                    AIL = 1;
                    AIR = 2;
                }
                else if (AIR == 4)
                {
                    AIL = 2;
                    AIR = 2;
                }
                else
                {
                    Console.WriteLine("***********************************************************************");
                    Console.WriteLine("GLITCH");
                    Console.WriteLine("***********************************************************************");
                }
            }
            else if (AIR == 0)
            {
                if (AIL == 2)
                {
                    AIL = 1;
                    AIR = 1;
                }
                else if (AIL == 3)
                {
                    AIR = 1;
                    AIL = 2;
                }
                else if (AIL == 4)
                {
                    AIL = 2;
                    AIR = 2;
                }
                else
                {
                    Console.WriteLine("***********************************************************************");
                    Console.WriteLine("GLITCH");
                    Console.WriteLine("***********************************************************************");
                }
            }
            else
            {
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("GLITCH");
                Console.WriteLine("***********************************************************************");
            }
            
        }
        static void PlayerSplit()
        {
            if (PL == 0)
            {
                if (PR == 2)
                {
                    PL = 1;
                    PR = 1;
                }
                else if (PR == 3)
                {
                    PL = 1;
                    PR = 2;
                }
                else if (PR == 4)
                {
                    PL = 2;
                    PR = 2;
                }
                else
                {
                    Console.WriteLine("***********************************************************************");
                    Console.WriteLine("GLITCH");
                    Console.WriteLine("***********************************************************************");
                }
            }
            else if (PR == 0)
            {
                if (PL == 2)
                {
                    PL = 1;
                    PR = 1;
                }
                else if (PL == 3)
                {
                    PR = 1;
                    PL = 2;
                }
                else if (PL == 4)
                {
                    PL = 2;
                    PR = 2;
                }
                else
                {
                    Console.WriteLine("***********************************************************************");
                    Console.WriteLine("GLITCH");
                    Console.WriteLine("***********************************************************************");
                    PlayersTurn();
                }
            }
            else
            {
                Console.WriteLine("You can not split at this point");
                PlayersTurn();
            }
        }
    }
}
