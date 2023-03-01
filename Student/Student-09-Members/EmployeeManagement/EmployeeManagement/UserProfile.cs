using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement
{
    struct UserProfile
    {
        private string username;
        private string password;
        private string emailAddress;

        public UserProfile(string username, string password, string emailAddress)
        {
            this.username = username;
            this.password = password;
            this.emailAddress = emailAddress;
        }

        public bool ChangePassword(string currentPassword, string newPassword)
        {
            if (currentPassword == password)
            {
                password = newPassword;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("User name: {0}, e-mail address: {1}", username, emailAddress);
        }
    }
}
