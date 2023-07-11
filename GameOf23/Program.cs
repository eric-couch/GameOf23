namespace GameOf23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game of 23!");

            Console.Write("Enter Player 1 name: ");
            string? playerName = Console.ReadLine();
            int toothpicks = 23;
            do
            {
                Console.Write("Select 1-3 toothpicks (Q to quit):");
                string userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int _numOfToothpicks) && _numOfToothpicks >= 1 && _numOfToothpicks <= 3)
                {
                    if (_numOfToothpicks < toothpicks)
                    {
                        toothpicks -= _numOfToothpicks;
                        Console.WriteLine($"number of toothpicks left: {toothpicks}");
                    } else if (_numOfToothpicks > toothpicks)
                    {
                        Console.WriteLine("that's too many.  there aren't that many left.");
                    } else
                    {
                        Console.WriteLine("You lost!");
                    }
                    Random rnd = new Random();
                    int computerTurn = rnd.Next(1, Math.Min(3, toothpicks+1));
                    toothpicks -= _numOfToothpicks;
                    Console.WriteLine($"Computer selects: {computerTurn}");
                    Console.WriteLine($"Toothpicks left: {toothpicks}");
                    if (toothpicks < 1)
                    {
                        Console.WriteLine("Computer loses!!!");
                    }
                } else if (userInput.ToUpper() != "Q")
                {
                    Console.WriteLine("Bad input try again.");
                } else
                {
                    break;
                }
                
            } while (toothpicks > 0);
        }
    }
}