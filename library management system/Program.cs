using System;
using System.Collections.Generic;

class LibraryManagementSystem
{
    // Define the library with a maximum of 5 book titles
    static List<string> library = new List<string>();

    // Function to add a book
    static void AddBook(string title)
    {
        if (library.Count < 5)
        {
            library.Add(title);
            Console.WriteLine($"\"{title}\" has been added to the library.");
        }
        else
        {
            Console.WriteLine("The library is full. Cannot add more books.");
        }
    }

    // Function to remove a book
    static void RemoveBook(string title)
    {
        if (library.Remove(title))
        {
            Console.WriteLine($"\"{title}\" has been removed from the library.");
        }
        else
        {
            Console.WriteLine($"\"{title}\" is not in the library.");
        }
    }

    // Function to display all books
    static void DisplayBooks()
    {
        if (library.Count > 0)
        {
            Console.WriteLine("Books currently in the library:");
            foreach (string book in library)
            {
                Console.WriteLine($"- {book}");
            }
        }
        else
        {
            Console.WriteLine("The library is empty.");
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Remove a Book");
            Console.WriteLine("3. Display Books");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter the book title: ");
                string title = Console.ReadLine();
                AddBook(title);
            }
            else if (choice == "2")
            {
                Console.Write("Enter the book title to remove: ");
                string title = Console.ReadLine();
                RemoveBook(title);
            }
            else if (choice == "3")
            {
                DisplayBooks();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting the system. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}