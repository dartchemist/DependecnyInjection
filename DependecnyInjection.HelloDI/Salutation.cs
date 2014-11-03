using System;

namespace DependecnyInjection.HelloDI
{
    public class Salutation
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            this.writer = writer;
        }

        public void Exclaim()
        {
            writer.Write("Hello, DI");
        }
    }
}