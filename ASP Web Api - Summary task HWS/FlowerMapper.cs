using ASP_Web_Api___Summary_task_HWS.DTO;
using ASP_Web_Api___Summary_task_HWS.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Web_Api___Summary_task_HWS
{
    public class FlowerMapper : Profile
    {
        public FlowerMapper()
        {
            CreateMap<Flower, FlowerModel>().ReverseMap();
        }
    }
}
