using Address_Books;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Address_Books
{
    //starting the project
    class MultipleAddressBook
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        public List<Contacts> list = new List<Contacts>();

        public MultipleAddressBook(int id, string name)
        {
            BookId = id;
            BookName = name;
        }
        public void Open(Dictionary<string, List<string>> city, Dictionary<string, List<string>> state)
        {
            try
            {
                Console.WriteLine("Welcome to Address Book !\n");

                while (true)
                {
                    Console.WriteLine("\nEnter 1 -> adding person's contact.");
                    Console.WriteLine("Enter 2 -> edit contact via name.");
                    Console.WriteLine("Enter 3 -> delete contact.");
                    Console.WriteLine("Enter 4 -> display contacts.");
                    Console.WriteLine("Enter 5 -> exiting the addressbook.\n");

                    Console.Write("Enter the choice = ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            int count = list.Count;
                            Console.WriteLine("Adding contact details !");
                            AddDetails.AddDetail(list);
                            if (count != list.Count)
                            {
                                Contacts contacts = list[list.Count - 1];

                                if (city.ContainsKey(contacts.City))
                                {
                                    city[contacts.City].Add(contacts.Firstname + " " + contacts.Lastname);
                                }
                                else
                                {
                                    city[contacts.City] = new List<string>() { contacts.Firstname + " " + contacts.Lastname };
                                }
                                if (state.ContainsKey(contacts.State))
                                {
                                    state[contacts.State].Add(contacts.Firstname + " " + contacts.Lastname);
                                }
                                else
                                {
                                    state[contacts.State] = new List<string>() { contacts.Firstname + " " + contacts.Lastname };
                                }
                                contacts.Display();
                            }
                            break;
                        case 2:
                            if (list.Count > 0)
                                EditDetails.EditingContact(list);
                            else Console.WriteLine("Address book is empty !, please add contacts and then edit!");
                            break;
                        case 3:
                            if (list.Count > 0)
                                DeleteDetails.Deletecontact(list);
                            else Console.WriteLine("Address book is empty !, please add contacts and then delete!");
                            break;

                        case 4:
                            if (list.Count > 0)
                                foreach (Contacts contact in list) contact.Display();
                            else Console.WriteLine("Address book is empty !, please add contacts and then display");


                            break;
                        case 5: return;
                        default:
                            Console.WriteLine("Invalid input, enter value between 1 to 4");
                            break;

                            //everything upto date
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}