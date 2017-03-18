using System;

namespace Tecactus.Api.Exception
{
    class InvalidDniException : System.Exception
    {
        public InvalidDniException()
        {
        }

        public InvalidDniException(string message)
        : base(message)
        {
        }

        public InvalidDniException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
