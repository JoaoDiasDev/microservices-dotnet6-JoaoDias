using ShopJoaoDias.Email.Messages;

namespace ShopJoaoDias.Email.Repository
{
    public interface IEmailRepository
    {
        Task LogEmail(UpdatePaymentResultMessage message);
    }
}
