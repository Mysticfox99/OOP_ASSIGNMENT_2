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
            //Get the lenght of the array
            int length = user_input_array.Length;
            //A while loop to check if the length is less or equal to 3
            while (length <= 3)
            {
                try
                {                                                  
                    bool diff_check = false; //set the diff check as false
                    while (!diff_check) //A while loop so the user uses diff instead of anything else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; //Change the input box to yellow
                        Console.Write("[INPUT]: "); //Display the input box
                        Console.ForegroundColor = ConsoleColor.White; //Change the colour of text back to white
                        string user_input = Console.ReadLine(); // read the user input line
                        user_input_array = user_input.Split(" "); //Split users input   
                        if (user_input_array[0] == "diff") //If user inputted diff, then proceed
                        {
                            diff_check = true;
                            //Define the files the user has chosen
                            string file_a = user_input_array[1];
                            string file_b = user_input_array[2];

                            //Open the chosen filess
                            string open_file_a = File.ReadAllText(file_a);
                            string open_file_b = File.ReadAllText(file_b);

                            //If the two files are the same, tell the user they are the same
                            if (open_file_a == open_file_b)
                            {
                                Console.ForegroundColor = ConsoleColor.Green; //Change text colour to green for the output box
                                Console.Write("[Output]: ");
                                Console.ForegroundColor = ConsoleColor.White; //Change the text colour to white for the rest of the text
                                Console.WriteLine($"{user_input_array[1]} and {user_input_array[2]} are the same");

                            }
                            //If the files are different, tell the user that they are diifferent
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red; //Change text colour to red for the output box
                                Console.Write("[Output]: ");
                                Console.ForegroundColor = ConsoleColor.White; //Change the text colour to white for the rest of the text
                                Console.WriteLine($"{user_input_array[1]} and {user_input_array[2]} are not the same");
                            }                           
                        }

                        else //If user does not user diff, ask the usser to try again
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please use diff");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }



                }
                //If the files were not found, it asks the user to try again
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
