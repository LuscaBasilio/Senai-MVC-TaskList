using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TipoTrello.Models;

namespace TipoTrello.Controllers
{
    public class UsuarioController : Controller
    {
         [HttpGet]

        public IActionResult Cadastrar(){
            
            return View();
        }

        [HttpPost]

        public ActionResult Cadastrar(IFormCollection form){
            
            UsuarioModel usuario = new UsuarioModel();

            usuario.Nome = form["nome"];
            usuario.Senha = form["senha"];
            usuario.Tipo = form["tipo"];
            usuario.dataCriacao = DateTime.Parse(form["dataCriacao"]);

            StreamWriter sw = new StreamWriter("ListaUsuario.csv", true);
            sw.WriteLine($"{usuario.Nome};{usuario.Senha};{usuario.Tipo};{usuario.dataCriacao}");
        
            return View();
        }
    }
}