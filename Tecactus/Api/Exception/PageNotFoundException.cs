using System;

namespace Tecactus.Api.Exception
{
    class PageNotFoundException : System.Exception
    {
        public PageNotFoundException()
        {
        }

        public PageNotFoundException(string message)
        : base(message)
        {
        }

        public PageNotFoundException(string message, System.Exception inner)
        : base(message, inner)
        {
        }
    }
}
