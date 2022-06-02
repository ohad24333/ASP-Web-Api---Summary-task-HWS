using ASP_Web_Api___Summary_task_HWS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_Web_Api___Summary_task_HWS.Repos
{
    public interface IFlowerRepository
    {
        Task<string> AddNewFlowersAsync(Flower flower);
        Task<List<Flower>> GetAllFlowersAsync();
        Task<Flower> GetFlowerAsync(string id);
        Task UpdateFlowersAsync(string id, Flower modifiedFlower);
        Task DeleteFlowerAsync(string id);
    }
}