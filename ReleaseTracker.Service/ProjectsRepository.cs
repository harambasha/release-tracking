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
    public class ProjectsRepository : IRepository<Project>
    {
        protected IDbConnection dbConnection;

        public ProjectsRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public Project Delete(long id)
        {
            return dbConnection.Query<Project>("[dbo].[DeleteProject]",
                new { Id = id },
                commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public List<Project> GetAll()
        {
            return dbConnection.Query<Project>("[dbo].[GetAllProjects]",
                commandType: CommandType.StoredProcedure).ToList();
        }

        public Project GetById(long id)
        {
            return dbConnection.Query<Project>("[dbo].[GetProjectById]",
                new { Id = id },
                commandType: CommandType.StoredProcedure).SingleOrDefault();
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
            return dbConnection.Query<Project>("[dbo].[UpdateProject]",
                new
                {
                    Name = project.Name,
                    Description = project.Description
                },
                commandType: CommandType.StoredProcedure
                ).SingleOrDefault();
        }

        public bool CheckProjectNameUniqueness(string name)
        {
            var result = dbConnection.Query<Project>("[dbo].[CheckProjectNameUniqueness]",
                new { Name = name },
                commandType: CommandType.StoredProcedure).SingleOrDefault();
            if(result == null)
            {
                return true;
            }

            return false;
        }
    }
}
