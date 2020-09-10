using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PacientesApp.Models;

namespace PacientesApp.Controllers
{
    public class MedicoController : Controller
    {
        private static List<Medico> _banco = new List<Medico>();

        public IActionResult Index()
        {
            return View(_banco);
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _banco.RemoveAt(_banco.FindIndex(x => x.Codigo == id));
            TempData["msg"] = "Paciente removido";
            return RedirectToAction("Index");
        }

        [HttpPost("editar")]
        public IActionResult Editar(Medico paciente)
        {
            _banco[_banco.FindIndex(x => x.Codigo == paciente.Codigo)] = paciente;
            TempData["msg"] = "Paciente atualizado com sucesso";
            return RedirectToAction("Index");
        }

        [HttpGet("editar")]
        public IActionResult Editar(int id)
        {
            var paciente = _banco.Find(x => x.Codigo == id);
            return View(paciente);
        }


        [HttpGet("cadastrar")]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(Medico paciente)
        {
            if (_banco.Any())
            {
                paciente.Codigo = _banco[_banco.Count - 1].Codigo + 1;
            }
            else
            {
                paciente.Codigo = 1;
            }
            _banco.Add(paciente);
            TempData["msg"] = "Paciente cadastrado";
            return RedirectToAction("Cadastrar");
        }
    }
}
