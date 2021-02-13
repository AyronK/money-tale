using System.Threading.Tasks;
using MoneyTale.Web.Identity.Services;

namespace MoneyTale.Web.Services
{
    internal class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
