using System;

namespace NecromindLibrary.Models
{
    public class AdminModel
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }

        public AdminModel(string password)
        {
            Name = "Admin";
            Password = password;
        }
    }
}