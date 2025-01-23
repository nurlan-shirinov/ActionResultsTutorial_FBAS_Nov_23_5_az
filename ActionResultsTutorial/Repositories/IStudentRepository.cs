using ActionResultsTutorial.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActionResultsTutorial.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        void Add(Student student);

    }
}
