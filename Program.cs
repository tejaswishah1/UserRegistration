using System;
using System.Threading;


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


        }
    }
}
