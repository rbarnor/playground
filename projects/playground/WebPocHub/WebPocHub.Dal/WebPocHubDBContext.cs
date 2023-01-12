using Microsoft.EntityFrameworkCore;
using WebPocHub.Models;


namespace WebPocHub.Dal
{
    public class WebPocHubDBContext:DbContext
    {
        public string DbPath { get; }
        
        
        public WebPocHubDBContext()
        {
            //when the constructor initialize it should create or look for a folder that contains a file Rans.d
            //which is an sqlite file
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Rans.db");

        }

        public WebPocHubDBContext(DbContextOptions options) :  base(options)
        {

        }


        // Database Management configuration to use a particular  database    
        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                //options.UseSqlServer("Data Source = localhost; Initial Catalog = WebApiDB; Integrated Security = true");
                // the above was commented out because i dont have an sql server running but i have played with sqlite so we will use that
                options.UseSqlite($"Data Source={DbPath}");
            }
        }

        //If we want our database to start with a seeded or default or sample data we do this config:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { EmployeeId = 1,Address="14 Baatsonaa Highway",Zipcode="00233",City="Accra",Avatar="/images/rans.png",
                Email="ransberrypy",EmployeeName="Ransben Barnor", Phone="0547050720"}
                );

            //sample roles schema and db data
            modelBuilder.Entity<Role>().HasData(
                new Role() { RoleId=1, RoleName="Employee",RoleDescription="Employee of DevNest Systems"}
                );
        }

        //creating the dbset with scheme from our models 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

    }
}