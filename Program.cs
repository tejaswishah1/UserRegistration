using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Transactions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            UserDetails Details = new UserDetails();

            Console.WriteLine("Please enter your First Name");
            string Firstname = Console.ReadLine();
            List<string> FirstName = new List<string>() { Firstname };
            try
            {
                if (FirstName.Exists(a => a.Length < 4))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.STRING_LENGTH_NOT_MATCHED, "Name should be more than 3 characters");
                }
                else if (FirstName.Exists(a => a.Equals("")))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "Please enter a value");
                }
                else
                {
                    Console.WriteLine("Your First Name is {0} \n", Firstname);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : {0}", ex.Message);
            }

            Console.WriteLine("Please enter your Last Name");
            string Lastname = Console.ReadLine();
           
            List<string> LastName = new List<string>() { Lastname };
            try
            {
            
            if (LastName.Exists(a => a.Length < 4))
                    {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.STRING_LENGTH_NOT_MATCHED, "Name should be more than 3 characters");
            }
            else if (LastName.Exists(a => a.Equals("")))
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "Please enter a value");
            }
            else
            {
                Console.WriteLine("Your Last Name is {0} \n", Lastname);

            }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : {0}", ex.Message);
            }


            Console.Write("Please enter your email ID \n");
            string Emailid = Console.ReadLine();
            List<string> MailID = new List<string>() { Emailid };
        
            if (MailID.TrueForAll(a=>a.Contains("^[a-zA-Z0-9]{3,}([.][a-zA-Z0-9]*)[@][a-z]{2,}[.][a-z]{2,3}([.][a-z]{2}")))
            {
                Console.WriteLine("Your Email ID is {0}", Emailid);
               
            }

            else
            {
                Console.WriteLine("Enter a valid Email ID");
                Console.WriteLine("Email Address should be in the format abc.xyz@bl.co.in where xyz and in are optional");

            }


            Console.WriteLine("Please Enter your mobile number");
            string mobileNumber = Console.ReadLine();
            List<string> PhoneNumber = new List<string>() { mobileNumber };


            try
            {
                if (PhoneNumber.Exists(a=>a.Length<10))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.STRING_LENGTH_NOT_MATCHED, "Phone number should be at least 12 characters");
                }
                else if (PhoneNumber.Exists(a=>a.Contains("^[1-5][6-9][0-9]{10}")))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_CODE, "You have entered an invalid code");
                }
                else
                {
                    Console.WriteLine("Your mobile number is: {0}", mobileNumber);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }



            Console.WriteLine("Please enter your password");
            string PassWord = Console.ReadLine();
            List<string> Password = new List<string>() { PassWord };
            try
            {
                if (Password.Exists(a => a.Contains("^(?=.*[A-Z])(?=.*[0-9])(?=.[!@#$%^&*:-_]{1}).{8,}?")))
                {
                    Console.WriteLine("Your password is {0} \n", PassWord);
                }
                else
                {

                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSOWRD, "Passowrd should contain one character,one upper case,one lower case and numericals, and should be 8 characters at least");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }



        }
    }
}
