using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReleaseTracker.Service.Common;
using ReleaseTracker.Service.Models;
using System.Data;
using Dapper;

namespace ReleaseTracker.Service
{
    class ProjectsRepository : IRepository<Project>
    {
        protected IDbConnection dbConnection;

        ProjectsRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Project GetAll()
        {
            throw new NotImplementedException();
        }

        public Project GetById(long id)
        {
            throw new NotImplementedException();
        }

        public long Insert(Project project)
        {
            return dbConnection.Query<long>("[dbo].[InsertNewProject]",
                new
                {
                    Name = project.Name,
                    Description = project.Description
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public Project Update(Project project)
        {
            return new Project();
        }
    }
}
