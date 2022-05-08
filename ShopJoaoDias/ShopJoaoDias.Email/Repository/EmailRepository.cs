using Microsoft.EntityFrameworkCore;
using ShopJoaoDias.Email.Messages;
using ShopJoaoDias.Email.Model;
using ShopJoaoDias.Email.Model.Context;

namespace ShopJoaoDias.Email.Repository
{
    public class EmailRepository : IEmailRepository
    {
        private readonly DbContextOptions<MySQLContext> _context;

        public EmailRepository(DbContextOptions<MySQLContext> context)
        {
            _context = context;
        }

        public async Task LogEmail(UpdatePaymentResultMessage message)
        {
            EmailLog email = new EmailLog()
            {
                Email = message.Email,
                SentDate = DateTime.Now,
                Log = $"Order - {message.OrderId} has been created successfully!"
            };
            await using var _db = new MySQLContext(_context);
            _db.EmailsLogs.Add(email);
            await _db.SaveChangesAsync();
        }
    }
}
