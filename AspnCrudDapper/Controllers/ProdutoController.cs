using AspnCrudDapper.Entities;
using AspnCrudDapper.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


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
        public ActionResult Index()
        {
            try
            {
                List<Produto> model = new List<Produto>();

                model = _produtoRepository.GetProdutos();

                return View(model);
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
        public JsonResult Add(Produto produto)
        {
            try {
                produto.DataCadastro = DateTime.Now;
                _produtoRepository.Add(produto);

                return Json(new JsonModel { Success = true, Message = "Cadastro do produto efetuado com sucesso!" });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Excluir()
        {
            Produto produto = new Produto();
            return View(produto);
        }

        [HttpDelete]
        public ActionResult Delete(string cod)
        {
            try
            {
                _produtoRepository.Delete(cod);
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}