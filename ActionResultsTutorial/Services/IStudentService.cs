using ActionResultsTutorial.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActionResultsTutorial.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllByKeyAsync(string key="");
    }
}
