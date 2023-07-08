﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAddress_Book
{
     public class Contact
    {
        //Create contact
        public string firstName;
        public string lastName;
        public string mobileNumber;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string email;
        public override string ToString()
        {
            return $"First Name: {firstName}," + $" Last Name: {lastName}, Mobile Number: {mobileNumber}, Address: {address}, City: {city}, State: {state}, Zip: {zip}, Email: {email}";
        }

    }
}
