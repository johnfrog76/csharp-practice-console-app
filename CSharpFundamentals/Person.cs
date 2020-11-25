using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            var formatted = string.Format(
                "My name is {0} {1}",
                FirstName,
                LastName
            );

            Console.WriteLine(formatted);
        }
    }
}
