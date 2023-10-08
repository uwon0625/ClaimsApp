namespace ClaimsApp.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ClaimsApp.Models;

    public interface IServiceBusSender
    {
        Task SendMessage(ClaimAudit payload);
    }
}