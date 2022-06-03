using System.ComponentModel.DataAnnotations;

namespace ExcelUploadReadDataSaveExampleCore.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; } = "";
        public string Roll { get; set; } = "";
        public int Age { get; set; } 

    }
}
