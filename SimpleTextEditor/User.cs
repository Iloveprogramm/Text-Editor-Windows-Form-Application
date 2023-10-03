using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    public class User
    {
        public string UserName
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        public string UserType
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string DateOfBirth
        {
            get; set;
        }

        public User(string UserName, string Password, string UserType, string FirstName, string LastName, string DateOfBirth)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.UserType = UserType;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
        }

    }
}
