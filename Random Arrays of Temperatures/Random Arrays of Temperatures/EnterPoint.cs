using System;

namespace Random_Arrays_of_Temperatures
{
class EnterPoint
{
    static void Main(string[] args)
    {

            Random rng = new Random();
            int[] temperatures = new int[40];
            int[] lowTemps = new int[temperatures.Length];
            int[] mediumTemps = new int[temperatures.Length];
            int[] highTemps = new int[temperatures.Length];
            int[] outOfRangeTemps = new int[temperatures.Length];

            int lowTempIndex = 0;
            int mediumTempIndex = 0;
            int highTempIndex = 0;
            int outOfRangeIndex = 0;
            int lowTempCursorPosition = 2;
            int mediumTempCurosorPosition = 2;
            int highTempCurosorPosition = 2;
            int outOfRangeTempCurosorPosition = 2;


            Console.Write("Range 1 to 10: " + 
                "\n" + 
                "\n Range 11 to 20: " + 
                "\n" + 
                "\n Range 21 to 30:" +
                "\n" + 
                "\n Out Of Range" + 
                "\n\n");

            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = rng.Next(0, 40);
            }

            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[lowTempIndex] >= 1 && temperatures[i] <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(lowTempCursorPosition, 1);
                    Console.Write($"{temperatures[i]}");
                    Console.ResetColor();
                    lowTemps[i] = temperatures[i];
                    lowTempIndex++;
                    if (temperatures[i] == 10)
                    {
                        lowTempCursorPosition += 3;
                    }
                    else
                    {
                        lowTempCursorPosition += 2;
                    }
                }
                else if (temperatures[i] >= 11 && temperatures[i] <= 20)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(mediumTempCurosorPosition, 3);
                    Console.Write($"{temperatures[i]}");
                    Console.ResetColor();
                    mediumTemps[mediumTempIndex] = temperatures[i];
                    mediumTempIndex++;
                    mediumTempCurosorPosition += 3;
                }
                else if (temperatures[i] >= 21 && temperatures[i] <= 30)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(highTempCurosorPosition, 5);
                    Console.Write($"{temperatures[i]}");
                    Console.ResetColor();
                    highTemps[highTempIndex] = temperatures[i];
                    highTempIndex++;
                    highTempCurosorPosition += 3;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(outOfRangeTempCurosorPosition, 7);
                    Console.Write($"{temperatures[i]}");
                    Console.ResetColor();
                    outOfRangeTemps[outOfRangeIndex] = temperatures[i];
                    outOfRangeIndex++;
                    if (temperatures[i] == 0)
                    {
                        lowTempCursorPosition += 2;
                    }
                    else
                    {
                        lowTempCursorPosition += 3;
                    }
                }
            }
            Console.SetCursorPosition(0, 8);
    }
}
}
