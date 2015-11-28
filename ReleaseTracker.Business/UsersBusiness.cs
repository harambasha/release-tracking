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

        public long Insert(User user)
        {
            //later write some validation code

            return UsersRepo.Insert(user);

        }

    }

}
