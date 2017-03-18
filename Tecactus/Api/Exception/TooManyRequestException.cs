using System;

namespace Tecactus.Api.Exception
{
    class TooManyRequestException : System.Exception
    {
        public TooManyRequestException()
        {
        }

        public TooManyRequestException(string message)
        : base(message)
        {
        }

        public TooManyRequestException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
