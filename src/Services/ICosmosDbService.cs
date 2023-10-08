namespace ClaimsApp.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ClaimsApp.Models;

    public interface ICosmosDbService
    {
        Task<IEnumerable<Claim>> GetItemsAsync(string query);
        Task<Claim> GetItemAsync(string id);
        Task AddItemAsync(Claim item);
        Task UpdateItemAsync(string id, Claim item);
        Task DeleteItemAsync(string id);
    }
}
