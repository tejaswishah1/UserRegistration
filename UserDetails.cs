﻿using System;
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
    }
}
