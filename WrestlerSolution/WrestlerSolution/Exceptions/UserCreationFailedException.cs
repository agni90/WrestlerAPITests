using System;

namespace WrestlerSolution.Exceptions
{
    public class UserCreationFailedException : Exception
    {
        public UserCreationFailedException(string message) : base(message)
        { }
    }
}
