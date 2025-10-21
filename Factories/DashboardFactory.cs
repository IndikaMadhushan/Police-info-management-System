using Forms.Models;
using Forms.UserdashBoard;
using Forms.UserdashBoard.AdminDashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms.UserdashBoard.Dforms;
using Forms.UserdashBoard.AdminDashboard;



namespace Forms.Factories
{
    public static class DashboardFactory
    {
        public static Form GetDashboard(User user)
        {
            return user.Role switch
            {

                "Admin" => new AdminHomeForm(user),
                "User" => new userdashboard(user),
                _ => null

            };
        }
    }
}
