using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            FIRST_LETTER_NOT_CAPITAL,
            STRING_LENGTH_NOT_MATCHED,
            NULL_MESSAGE,
            INVALID_PASSOWRD,
            INVALID_CODE

        }
        private readonly ExceptionType type;
        public UserRegistrationException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}

