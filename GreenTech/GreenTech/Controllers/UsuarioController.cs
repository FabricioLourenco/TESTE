using GreenTech.Domain.Dtos;
using GreenTech.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GreenTech.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioService _usuarioService;
        private ICadastroResiduoService _cadastroResiduoService;
        private IRankingService _rankingService;
        private IDadosService _dadosService;
        private IEnderecoService _enderecoService;

        public UsuarioController(IUsuarioService usuarioService, ICadastroResiduoService cadastroResiduoService,
            IRankingService rankingService, IDadosService dadosService, IEnderecoService enderecoService)
        {
            _usuarioService = usuarioService;
            _cadastroResiduoService = cadastroResiduoService;
            _rankingService = rankingService;
            _dadosService = dadosService;
            _enderecoService = enderecoService;
        }


        public IActionResult Index()
        {
            var usuario = _usuarioService.BuscarTodosUsuarios();
            ViewBag.Usuario = usuario;
            return View();
        }

        public IActionResult Remover(long id)
        {
            _usuarioService.RemoverUsuario(id);
            return RedirectToAction("index");

        }


        public IActionResult CadastroUsuario()
        {
            var model = new UsuarioDto();
            return View(model);
        }

        [HttpPost]
        public IActionResult CadastroUsuario(UsuarioDto model)
        {

            model.DataCadastro = DateTime.Now;
            var cliente = _usuarioService.SalvarUsuario(model);
            return RedirectToAction("Index");
        }


        public IActionResult CadastroResiduo()
        {
            var model = new CadastroResiduoDto();
            return View(model);
        }

        [HttpPost]
        public IActionResult CadastroResiduo(CadastroResiduoDto model)
        {
            var cliente = _cadastroResiduoService.SalvarCadastroResiduo(model);
            return RedirectToAction("Index");
        }




        public IActionResult VerMeusResiduos()
        {

            var residuos = _cadastroResiduoService.BuscarTodosCadastroResiduo();
            ViewBag.CadastroResiduo = residuos;
            return View();
        }

        public IActionResult CadastroDados()
        {
            var model = new DadosDto();
            return View(model);
        }

        [HttpPost]
        public IActionResult CadastroDados(DadosDto model)
        {
            var cliente = _dadosService.SalvarDados(model);
            return RedirectToAction("Index");
        }


        public IActionResult CadastroEndereco()
        {
            var model = new EnderecoDto();
            return View(model);
        }

        [HttpPost]
        public IActionResult CadastroEndereco(EnderecoDto model)
        {
            var cliente = _enderecoService.SalvarEndereco(model);
            return RedirectToAction("Index");
        }
    }
}
