using AspnCrudDapper.Entities;
using AspnCrudDapper.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AspnCrudDapper.Controllers
{
    public class ClienteControlle : Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteControlle(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            Cliente cliente = new Cliente();

            return View(cliente);
        }

        [HttpGet]
        public ActionResult ManderCliente(string cod)
        {
            try
            {
                Cliente cliente = new Cliente();

                if (!string.IsNullOrEmpty(cod))
                {
                    cliente = _clienteRepository.Get(cod);
                }

                return View(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Add (Cliente cliente) {
            try
            {
                _clienteRepository.Add(cliente);
                return View();
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
            Cliente cliente = new Cliente();
            return View(cliente);
        }

        [HttpDelete]
        public ActionResult Delete(string cod)
        {
            try
            {
                _clienteRepository.Delete(cod);
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
