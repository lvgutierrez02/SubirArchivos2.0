using ExcelUploadReadDataSaveExampleCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ExcelUploadReadDataSaveExampleCore.Context
{
    public class DataBaseContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            var connectionString = string.Format(@"Data Source=DESKTOP-APBMAQK;Initial Catalog=School;Integrated Security=True");
            options.UseSqlServer(connectionString);
        }

        public DbSet<Student> Students { get; set; }

        
    }
}
