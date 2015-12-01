using Dapper;
using ReleaseTracker.Service.Common;
using ReleaseTracker.Service.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseTracker.Service
{
    public class RolesRepository : IRepository<Role>
    {
        protected IDbConnection dbmConnection;

        public RolesRepository(IDbConnection db_conn)
        {
            dbmConnection = db_conn;
        }        

        public Role Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll()
        {
            return dbmConnection.Query<Role>("[dbo].[GetAllRoles]",
                commandType: CommandType.StoredProcedure
                ).ToList();
        }

        public Role GetById(long id)
        {
            throw new NotImplementedException();
        }

        public long Insert(Role entity)
        {
            throw new NotImplementedException();
        }

        public Role Update(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
