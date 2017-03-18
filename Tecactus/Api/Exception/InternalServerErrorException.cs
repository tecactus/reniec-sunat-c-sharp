using System;

namespace Tecactus.Api.Exception
{
    class InternalServerErrorException : System.Exception
    {
        public InternalServerErrorException()
        {
        }

        public InternalServerErrorException(string message)
        : base(message)
        {
        }

        public InternalServerErrorException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
