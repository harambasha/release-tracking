using ReleaseTracker.Business;
using ReleaseTracker.Service.Models;
using ReleaseTracker.WebApi.HttpPipeline;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace ReleaseTracker.WebApi.Controllers
{
    public class RolesController : ApiController
    {
        protected SqlConnection sqlConnection;
        private RolesBusiness rolesBusiness;

        public RolesController()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ReleaseTrackerDbConnection"].ConnectionString);
            rolesBusiness = new RolesBusiness(sqlConnection);
        }

        public List<Role> Get()
        {
            List<Role> roles = rolesBusiness.GetAll();
            if (!roles.Any())
            {
                throw new ApiException(HttpStatusCode.NotFound, "No data found in the database");//zero roles in db
            }

            return roles;
        }
    }
}
