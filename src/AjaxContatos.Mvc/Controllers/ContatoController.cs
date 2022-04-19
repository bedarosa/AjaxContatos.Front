using AjaxContatos.Service.Services.Interfaces;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AjaxContatos.Mvc.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoService _contatoService;
        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await _contatoService.BuscarTodos());
        }

        public async Task<ActionResult> Detail(Guid id)
        {
            return View(await _contatoService.BuscarPorId(id));
        }

        public async Task<ActionResult> Delete(Guid id)
        {
            await _contatoService.DeletarContato(id);
            return View();
        }
    }
}