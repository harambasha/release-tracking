using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReleaseTracker.Service.Models;
using ReleaseTracker.Business;
using System.Configuration;

namespace ReleaseTracker.WebApi.Controllers
{
    public class ProjectsController : ApiController
    {
        protected SqlConnection sqlConnection;
        private ProjectsBusiness projectsBusiness;

        public ProjectsController()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ReleaseTrackerDbConnection"].ConnectionString);
            projectsBusiness = new ProjectsBusiness(sqlConnection);
        }

        public List<Project> Get()
        {
            List<Project> projectsList = projectsBusiness.GetAll();

            try
            {
                if (!projectsList.Any())
                {
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
                }

                return projectsList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
