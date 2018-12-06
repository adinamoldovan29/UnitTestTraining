using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UnitTestTraining.BuilderTestPattern
{
    public class User
    {
        public User(string name, string email, 
            string mobileNumber, ComplexDependency dependency)
        {
            Name = name;
            Email = email;
            MobileNumber = mobileNumber;
            NotRelevantForOutTest = dependency;
        }

        public string Name { get; }

        public string Email { get; }

        public string MobileNumber { get; }

        public ComplexDependency NotRelevantForOutTest { get; }

        public bool IsValid()
        {
            if (!Regex.IsMatch(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return false;
            }

            if (MobileNumber?.Length != 10)
            {
                return false;
            }

            return true;
        }
    }
}
