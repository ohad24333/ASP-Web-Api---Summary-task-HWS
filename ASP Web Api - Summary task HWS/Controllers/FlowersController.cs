using ASP_Web_Api___Summary_task_HWS.DTO;
using ASP_Web_Api___Summary_task_HWS.Models;
using ASP_Web_Api___Summary_task_HWS.Repos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Web_Api___Summary_task_HWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        private readonly IFlowerRepository _flowerRepository;
        private readonly IMapper _mapper;

        public FlowersController(IFlowerRepository flowerRepository , IMapper mapper)
        {
            _flowerRepository = flowerRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFlowers()
        {
            var list = await _flowerRepository.GetAllFlowersAsync();
            return Ok(_mapper.Map<List<FlowerModel>>(list));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFlower([FromRoute]string id)
        {
            var flower = await _flowerRepository.GetFlowerAsync(id);
            return Ok(_mapper.Map<FlowerModel>(flower));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFlower([FromRoute] string id , [FromBody] FlowerModel flowerModel)
        {
            await _flowerRepository.UpdateFlowersAsync(id, _mapper.Map<Flower>(flowerModel));
            return Ok();

        }

        [HttpPost]
        public async Task<IActionResult> AddNewFlower ([FromBody] FlowerModel flowerModel)
        {
            var flowerId =  await _flowerRepository.AddNewFlowersAsync(_mapper.Map<Flower>(flowerModel));
            return CreatedAtAction(nameof(GetFlower), new { id = flowerId, controller = "Flowers" }, flowerId);
        } 

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlower([FromRoute] string id)
        {
            await _flowerRepository.DeleteFlowerAsync(id);
            return Ok();
        }
    }
}
