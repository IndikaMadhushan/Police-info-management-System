using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms.Models;
using Forms.UserdashBoard;


namespace Forms.Factories
{
    public static class DashboardFactory
    {
        public static Form GetDashboard(User user)
        {
            return user.Role switch
            {
                //"Admin" => new AdminDashboardForm(user),
                //"User" => new UserDashboardForm(user),
               // _ => null
            };
        }
    }
}
