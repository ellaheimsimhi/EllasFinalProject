using EllasFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllasFinalProject.Services
{
    public class DBMokup
    {
        private List<AppUser> _users = new List<AppUser>();
        public DBMokup()
        {
            _users.Add(new AppUser { UserEmail = "eheimsimhi@mail.com", UserPassword = "Nod0204!" });
            _users.Add(new AppUser { UserEmail = "user1@mail.com", UserPassword = "pass1" });
            _users.Add(new AppUser { UserEmail = "user2@mail.com", UserPassword = "pass2" });
        }
        public bool IsExist(string uEmail, string uPass)
        {
            return _users.Any(u => u.UserEmail == uEmail && u.UserPassword == uPass);
        }
    }
}
