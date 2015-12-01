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
    public class RolesBusiness
    {
        protected RolesRepository rolesRep;

        public RolesBusiness(SqlConnection sqlConnection)
        {
            rolesRep = new RolesRepository(sqlConnection);
        }

        public List<Role> GetAll()
        {
            return rolesRep.GetAll();
        }
    }
}
