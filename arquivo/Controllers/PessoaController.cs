using arquivo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arquivo.Controllers
{
    public class PessoaController : Controller
    {
        public static List<Pessoa> lsPessoa = new List<Pessoa>();
        //alt center, criar um faslo banco de dados
        public IActionResult Index()
        {
            return View(lsPessoa);
        }

        public IActionResult cadastrar()
        {
            return View();
        }

        public IActionResult salvar(Pessoa intem)
        {
            lsPessoa.Add(intem);
            return RedirectToAction("Index");


            return View();
        }
    }
}

