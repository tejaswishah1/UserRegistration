using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class UserDetails
    {
        public string FirstName = "^[A-Z][a-z]{3,}?";
        public bool ValidateFirstName(string fName)
        {
            return Regex.IsMatch(fName, FirstName);
        }
        public string LastName = "^[A-Z][a-z]{3,}?";
        public bool ValidateLastName(string lName)
        {
            return Regex.IsMatch(lName, LastName);
        }
        public string EmailID = "^[a-zA-Z0-9]{3,}(.[a-zA-Z0-9]{1,}){0,}@[a-z]{2,}[.]{1}[a-z]{2,3}(.[a-z]{2,3}){0,}$";
        

        public bool ValidateEmailID(string email)
        {
            return Regex.IsMatch(email, EmailID);
        }
        public string MobileNumber = "^[9][1][6-9][0-9]{9}";

        public bool ValidatePhoneNumber(string mobilenumber)
        {
            return Regex.IsMatch(mobilenumber, MobileNumber);
        }
        public string Password = "((?=^.*[0-9].*$)(?=^.*[A-Z].*$)(?=^[a-zA-Z0-9]*[!@#$%&*+_]{1}[a-zA-Z0-9]*$).{8,})";
 
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Password);
        }

    }
}
