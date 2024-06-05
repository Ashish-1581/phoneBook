// See https://aka.ms/new-console-template for more information

using System;
namespace phoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the consoleph phonebook app");
            Console.WriteLine("select options");
            Console.WriteLine("1. Add contacts");
            Console.WriteLine("2. Display contact by number");
            Console.WriteLine("3. view all contacts");
            Console.WriteLine("4. searchfor for contactsfor a given  name");
            Console.WriteLine("Press 'x' to exit");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while(true)
            {
                switch (userInput)
                {
                    case "1":

                        Console.WriteLine("Contact name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number:");
                        var number = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Contact number to search:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;
                    case "3":
                        phoneBook.DisplayAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Name search phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return; 
                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }
                Console.WriteLine("Select Opertaion");
                userInput = Console.ReadLine();

            }

            
        }
    }
}
