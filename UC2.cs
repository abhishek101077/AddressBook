﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAddress_Book
{
    public class UC2
    {
        List<Contact> con = new List<Contact>();
        Contact obj = new Contact();
        public void solution()
        {
            Console.WriteLine("Enter First Name: ");
            obj.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            obj.lastName = Console.ReadLine();

            Console.WriteLine("Enter Your MobileNumber: ");
            obj.mobileNumber = Console.ReadLine();

            Console.WriteLine("Enter Your Address: ");
            obj.address = Console.ReadLine();

            Console.WriteLine("Enter Your City: ");
            obj.city = Console.ReadLine();

            Console.WriteLine("Enter  Your State: ");
            obj.state = Console.ReadLine();

            Console.WriteLine("Enter Your Zip: ");
            obj.zip = Console.ReadLine();

            Console.WriteLine("Enter Your Email Id: ");
            obj.email = Console.ReadLine();

            con.Add(obj);
        }
        public void DisplayContact()
        {

            foreach (var change in con)
            {
                Console.WriteLine(change.ToString());
            }
            Console.WriteLine("!!!!!!Welcome to Adress Book Program!!!!!!");
            Console.WriteLine(" ");
            UC2 person = new UC2();
            Console.WriteLine("Do you want to add new contact YES(1) or NO(0)");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Please add new contact details: ");
                        person.solution();
                        person.DisplayContact();
                        break;
                    }
                case 0:
                    {
                        Console.WriteLine("press any key for exit:");
                        break;
                    }
            }
        }
    }
}

