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
using ReleaseTracker.WebApi.HttpPipeline;

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

        public long Post(Project project)
        {
            var returnedValue = projectsBusiness.Insert(project);
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
                    throw new ApiException(HttpStatusCode.Conflict, "There is already a same project wih supplied information"); //if email is not unique
                }
            }

            return id; //returns Success[200]
        }
    }
}
