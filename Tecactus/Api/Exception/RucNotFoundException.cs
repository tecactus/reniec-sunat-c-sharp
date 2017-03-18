using System;

namespace Tecactus.Api.Exception
{
    class RucNotfoundException : System.Exception
    {
        public RucNotfoundException()
        {
        }

        public RucNotfoundException(string message)
        : base(message)
        {
        }

        public RucNotfoundException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
