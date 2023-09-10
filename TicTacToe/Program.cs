using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    internal class Program
    {
        static bool isWinner = false;
        static int player = 2;
        static string[,] numbArrs = {
            {"1","2","3" },
            {"4","5","6" },
            {"7","8","9" },
        };
        static string[,] numbArrsident = {
            {"1","2","3" },
            {"4","5","6" },
            {"7","8","9" },
        };
        static void Main(string[] args)
        {



           
            bool correctInp = true;
            


            
            do
            {
                int turns = 0;
                Console.WriteLine("Press Any Key To Start: ");
                Console.ReadKey();
                DrawPlayField();
                do
                {
                    Console.WriteLine("Choose Your Place: ");
                    string userInp = Console.ReadLine();
                    if (player == 2 && !string.IsNullOrEmpty(userInp) && int.TryParse(userInp, out int intUserInp) && intUserInp > 0 && intUserInp<= 9)
                    {
                        XOrOInput(player, userInp, out correctInp);
                        if (correctInp)
                        {
                            DrawPlayField();
                            turns++;
                            player = 1;
                        }else
                        {
                            Console.WriteLine("Incorrect Input!!!");
                        }

                    }
                    else if (player == 1)
                    {
                        XOrOInput(player, userInp, out correctInp);
                        if (correctInp)
                        {
                            DrawPlayField();
                            turns++;
                            player = 2;
                        }else
                        {
                            Console.WriteLine("Incorrect Input!!! ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!! ");
                    }

                    if ((numbArrs[0, 0] == numbArrs[0,1] && numbArrs[0,1] == numbArrs[0,2]) || (numbArrs[1, 0] == numbArrs[1, 1] && numbArrs[1, 1] == numbArrs[1, 2]) 
                        || (numbArrs[2,0] == numbArrs[2,1] && numbArrs[2,1] == numbArrs[2,2]) || (numbArrs[0,0] == numbArrs[1,0] && numbArrs[1,0] == numbArrs[2,0]) 
                        || (numbArrs[0,1] == numbArrs[1,1] && numbArrs[1, 1] == numbArrs[2,1]) || (numbArrs[0,2] == numbArrs[1,2] && numbArrs[1,2] == numbArrs[2,2])
                        || (numbArrs[0,0] == numbArrs[1,1] && numbArrs[1,1] == numbArrs[2,2]) || (numbArrs[0,2] == numbArrs[1,1] && numbArrs[1,1] == numbArrs[2,0]))
                    {
                        isWinner = true;
                        break;
                    }
                   
                } while (turns < 9);
                Console.WriteLine("Game Over!");
                string winnerStr;
                if (isWinner)
                {
                    if(player == 2)
                    {
                        winnerStr = "O";
                    }
                    else if (player == 1)
                    {
                        winnerStr = "X";

                    } 
                    else
                    {
                        winnerStr = Convert.ToString(player);
                    }
                    {
                        Console.WriteLine($"We Have Winner, Player {winnerStr} Has Won");
                    }
                    
                }
                else
                {
                    Console.WriteLine("The Game Is Tied");
                }
                numbArrs = numbArrsident;
                player = 2;
                
            } while (true);

        }

        static void DrawPlayField()
        {
            Console.Clear();
            Console.WriteLine("      |     |   ");
            Console.WriteLine($"   {numbArrs[0, 0]}  |  {numbArrs[0, 1]}  |  {numbArrs[0, 2]}  ");
            Console.WriteLine("______|_____|_____");
            Console.WriteLine("      |     |   ");
            Console.WriteLine($"   {numbArrs[1, 0]}  |  {numbArrs[1, 1]}  |  {numbArrs[1, 2]}  ");
            Console.WriteLine("______|_____|_____");
            Console.WriteLine("      |     |   ");
            Console.WriteLine($"   {numbArrs[2, 0]}  |  {numbArrs[2, 1]}  |  {numbArrs[2, 2]}  ");
            Console.WriteLine("______|_____|_____");

        }

        static void XOrOInput(int player, string userInp, out bool inpValidation)
        {
            string inp = "";
            bool notValidInp;

            if (player == 2)
            {
                inp = "X";
                UserInpCases(userInp, inp, out notValidInp);

            }
            else if (player == 1)
            {
                inp = "O";
                UserInpCases(userInp, inp, out notValidInp);
            }else
            {
                notValidInp = false;
            }
            inpValidation = notValidInp;
        }

        static void UserInpCases(string userInp, string replcInp, out bool ValidInp)
        {
            
            
            if(userInp == "1" && numbArrs[0,0] == "1")
            {
               numbArrs[0, 0] = replcInp;
                ValidInp = true;
            }
            else if(userInp == "2" && numbArrs[0, 1] == "2")
            {
                numbArrs[0, 1] = replcInp;
                ValidInp = true;
            }
            else if (userInp == "3" && numbArrs[0, 2] == "3")
            {
                numbArrs[0, 2] = replcInp;
                ValidInp = true;
            }
            else if (userInp == "4" && numbArrs[1, 0] == "4")
            {
                numbArrs[1, 0] = replcInp;
                ValidInp = true;
            }
            else if (userInp == "5" && numbArrs[1, 1] == "5")
            {
                numbArrs[1, 1] = replcInp;
                ValidInp = true;
            }
            else if (userInp == "6" && numbArrs[1, 2] == "6")
            {
                numbArrs[1, 2] = replcInp;
                ValidInp = true;
            }
            else if (userInp == "7" && numbArrs[2, 0] == "7")
            {
                numbArrs[2, 0] = replcInp;
                ValidInp = true;
            }
            else if (userInp == "8" && numbArrs[2, 1] == "8")
            {
                numbArrs[2, 1] = replcInp;
                ValidInp = true;
            }
            else if (userInp == "9" && numbArrs[2, 2] == "9")
            {
                numbArrs[2, 2] = replcInp;
                ValidInp = true;
            }
            else
            {
                ValidInp = false;

            }
        }


     }
}
