using System;

namespace Tecactus.Api.Exception
{
    class UnauthenticatedException : System.Exception
    {
        public UnauthenticatedException()
        {
        }

        public UnauthenticatedException(string message)
        : base(message)
        {
        }

        public UnauthenticatedException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
