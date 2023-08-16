using Clientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Clientes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {

        private readonly Contexto dbContext;

        public  ClientesController(Contexto dbContext)
        {

            this.dbContext = dbContext;

        }

        [HttpGet]   
        public async Task <IActionResult> GetClientes()
        {
            return Ok( await dbContext.Cliente.ToListAsync());
         
        }


        [HttpPost]
        public async Task<IActionResult> AddCliente(AddClienteRequest addClienteRequest)
        {
            var cliente = new Cliente()
            {
                Id = Guid.NewGuid(),
                Nome = addClienteRequest.Nome,
                

            };

            await dbContext.Cliente.AddAsync(cliente);
            await dbContext.SaveChangesAsync();

            return Ok(cliente);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateCliente([FromRoute] Guid id, UpdateClienteRequest updateClienteRequest)
        {
            var cliente = await dbContext.Cliente.FindAsync(id);

            if (cliente != null)
            {
                cliente.Nome = updateClienteRequest.Nome;
                

                await dbContext.SaveChangesAsync();


                return NotFound();
              


            }

            return Ok(cliente);
        }

            [HttpDelete]
            [Route("{id:guid}")]
            public async Task<IActionResult> DeleteCliente([FromRoute] Guid id)
        {
            var cliente = await dbContext.Cliente.FindAsync(id);

            if(cliente != null)
            {
                dbContext.Remove(cliente);
                await dbContext.SaveChangesAsync();
                return Ok(cliente); 

            }
       
             return NotFound();
        
        }
        }

}
