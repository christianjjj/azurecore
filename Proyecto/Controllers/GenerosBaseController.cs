using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proyecto.DTOs.Genero;
using Proyecto.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Proyecto.Controllers
{
    [ApiController]
    [Route("api/generosBase")]
    public class GenerosBaseController: CustomBaseController
    {
        public GenerosBaseController(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
         
        }

        [HttpGet]
        public async Task<ActionResult<List<GeneroDTO>>> Get()
        {
            return await Get<Genero, GeneroDTO>();
        }


        [HttpGet("{id:int}", Name = "obtenerGenero2")]
        public async Task<ActionResult<GeneroDTO>> Get(int id)
        {
            return await Get<Genero, GeneroDTO>(id);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GeneroCreacionDTO generoCreacionDTO)
        {
            return await Post<GeneroCreacionDTO, Genero, GeneroDTO>(generoCreacionDTO, "obtenerGenero");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] GeneroCreacionDTO generoCreacionDTO)
        {
            return await Put<GeneroCreacionDTO, Genero>(id, generoCreacionDTO);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            return await Delete<Genero>(id);
        }
    }
}
