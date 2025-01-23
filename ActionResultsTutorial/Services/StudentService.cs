using ActionResultsTutorial.Entities;
using ActionResultsTutorial.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActionResultsTutorial.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> GetAllByKeyAsync(string key = "")
        {
            var data = await _studentRepository.GetAllAsync();

            return key != "" ? 
                (data.Where(s=>s.Name.ToLower().Contains(key))).ToList():
                data;
        }
    }
}
