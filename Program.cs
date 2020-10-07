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
                Console.WriteLine("Your First Name is {0}", Firstname);
            }

        }
    }
}
