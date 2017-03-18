using System;

namespace Tecactus.Api.Exception
{
    class InvalidRucException : System.Exception
    {
        public InvalidRucException()
        {
        }

        public InvalidRucException(string message)
        : base(message)
        {
        }

        public InvalidRucException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
