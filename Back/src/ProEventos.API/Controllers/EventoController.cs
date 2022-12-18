using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]  {
                new Evento
                {
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5 Core",
                    Local = "Belo Horizonte",
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    QtdPessoas = 250,
                    Lote = "1º Lote",
                    ImageURL = "evento1.png"
                },

                new Evento
                {
                    EventoId = 2,
                    Tema = "Java 8",
                    Local = "São Paulo",
                    DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"),
                    QtdPessoas = 100,
                    Lote = "3º Lote",
                    ImageURL = "evento5.png"
                }

         };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(e => e.EventoId == id);
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
