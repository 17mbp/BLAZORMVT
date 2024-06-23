using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly CapaNegocio.Interface _data;
        public ValuesController()
        {
                
        }
        public ValuesController(CapaNegocio.Interface service)
        {
            _data = service;
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult ObtenerMeta(int id)
        {
            var meta = _data.GetLista(id);
            if (meta == null)
            {
                return NotFound();
            }
            return Ok(meta);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult CrearMeta(ListaMetas meta)
        {
            if (meta == null)
            {
                return  BadRequest( "La solicitud no puede ser procesada porque el cuerpo está vacío.");
            }

            _data.CreateMeta(meta);

            return CreatedAtRoute("DefaultApi", new { id = meta.Id }, meta);
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateMeta(int id, CRUD meta)
        {
            if (meta == null)
            {
                return BadRequest("La solicitud no puede ser procesada porque el cuerpo está vacío.");
            }

            if (id != meta.Id)
            {
                return BadRequest("El ID de la meta proporcionado no coincide con el ID en la ruta.");
            }

            try
            {
                CapaEntidades.ListaMetas listaMetas = new CapaEntidades.ListaMetas()
                {
                    Id = id,
                    Nombre = meta.Nombre      
                };
                 _data.UpdateMeta(listaMetas);
            }
            catch (Exception)
            {
                return InternalServerError();
            }

            return Ok(meta);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Lista()
        {
            var metas = _data.GetAllMetas();
            return Ok(metas);
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteMeta(int id)
        {
            var meta = _data.GetLista(id);
            if (meta == null)
            {
                return NotFound();
            }

            try
            {
                _data.DeleteMeta(id);
            }
            catch (Exception)
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
}