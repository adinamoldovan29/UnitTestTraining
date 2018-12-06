using UnitTestTraining.BuilderTestPattern;

namespace UnitTest.StateTestPattern
{
    public class UserBuilder
    {
        private string name;
        private string email;
        private string mobileNo;

        public UserBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }

        public UserBuilder WithEmail(string email)
        {
            this.email = email;
            return this;
        }

        public UserBuilder WithMobileNumber(string mobileNo)
        {
            this.mobileNo = mobileNo;
            return this;
        }

        public User Build()
        {
            // initialize not important dependecies only once
            var complexDependency = new ComplexDependency();

            return new User(name, email, mobileNo, complexDependency);
        }
    }
}