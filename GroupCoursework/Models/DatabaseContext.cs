using Microsoft.EntityFrameworkCore;

namespace GroupCoursework.Models
{
    public class DataBaseContext : DbContext
    {
        // as per the entity framework this code insures if the database had been created or not, plus if not created it creates automatically
        // and DB context has also been implemented in sartup.cs
        // all public DBSet are for creating tables in the database

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }

}
