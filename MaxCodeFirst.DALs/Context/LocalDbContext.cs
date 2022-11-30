using MaxCodeFirst.Models.TablesAndEntities;
using Microsoft.EntityFrameworkCore;

namespace MaxCodeFirst.DALs.Context
{
    public class LocalDbContext : DbContext
    {
        //inherith from IDbContext
        public DbSet<Student> Students { get; set; }

        //override for connect database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connect string
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LocalDB;");
        }
        /***************Nuget install SqlServer,Tool,design**************/
        /***************Add-migration x,update-database**************/

    }
}
