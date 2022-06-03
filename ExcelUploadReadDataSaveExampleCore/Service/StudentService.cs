using EFCore.BulkExtensions;
using ExcelUploadReadDataSaveExampleCore.Context;
using ExcelUploadReadDataSaveExampleCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExcelUploadReadDataSaveExampleCore.Service
{
    public class StudentService :IStudentService
    {
        public readonly DataBaseContext _dbContext = null;

        public StudentService(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Student> GetStudents()
        { 
            return _dbContext.Students.ToList();
            
        }

        public List<Student> SaveStudents(List<Student> students)
        {
            _dbContext.BulkInsert(students);
            return students;
        }
    }
}
