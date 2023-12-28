using Microsoft.EntityFrameworkCore;
// namespace demo.Models;

// public class connection2l
// {
    
// }



namespace demo.Models
{
    public class demoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost; port=3306;userid=root;password=John@12345; database=rentingg_system;";
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}
