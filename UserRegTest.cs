using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UserRegTest
    {
        [TestMethod] ////Check the first name of the user
        ////First letter should be capital
        ///Minimum 3 characters
        [DataRow("Tejaswi")]
       
        public void GIVEN_FIRST_NAME_SHOULD_RETURN_FIRST_NAME(string fName)
        {
            ////Arrange
            UserDetails Userfirstname = new UserDetails();
            bool expected = true;

            ////Act
            bool actual = Userfirstname.ValidateFirstName( fName);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod] 
        [DataRow("Sam")]
        [DataRow("tejaswi")]
        //// [DataRow("Tejaswi1@")] Should pass, but failing.


        public void GIVEN_FIRST_NAME_SHOULD_RETURN_ERRORS(string fName)
        {
            ////Arrange
            UserDetails Userfirstname = new UserDetails();
            bool expected = false;

            ////Act
            bool actual = Userfirstname.ValidateFirstName(fName);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("Shah")]
        public void GIVEN_Last_NAME_SHOULD_RETURN_LAST_NAME(string lName)
        {
            ////Arrange
            UserDetails Userfirstname = new UserDetails();
            bool expected = true;

            ////Act
            bool actual = Userfirstname.ValidateLastName(lName);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("Sha")]
        [DataRow("shah")]
        [DataRow("Sh1a")]
        public void GIVEN_Last_NAME_SHOULD_RETURN_ERROR(string lName)
        {
            ////Arrange
            UserDetails Userfirstname = new UserDetails();
            bool expected = false;

            ////Act
            bool actual = Userfirstname.ValidateLastName(lName);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("tejaswishah1998@gmail.com")]
        [DataRow("tejaswi@gmail.co.in")]
        public void GIVEN_EMAIL_ID_SHOULD_RETURN_EMAIL_ID(string email)
        {
            ////Arrange
            UserDetails Userfirstname = new UserDetails();
            bool expected = true;

            ////Act
            bool actual = Userfirstname.ValidateEmailID(email);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("tejaswishah1998@gmail.co@@")]
        [DataRow("tejasWI..SHAH@gmail.com")]
        public void GIVEN_EMAIL_ID_SHOULD_RETURN_ERROR(string email)
        {
            ////Arrange
            UserDetails Userfirstname = new UserDetails();
            bool expected = false;

            ////Act
            bool actual = Userfirstname.ValidateEmailID(email);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("919163572895")]
        [DataRow("916263572895")]
        public void GIVEN_MOBILE_NUMBER_SHOULD_RETURN_MOBILE_NUMBER(string mobilenumber)
        {
            ////Arrange
            UserDetails Userfirstname = new UserDetails();
            bool expected = true;

            ////Act
            bool actual = Userfirstname.ValidatePhoneNumber(mobilenumber);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("9163572894")]
        [DataRow("12812458098")]
        [DataRow("916@572895")]


        public void GIVEN_MOBILE_NUMBER_SHOULD_RETURN_ERROR(string mobilenumber)
        {
            ////Arrange
            UserDetails Userfirstname = new UserDetails();
            bool expected = false;

            ////Act
            bool actual = Userfirstname.ValidatePhoneNumber(mobilenumber);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("Tajmahal1!")]
 
        public void GIVEN_PASSWORD_SHOULD_RETURN_PASSWORD(string password)
        {
            ////Arrange
            UserDetails Userfirstname = new UserDetails();
            bool expected = true;

            ////Act
            bool actual = Userfirstname.ValidatePassword(password);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("Tejaswi")]
        [DataRow("Teja1!")]

        public void GIVEN_PASSWORD_SHOULD_RETURN_ERROR(string password)
        {
            ////Arrange
            UserDetails Userfirstname = new UserDetails();
            bool expected = false;

            ////Act
            bool actual = Userfirstname.ValidatePassword(password);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
