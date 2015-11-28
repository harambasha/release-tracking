using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReleaseTracker.Service;
using System.Data.SqlClient;
using ReleaseTracker.Service.Models;

namespace ReleaseTracker.Business
{
    public class ProjectsBusiness
    {
        protected ProjectsRepository ProjectsRep;

        public ProjectsBusiness(SqlConnection sqlConnection)
        {
            ProjectsRep = new ProjectsRepository(sqlConnection);
        }

        public List<Project> GetAll()
        {
            return ProjectsRep.GetAll();
        }

    }
}
