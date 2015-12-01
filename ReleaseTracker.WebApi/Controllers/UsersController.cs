﻿using ReleaseTracker.Business;
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
            try
            {
                UsersBusiness usersBusiness = new UsersBusiness(sqlConnection);
                var returnedValue = usersBusiness.Insert(user);
                long id = 0;
                bool isNum = long.TryParse(returnedValue, out id);
                if (!isNum)
                {
                    if (returnedValue == "bad_request")
                    {
                        throw new ApiException(HttpStatusCode.BadRequest, "Supplied parameters in the request are malformed"); 
                    }
                    else
                    {
                        throw new ApiException(HttpStatusCode.Conflict, "There is already a same user wih supplied information"); //if email is not unique
                    }
                }

                return id; //returns Success[200]
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
