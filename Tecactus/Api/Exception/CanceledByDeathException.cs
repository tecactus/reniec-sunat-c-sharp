using System;

namespace Tecactus.Api.Exception
{
    class CanceledByDeathException : System.Exception
    {
        public CanceledByDeathException()
        {
        }

        public CanceledByDeathException(string message)
        : base(message)
        {
        }

        public CanceledByDeathException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
