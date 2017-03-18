using System;

namespace Tecactus.Api.Exception
{
    class DniUnderageException : System.Exception
    {
        public DniUnderageException()
        {
        }

        public DniUnderageException(string message)
        : base(message)
        {
        }

        public DniUnderageException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
