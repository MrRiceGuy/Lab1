// See https://aka.ms/new-console-template for more information

bool userContinues = true;

while (userContinues)
{
    Console.WriteLine("Hello, please enter your name.");

    string userName = Console.ReadLine();


    Console.WriteLine($"Ok {userName},please input a number between 1 and 100.");

    int userInput = Int32.Parse(Console.ReadLine());
    if (userInput > 100 || userInput < 0)
    {
        Console.WriteLine($"That is an invalid number {userName}. Please try again.");
        continue;
    }

        if (userInput % 2 == 0)
        {

            if (userInput < 25)
            {
                Console.WriteLine($"Even and less than 25, {userName}.");
            }
            if (userInput > 25 && userInput < 60)
            {
                Console.WriteLine("Even");
            }
            if (userInput > 60)
            {
                Console.WriteLine($"The number {userInput} is even {userName}.");
            }
        }
        else
        {
            Console.WriteLine($"The number {userInput} is odd {userName}.");
        }

    Console.WriteLine($"Would you like to continue {userName}? Y or N?");
    string userAnswer = Console.ReadLine().ToLower();

        if(userAnswer == "n")
        {
            userContinues = false;
            Console.WriteLine($"Goodbye {userName}.");
            break;
        }
}