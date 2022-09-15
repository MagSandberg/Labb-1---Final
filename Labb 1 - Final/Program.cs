using System;
using System.Buffers;
using System.Linq;

Console.WriteLine("Skriv en tecken-sträng: ");
string userInput = Console.ReadLine();

// Long för att addera alla sekvenser
long sum = 0;

// Iterar genom userArray och letar upp sekvenser som sedan skrivs ut.
for (int i = 0; i < userInput.Length; i++)
{
    // Platshållar-array för att kontrollera värdena mot userInput.
    char[] sequence = new char[userInput.Length];
    if (char.IsDigit(userInput[i]))
    {
        sequence[i] = userInput[i];
        for (int j = i + 1; j < userInput.Length; j++)
        {
            if (char.IsDigit(userInput[j]))
            {
                sequence[j] = userInput[j];
                //OM siffran [i] är lika med siffran [j] har vi hittat en sekvens
                if (userInput[i] == userInput[j])
                {
                    // Sträng för att kunna parsa till long.
                    string sequenceToLong = "";
                    //Loop för att skriva ut sekvenser i annan färg samt resten av userInput
                    for (int k = 0; k < userInput.Length; k++)
                    {
                        if (userInput[k] == sequence[k])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(sequence[k]);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            sequenceToLong += sequence[k];
                        }
                        else
                        {
                            Console.Write(userInput[k]);
                        }
                    }
                    Console.WriteLine();

                    //Adderar alla sekvenser
                    sum += long.Parse(sequenceToLong);
                    break;
                }
            }
            else
            {
                break;
            }
        }
    }
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"\nSumman av alla sekvenser: {sum}");
Console.ForegroundColor = ConsoleColor.Gray;