using AspnCrudDapper.Entities;
using AspnCrudDapper.Repository;
using Microsoft.AspNetCore.Mvc;
using SYN.Domain.Model;
using System;
using System.Threading.Tasks;

namespace AspnCrudDapper.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                DadosProduto resultado = await _produtoRepository.GetProdutos();

                return View(resultado.Resultado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public async Task<JsonResult> ListarProduto()
        {
            try
            {
                DadosProduto resultado = await _produtoRepository.GetProdutos();

                return Json(new JsonModel() { Success = true, result = resultado.Resultado, Message = resultado.Msg });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        [HttpGet]
        public ActionResult ManderProduto(string cod)
        {
            try
            {
                Produto produto = new Produto();

                // Verifica se é edição
                if (!string.IsNullOrEmpty(cod))
                {
                    produto = _produtoRepository.Get(cod);
                }

                return View(produto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public async Task<JsonResult> Add(Produto produto)
        {
            try
            {
                produto.DataCadastro = DateTime.Now;
                Notificacao resultado = await _produtoRepository.Add(produto);

                if (resultado.Erro)
                {
                    return Json(new JsonModel() { Success = false, result = resultado.Resultado, Message = resultado.Msg });
                }

                return Json(new JsonModel() { Success = true, result = resultado, Message = resultado.Msg });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public async Task<JsonResult> Edit(Produto produto)
        {
            try
            {
                produto.DataCadastro = DateTime.Now;
                Notificacao resultado = await _produtoRepository.Edit(produto);

                if (resultado.Erro)
                {
                    return Json(new JsonModel() { Success = false, result = resultado.Resultado, Message = resultado.Msg });
                }

                return Json(new JsonModel() { Success = true, result = resultado, Message = resultado.Msg });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Excluir(string cod)
        {
            Produto produto = new Produto();
            produto = _produtoRepository.Get(cod);

            return View(produto);
        }

        [HttpDelete]
        public async Task<JsonResult> Delete(string cod)
        {
            try
            {
                Notificacao resultado = await _produtoRepository.Delete(cod);

                if (resultado.Erro)
                {
                    return Json(new JsonModel() { Success = false, result = resultado.Resultado, Message = resultado.Msg });
                }

                return Json(new JsonModel() { Success = true, result = resultado, Message = resultado.Msg });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}