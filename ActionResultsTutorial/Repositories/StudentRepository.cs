using ActionResultsTutorial.Context;
using ActionResultsTutorial.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActionResultsTutorial.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        private readonly SchoolDbContext schoolDbContext;
        public StudentRepository(SchoolDbContext schoolDbContext)
        {
            this.schoolDbContext = schoolDbContext;
        }

        public void Add(Student student)
        {
            schoolDbContext.Students.Add(student);
            schoolDbContext.SaveChanges();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await schoolDbContext.Students.ToListAsync();
        }
    }
}
