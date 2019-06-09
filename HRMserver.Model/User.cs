using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMserver
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }

        public static User user=null;
        private User()
        {

        }

        public static User GetUser()
        {
            if (user == null)
            {
                user = new User();
            }
            return user;
        }
    }
}
