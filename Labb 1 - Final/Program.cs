using System;
using System.Buffers;
using System.Linq;

Console.WriteLine("Skriv en tecken-sträng: ");
string userInput = Console.ReadLine();
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
                //OM siffra i är lika med siffra j har vi hittat en sekvens
                if (userInput[i] == userInput[j])
                {
                    string sequenceToLong = "";
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
Console.WriteLine($"Total sum of all sequences: {sum}");