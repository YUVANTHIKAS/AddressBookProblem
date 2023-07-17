using System;
using static AddressBookProblem.AddressBook;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Problem Statement");
            CreateAddressBook book = new CreateAddressBook();
            book.CreateContact();


        }
    }
}
