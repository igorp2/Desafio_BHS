using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartPedidos.Models;
using SmartPedidos.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPedidos.Controllers

{
    public class PedidoController : Controller
    
    {
        public static int valor;

        private readonly ApplicationDbContext _contexto;

        public PedidoController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {

            ViewBag.Itens = _contexto.Itens.ToList();
            var pedidos = _contexto.Pedidos.ToList();

            return View(pedidos);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Pedido modelo)
        {
            modelo.DataPedido = DateTime.Now;
            modelo.Status = "A";
            _contexto.Pedidos.Add(modelo);
            await _contexto.SaveChangesAsync();
            valor = modelo.Id;
            return RedirectToAction("Item");
        }

        [HttpGet]
        public IActionResult Item()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Item(Item modelo)
        {
            modelo.CodigoPedido = valor;
            _contexto.Itens.Add(modelo);
            await _contexto.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Deletar(int id)
        {
            var pedido = _contexto.Pedidos.First(p => p.Id == id);
            pedido.Status = "E";
            await _contexto.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public ActionResult Listar(Pedido pedido)
        {
            ViewBag.Itens = _contexto.Itens.Where(a => a.CodigoPedido == pedido.Id).ToList();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
