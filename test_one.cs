//prompt the user to input their name and birthdate
using System;

using System.IO;
using System.Text.RegularExpressions;


        // Prompt for the user's name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        // Prompt for the user's birthdate
        Console.Write("Please enter your birthdate (MM/DD/YYYY): ");
        string birthdateInput = Console.ReadLine();
        

        // Prompt for the user's name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        // Prompt for the user's birthdate
        Console.Write("Please enter your birthdate (MM/DD/YYYY): ");
        string birthdateInput = Console.ReadLine();

        
        // Validate the birthdate using the regular expression
        if (Regex.IsMatch(birthdateInput))
        {
            Console.WriteLine($"Hello, {name}! Your birthdate is {birthdateInput}.");
        }
        else
        {
            Console.WriteLine("Invalid birthdate format. Please use MM/DD/YYYY.");
        }
    



        // Step 1: Prompt for user's name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        // Step 2: Prompt for user's birthdate
        Console.Write("Please enter your birthdate (MM/DD/YYYY): ");
        string birthdateInput = Console.ReadLine();

      
        // Check if the birthdate is in the correct format
        if (!validBirthdate)
        {
            Console.WriteLine("Invalid birthdate format. Please use MM/DD/YYYY.");
            return;
        }

        //  Calculate and display the user's age
        int age = CalculateAge(birthdate);
        Console.WriteLine($"Hello, {name}! You are {age} years old.");

       

        //  Read and display the contents of the "info.txt" file
        Console.WriteLine("\nContents of info.txt:");
        string fileContent = File.ReadAllText("info.txt");
        Console.WriteLine(fileContent);

        //  Prompt the user to enter a directory path
        Console.Write("\nEnter a directory path to list all files: ");
        string directoryPath = Console.ReadLine();

        //  List all files within the specified directory
        if (Directory.Exists(directoryPath))
        {
            Console.WriteLine($"\nFiles in {directoryPath}:");
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
        else
        {
            Console.WriteLine("The specified directory does not exist.");
        }

        //  Prompt the user to input a string
        Console.Write("\nPlease enter a string: ");
        string userInput = Console.ReadLine();

        // Format the string to 30 characters (truncate or pad to fit exactly 30 characters)
        string formattedString = userInput.PadRight(30).Substring(0, 30);
        Console.WriteLine($"Formatted string to 30 characters: '{formattedString}'");

        // Step 10: Explicitly trigger garbage collection
        GC.Collect();
        Console.WriteLine("\nGarbage collection triggered explicitly.");
    

    // Method to calculate the age of the user based on their birthdate
    static int CalculateAge(DateTime birthdate)
    {
        DateTime today = DateTime.Now;
        int age = today.Year - birthdate.Year;
        if (birthdate > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }

