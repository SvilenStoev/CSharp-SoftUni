using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public class Person
    {
        private const int MIX_VALUE = 12;
        private const int MAX_VALUE = 90;


        public Person()
        {
        }

        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        [MyRequired]
        public string FullName { get; set; }

        [MyRange(MIX_VALUE, MAX_VALUE)]
        public int Age { get; set; }

    }
}
