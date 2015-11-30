using ReleaseTracker.Service;
using ReleaseTracker.Service.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseTracker.Business
{
    public class UsersBusiness
    {
        protected UsersRepository UsersRepo;

        public UsersBusiness(SqlConnection sqlConnection)
        {
            UsersRepo = new UsersRepository(sqlConnection);
        }

        public string Insert(User user)
        {
            if (String.IsNullOrEmpty(user.FirstName) || String.IsNullOrEmpty(user.LastName) ||
                 String.IsNullOrEmpty(user.Email) || String.IsNullOrEmpty(user.Password))
            {
                return "bad_request";
            }
            else if (!UsersRepo.CheckEmailUniqueness(user.Email))
            {
                return "conflict";
            }

            return UsersRepo.Insert(user).ToString();
        }

    }

}
