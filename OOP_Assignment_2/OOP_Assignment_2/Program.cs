using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace OOP_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array with the files a as the choice for the user
            string[] files_a = new string[3];
            files_a[0] = ("GitRepositories_1a.txt");
            files_a[1] = ("GitRepositories_2a.txt");
            files_a[2] = ("GitRepositories_3a.txt");

            //Create an array with the files b as the choice for the user
            string[] files_b = new string[3];
            files_b[0] = ("GitRepositories_1b.txt");
            files_b[1] = ("GitRepositories_2b.txt");
            files_b[2] = ("GitRepositories_3b.txt");

            //Ask the user what file from array a they would like to access
            for (int i = 0; i < files_a.Length; i++)
            {
                Console.WriteLine("Enter {0} to select {1}", i, files_a[i]);
            }

            int file_a_Choice;
            //While loop for the file selection so the user has to select a file
            bool file_a_check = false;
            while (!file_a_check)
            {
                //Read the user input for what file the user wants to use
                string user_file_a_input = Console.ReadLine();
                //If the user input is less than the file choices, then the code should open the file the user selected
                if (int.TryParse(user_file_a_input, out file_a_Choice) && file_a_Choice < files_a.Length)
                {
                    //Open the file that the user selected.
                    string[] open_file_a = File.ReadAllLines(files_a[file_a_Choice]);
                    file_a_check = true;
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    
                    //Ask the user what file from array a they would like to access
                    for (int i = 0; i < files_b.Length; i++)
                    {
                        Console.WriteLine("Enter {0} to select {1}", i, files_b[i]);
                    }

                    int file_b_Choice;
                    //While loop for the file selection so the user has to select a file
                    bool file_b_check = false;
                    while (!file_b_check)
                    {
                        //Read the user input for what file the user wants to use
                        string user_file_b_input = Console.ReadLine();
                        //If the user input is less than the file choices, then the code should open the file the user selected
                        if (int.TryParse(user_file_b_input, out file_b_Choice) && file_b_Choice < files_b.Length)
                        {
                            //Open the file that the user selected.
                            string[] open_file_b = File.ReadAllLines(files_b[file_b_Choice]);
                            file_b_check = true;
                            bool isEqual = open_file_a.SequenceEqual(open_file_b);
                            Console.WriteLine(isEqual);
                        }
                        else
                        {
                            Console.WriteLine("Please try again:");
                        }
                    }


                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }
                else
                {
                    Console.WriteLine("Please try again:");
                }
            }
        }
    }
}
