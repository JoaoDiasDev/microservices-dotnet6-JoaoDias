using Microsoft.EntityFrameworkCore;

namespace ShopJoaoDias.Email.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<EmailLog> EmailsLogs { get; set; }
    }
}
