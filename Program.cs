Random random = new Random();
int playerSelection;
bool gameOver = false;
bool playAgain = true;
while (playAgain)
{
    while (!gameOver)
    {
        Console.WriteLine("Select 1 for Rock, 2 for Paper or 3 Scissors");
        playerSelection = Convert.ToInt32(Console.ReadLine());
        int computerSelection = random.Next(1, 4);
        if (playerSelection == 1)
        {
            if (computerSelection == 1)
            {
                Console.WriteLine("You pick rock.... the computer picks rock try again");
            }
            if (computerSelection == 2)
            {
                Console.WriteLine("You pick rock... the computer picks paper. You lose!");
                gameOver = true;
            }
            if (computerSelection == 3)
            {
                Console.WriteLine("You pick rock.... the computer picks scissors. You win!");
                gameOver = true;
            }
        }
        if (playerSelection == 2)
        {
            if (computerSelection == 1)
            {
                Console.WriteLine("You pick paper.... the computer picks rock. You win!");
                gameOver = true;
            }
            if (computerSelection == 2)
            {
                Console.WriteLine("You pick paper... the computer picks paper try again");
            }
            if (computerSelection == 3)
            {
                Console.WriteLine("You pick paper.... the computer picks scissors. You Lose!");
                gameOver = true;
            }
        }
        if (playerSelection == 3)
        {
            if (computerSelection == 1)
            {
                Console.WriteLine("You pick scissors.... the computer picks rock. You Lose!");
                gameOver = true;
            }
            if (computerSelection == 2)
            {
                Console.WriteLine("You pick scissors... the computer picks paper. You win!");
            }
            if (computerSelection == 3)
            {
                Console.WriteLine("You pick scissors.... the computer picks scissors. Try again!");
                gameOver = true;
            }
        }
    }
    Console.WriteLine("Would you like to play again? Enter Y to play again");
    char again = Convert.ToChar(Console.ReadKey());
    if(again != 'y')
    {
        playAgain = false;
    }
}
