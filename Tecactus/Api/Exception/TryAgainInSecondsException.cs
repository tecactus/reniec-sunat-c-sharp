using System;

namespace Tecactus.Api.Exception
{
    class TryAgainInSecondsException : System.Exception
    {
        public TryAgainInSecondsException()
        {
        }

        public TryAgainInSecondsException(string message)
        : base(message)
        {
        }

        public TryAgainInSecondsException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
