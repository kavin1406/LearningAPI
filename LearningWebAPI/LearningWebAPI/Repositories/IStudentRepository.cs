using LearningAPI.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningWebAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
