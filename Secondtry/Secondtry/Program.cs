using System;
using System.IO;

namespace Secondtry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty string array called user_input_array
            string[] user_input_array = { };
            while (user_input_array.Length != 3 || user_input_array[0] != "diff")
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; //Change the input box to yellow
                    Console.Write("[INPUT]: "); //Display the input box
                    Console.ForegroundColor = ConsoleColor.White; //Change the colour of text back to white

                    string user_input = Console.ReadLine(); // read the user input line
                    user_input_array = user_input.Split(" "); //Split users input

                    //Define the files the user has chosen
                    string file_a = user_input_array[1];
                    string file_b = user_input_array[2];

                    string open_file_a = File.ReadAllText(file_a);
                    string open_file_b = File.ReadAllText(file_b);


                    if (open_file_a == open_file_b)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[Output]: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{user_input_array[1]} and {user_input_array[2]} are the same");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[Output]: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{user_input_array[1]} and {user_input_array[2]} are not the same");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please try again");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FileNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Files were not found, please try again");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

        }
    }
}
