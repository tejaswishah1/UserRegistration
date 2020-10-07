using System;
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
            EnterFirstName:
            Console.WriteLine("Please enter your First Name");
            string Firstname = Console.ReadLine();
            bool check = Details.ValidateFirstName(Firstname);
            if (check == false)
            {
                Console.WriteLine("Invalid input,Please try again. \n First name should start with Capital letter and have minimum 3 alphabets \n");
                goto EnterFirstName;
            }
            else
            {
                Console.WriteLine("Your First Name is {0} \n", Firstname);
            }
            Console.WriteLine("Please enter your Last Name");
            string Lastname = Console.ReadLine();
            check = Details.ValidateLastName(Lastname);
            if (check == false)
            {
                Console.WriteLine("Invalid input,Please try again. \n First name should start with Capital letter and have minimum 3 alphabets \n");
                goto EnterFirstName;
            }
            else
            {
                Console.WriteLine("Your Last Name is {0}", Lastname);
            }
            EnterEmailID:
            Console.Write("Please enter your email ID");
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
            if (check == false)
            {
                Console.WriteLine("Please enter a valid mobile Number");
                Console.WriteLine("Pattern: Country code followed by space and 10 digit phone number");
                    goto EnterMobileNumber;
            }
            else
            {
                Console.WriteLine("Your Mobile number is {0} \n", mobileNumber);
            }
        EnterPassword:

            Console.WriteLine("Please enter your password");
            string PassWord = Console.ReadLine();
            check = Details.ValidatePassword(PassWord);
            if(check == false)
            {
                Console.WriteLine("Please enter a valid password");
                Console.WriteLine("Password must contain at least 8 characters");
                goto EnterPassword;
            }
            else
            {
                Console.WriteLine("Your password is {0} \n", PassWord);
            }




        }
    }
}
