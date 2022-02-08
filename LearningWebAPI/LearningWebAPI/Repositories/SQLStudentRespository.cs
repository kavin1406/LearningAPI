using LearningAPI.DataModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LearningWebAPI.Repositories
{
    public class SQLStudentRespository : IStudentRepository
    {
        private readonly StudentAdminContext context;

        public SQLStudentRespository(StudentAdminContext context)
        {
            this.context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Students.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();

        }
    }

       
}
