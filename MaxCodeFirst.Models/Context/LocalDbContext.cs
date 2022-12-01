using MaxCodeFirst.Models.TablesAndEntities;
using Microsoft.EntityFrameworkCore;

namespace MaxCodeFirst.Models.Context
{
    public class LocalDbContext : DbContext
    {
        //add constr options
        public LocalDbContext(DbContextOptions options) : base(options)
        {
        }

        //inherith from IDbContext
        public DbSet<Student> Students { get; set; }

        //override for connect database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connect string
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LocalDB;");
        }
        /***************Nuget install SqlServer,Tool,design**************/
        /*************set startup project is MaxCodeFirst.Models**************/
        /**********Add-migration initial_table_student,update-database**************/
    }
}
