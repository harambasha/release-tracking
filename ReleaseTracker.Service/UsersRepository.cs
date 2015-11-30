using ReleaseTracker.Service.Common;
using ReleaseTracker.Service.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ReleaseTracker.Service
{
    //for now is only implemented Insert -> used for Registration
    public class UsersRepository : IRepository<User>
    {
        protected IDbConnection dbConnection;

        public UsersRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public User Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(long id)
        {
            throw new NotImplementedException();
        }

        public long Insert(User user)
        {
            return dbConnection.Query<long>("[dbo].[InsertNewUser]",
                new
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    RolaId = user.RolaId
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }

        public bool CheckEmailUniqueness(string email) //Email is unique on the system
        {
            var result = dbConnection.Query<User>("[dbo].[CheckEmailUniqueness]",
                new { Email = email },
                commandType: CommandType.StoredProcedure).SingleOrDefault();

            if (result == null)
            {
                return true;
            }
            return false;
        }
    }
}
