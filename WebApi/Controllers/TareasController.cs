using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace WebApi.Controllers
{
    public class TareasController : ApiController
    {
        private readonly CapaNegocio.InterfaceTa _data;
        public TareasController()
        {

        }
        public TareasController(CapaNegocio.InterfaceTa service)
        {
            _data = service;
        }

        //[System.Web.Http.HttpGet]
        //public IHttpActionResult ObtenerTarea(int id)
        //{
            
        //}

        [System.Web.Http.HttpPost]
        public IHttpActionResult CrearTarea(Tareas meta)
        {
            if (meta == null)
            {
                return BadRequest("La solicitud no puede ser procesada porque el cuerpo está vacío.");
            }

            _data.CreateTarea(meta);

            return CreatedAtRoute("DefaultApi", new { id = meta.IdTareas }, meta);
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateTarea(int id, Tareas meta)
        {
            if (meta == null)
            {
                return BadRequest("La solicitud no puede ser procesada porque el cuerpo está vacío.");
            }

            if (id != meta.IdTareas)
            {
                return BadRequest("El ID de la meta proporcionado no coincide con el ID en la ruta.");
            }

            try
            {
                _data.UpdateTarea(meta);
            }
            catch (Exception)
            {
                return InternalServerError();
            }

            return Ok(meta);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult ListaTareas()
        {
            var metas = _data.GetAllTareas();
            return Ok(metas);
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteTarea(string id)
        {
            var meta = _data.GetTareasByListaMetaId(id);
            if (meta == null)
            {
                return NotFound();
            }

            try
            { 
                _data.DeleteTarea(meta);
            }
            catch (Exception)
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
}