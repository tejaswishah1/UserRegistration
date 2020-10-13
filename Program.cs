using System;
using System.Linq.Expressions;
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
            bool check = Details.ValidateFirstName(Firstname);
            bool result;
            result = Char.IsUpper(Firstname, 0);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.FIRST_LETTER_NOT_CAPITAL, "Kindly make the first letter of string capital");
                    
                }
               else if (Firstname.Length < 4)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.STRING_LENGTH_NOT_MATCHED, "Name should be more than 3 characters");
                }
              else  if (Firstname.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "Please enter a value");
                }
                else
                {
                    Console.WriteLine("Your First Name is {0} \n", Firstname);
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception : {0}", ex.Message);
            }
          
           
            
            
          
            Console.WriteLine("Please enter your Last Name");
            string Lastname = Console.ReadLine();
            check = Details.ValidateLastName(Lastname);
            result = Char.IsUpper(Lastname, 0);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.FIRST_LETTER_NOT_CAPITAL, "Kindly make the first letter of string capital");

                }
                else if (Lastname.Length < 4)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.STRING_LENGTH_NOT_MATCHED, "Name should be more than 3 characters");
                }
                else if (Lastname.Equals(string.Empty))
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


        EnterEmailID:
            Console.Write("Please enter your email ID \n");
            string Emailid = Console.ReadLine();
            check = Details.ValidateEmailID(Emailid);
            if (check == false)
            {
                Console.WriteLine("Enter a valid Email ID");
                Console.WriteLine("Email Address should be in the format abc.xyz@bl.co.in where xyz and in are optional");
                goto EnterEmailID;
            }

        else
            {
                Console.WriteLine("Your Email ID is {0}", Emailid);

            }
        EnterMobileNumber:

            Console.WriteLine("Please Enter your mobile number");
            string mobileNumber = Console.ReadLine();
            check = Details.ValidatePhoneNumber(mobileNumber);
            try
            {
                if (mobileNumber.Length < 11)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.STRING_LENGTH_NOT_MATCHED, "Phone number should be at least 12 characters");
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
            check = Details.ValidatePassword(PassWord);
            if(check == false)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSOWRD, "Passowrd should contain one character,one upper case,one lower case and numericals, and should be 8 characters at least");
            }
            else
            {
                Console.WriteLine("Your password is {0} \n", PassWord);
            }




        }
    }
}
