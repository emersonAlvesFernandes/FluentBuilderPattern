using System;
using facetedBuilder.Models;

namespace facetedBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var pb = new PersonBuilder();

            Person person = pb
                .Lives
                    .At("123 London Road")
                    .In("London")
                    .WithPostcode("SW12BC")
                .Works
                    .At("Fabrikam")
                    .AsA("Engineer")
                    .Earning(123000);

            Console.WriteLine(person.ToString());
        }
    }
}
