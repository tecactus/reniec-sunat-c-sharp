using System;

namespace Tecactus.Api.Exception
{
    class DniNotFoundException : System.Exception
    {
        public DniNotFoundException()
        {
        }

        public DniNotFoundException(string message)
        : base(message)
        {
        }

        public DniNotFoundException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
