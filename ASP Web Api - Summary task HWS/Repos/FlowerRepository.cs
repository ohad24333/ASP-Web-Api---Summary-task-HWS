using ASP_Web_Api___Summary_task_HWS.DB;
using ASP_Web_Api___Summary_task_HWS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Web_Api___Summary_task_HWS.Repos
{
    public class FlowerRepository : IFlowerRepository
    {
        private readonly FlowersContext _context;

        public FlowerRepository(FlowersContext context)
        {
            _context = context;
        }
        public async Task<Flower> GetFlowerAsync(string id)
        {
            return await _context.Flowers.SingleOrDefaultAsync(f => f.Id == id);
        }
        public async Task<List<Flower>> GetAllFlowersAsync()
        {
            return await _context.Flowers.ToListAsync(); ;
        }
        public async Task<string> AddNewFlowersAsync(Flower flower)
        {
            await _context.Flowers.AddAsync(flower);
            await _context.SaveChangesAsync();
            return flower.Id;
        }

        public async Task UpdateFlowersAsync(string id, Flower modifiedFlower)
        {
            Flower flower = new Flower
            {
                Id = id,
                Name = modifiedFlower.Name,
                Description = modifiedFlower.Description,
                Colors = modifiedFlower.Colors,
                Price = modifiedFlower.Price,
                Size = modifiedFlower.Size
            };
            _context.Flowers.Update(flower);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFlowerAsync(string id)
        {
            _context.Flowers.Remove(new Flower { Id = id });
            await _context.SaveChangesAsync();
        }
            

    }
}
