using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoWeb.Models;

namespace TodoWeb.Controllers
{
    public class UsuarioController : Controller
    {
        static List<Usuario> lista = new List<Usuario>();
        // GET: Usuario
        public ActionResult Index()
        {
            //lista.Add(new Usuario { UsuarioID = 1, Nome = "Fulano" });
            //lista.Add(new Usuario { UsuarioID = 2, Nome = "Ciclano" });

            // ViewBag.Usuarios = lista;

            return View(lista);
        }

        // GET: /usuario/create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            int id = int.Parse(form["UsuarioID"]);
            string nome = form["nome"];

            lista.Add(new Usuario {UsuarioID = id, Nome = nome });
            //return View();
            return RedirectToAction("Index");
        }
   
        }
    }