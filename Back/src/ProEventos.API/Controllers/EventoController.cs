using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
     
        private readonly DataContext _context;
     
        public EventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.EVENTOS;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.EVENTOS
                .FirstOrDefault(e => e.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "EXEMPLO DE POST";
        }

        [HttpPut("{id}")]
        public string Post(int id)
        {
            return $"EXEMPLO DE PUT COM ID = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"EXEMPLO DE DELETE COM ID = {id}";
        }
    }
}
