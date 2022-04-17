using Microsoft.EntityFrameworkCore;

namespace GroupCoursework.Models
{
    public class DataBaseContext : DbContext
    {
        // as per the entity framework this code insures if the database had been created or not, plus if not created it creates automatically
        // and DB context has also been implemented in sartup.cs
        // all public DBSet are for creating tables in the database

        public DbSet<Actor> Actor { get; set; }


        public DbSet<Studio> Studio { get; set; }
        public DbSet<DVDCategory> DVDCategory { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<DVDCopy> DVDCopy { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<LoanType> LoanType { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<MembershipCategory> MembershipCategory { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<DVDTitle> DVDTitle { get; set; }

        public DbSet<CastMember> CastMember { get; set; }



        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }

}
