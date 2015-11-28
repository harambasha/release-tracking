using ReleaseTracker.Business;
using ReleaseTracker.Service.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReleaseTracker.WebApi.Controllers
{
    public class UsersController : ApiController
    {
        SqlConnection sqlConnection;
        UsersBusiness usersBusiness;

        UsersController()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ReleaseTrackerDbConnection"].ConnectionString);
            usersBusiness = new UsersBusiness(sqlConnection);
        }

        public long Post(User user)
        {
            //Unfinished implementation

            return usersBusiness.Insert(user);

        }

    }
}
