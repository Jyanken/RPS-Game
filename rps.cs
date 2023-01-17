using Internal;
using System;
class rps {
    public static void Main(string[] args)
    {
        // construct varaibles and call ther random class for the program
        String userChoice;
        int computerChoice;
        Random rand = new Random();

        // create the varaibles that will store the number of times the user and computer have won
        int userWins = 0;
        int comuputerWins = 0;

        // create the for loop that plays 5 games
        for(int i = 0; i < 5; i++) {

            // ask the user to make a selection
            Console.WriteLine("Please select Rock, Paper, or Scissors.");
            userChoice = Console.ReadLine();

            // change the user's input into a substring and make sure its uppercase
            // * the user's input should be changed to "R," "P," or "S".
            String userLetter = userChoice.Substring(0, 1).ToUpper();

            // set the varaible from earlier, computerChoice, to a randomly generated number between
            // 1 and 3. then, assign a string value of "R," "P," or "S" to a new string computerLetter.
            String computerLetter;
            computerChoice = rand.Next(1, 4);
            if (computerChoice == 1) {
                computerLetter = "R";
            } else if (computerChoice == 2) {
                computerLetter= "P";
            } else {
                computerLetter = "S";
            }
            Console.WriteLine();
            
            // create an if else statement that decides who is the winner of each match
            if (computerLetter.Equals(userLetter)) {
                Console.WriteLine("Tie!");
            } else if (computerLetter.Equals("R") && userLetter.Equals("S") || computerLetter.Equals("S") && userLetter.Equals("P") || computerLetter.Equals("P") && userLetter.Equals("R")) {
                Console.WriteLine("The computer has won this round!");
                comuputerWins++;
            } else if (userLetter.Equals("R") && computerLetter.Equals("S") || userLetter.Equals("S") && computerLetter.Equals("P") || userLetter.Equals("P") && computerLetter.Equals("R")) {
                Console.WriteLine("You have won this round!");
                userWins++;
            }
            Console.WriteLine();
        }

        // decide the overall winner and print all results
        Console.WriteLine();
        Console.WriteLine("Results");
        Console.WriteLine("Number of times the computer won: " + comuputerWins);
        Console.WriteLine("Number of times you won: " + userWins);

        if (userWins > comuputerWins) {
            Console.WriteLine("You are the overall winner!");
        } else if (userWins < comuputerWins) {
            Console.WriteLine("The computer is the overall winner!");
        } else {
            Console.WriteLine("There is no clear winner! Its a tie!");
        }

        Console.WriteLine();
        Console.WriteLine("Press ENTER to close this window.");
        Console.ReadLine();
    }
    
}