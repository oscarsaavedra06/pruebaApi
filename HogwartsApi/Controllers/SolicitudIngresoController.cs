using AutoMapper;
using Core.DTO;
using Core.Models;
using Infraestructure.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudIngresoController : ControllerBase
    {
        private readonly ISolicitudIngreso repo;
        private readonly IMapper mapper;

        public SolicitudIngresoController(ISolicitudIngreso repo, IMapper _mapper)
        {
            this.repo = repo;
            mapper = _mapper;
        }
        [HttpGet]
        public async Task<ApiResponse<List<SolicitudIngreso>>> get()
        {
            var items = repo.Get();
             
            var response = new ApiResponse<List<SolicitudIngreso>>(items);

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<bool>> post(SolicitudIngresoDTO entidad)
        {
            var solicitud = mapper.Map<SolicitudIngreso>(entidad);
            var result = await repo.InsertSolicitudIngreso(solicitud);
            var response = new ApiResponse<bool> (result);
            return response;
        }

        [HttpPut]
        public async Task<ApiResponse<bool>> put(int id, SolicitudIngresoDTO entidad)
        {
            var solicitud = mapper.Map<SolicitudIngreso>(entidad);
            var result = await repo.UpdateSolicitudIngreso(id, solicitud);
            var response = new ApiResponse<bool>(result);
            return response;
        }

        [HttpDelete]
        public async Task<ApiResponse<bool>> delete(int id)
        {
         
            var result = await repo.DeleteSolicitudIngreso(id);
            var response = new ApiResponse<bool>(result);
            return response;
        }
    }
}
