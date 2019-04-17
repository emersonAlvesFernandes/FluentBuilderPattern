namespace facetedBuilder.Models
{
    public class PersonAddresBuilder : PersonBuilder
    {
        // might not work with a value type!
        public PersonAddresBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddresBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddresBuilder WithPostcode(string postcode)
        {
            person.PostCode = postcode;
            return this;
        }

        public PersonAddresBuilder In(string city)
        {
            person.City = city;
            return this;
        }

    }
}