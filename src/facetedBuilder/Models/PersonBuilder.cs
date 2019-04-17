namespace facetedBuilder.Models
{
    public class PersonBuilder
    {
        protected Person person = new Person();
        public PersonAddresBuilder Lives => new PersonAddresBuilder(person);
        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }
}