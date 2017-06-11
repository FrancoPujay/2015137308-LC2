using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _2015137308.API;
using _2015137308.API.DTO;

namespace _2015137308.API.Controllers
{
    public class ClientesController : ApiController
    {
        private APIContext db = new APIContext();

        // GET: api/Clientes
        public IQueryable<ClienteDTO> GetClientes()
        {
            return db.Clientes;
        }

        // GET: api/Clientes/5
        [ResponseType(typeof(ClienteDTO))]
        public IHttpActionResult GetClienteDTO(int id)
        {
            ClienteDTO clienteDTO = db.Clientes.Find(id);
            if (clienteDTO == null)
            {
                return NotFound();
            }

            return Ok(clienteDTO);
        }

        // PUT: api/Clientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClienteDTO(int id, ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clienteDTO.ClienteId)
            {
                return BadRequest();
            }

            db.Entry(clienteDTO).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteDTOExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Clientes
        [ResponseType(typeof(ClienteDTO))]
        public IHttpActionResult PostClienteDTO(ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Clientes.Add(clienteDTO);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = clienteDTO.ClienteId }, clienteDTO);
        }

        // DELETE: api/Clientes/5
        [ResponseType(typeof(ClienteDTO))]
        public IHttpActionResult DeleteClienteDTO(int id)
        {
            ClienteDTO clienteDTO = db.Clientes.Find(id);
            if (clienteDTO == null)
            {
                return NotFound();
            }

            db.Clientes.Remove(clienteDTO);
            db.SaveChanges();

            return Ok(clienteDTO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClienteDTOExists(int id)
        {
            return db.Clientes.Count(e => e.ClienteId == id) > 0;
        }
    }
}