using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Data;

namespace WebApplication1.Controllers
{
    public class ContaController : Controller
    {
        private readonly Context _context;

        public ContaController(Context context)
        {
            _context = context;           
        }

        //É a ação que chama a nossa tela
        public IActionResult Index()
        {
            return View();//apresenta a tela
        }

        //quando estamos na tela de cadastro ao clicar em Cadastrar acionara esta ação para realizar o cadatro
        public async Task<IActionResult> CadastrarFatura(Conta contaParaCadastro) // contaParaCadastro -> é a conta que recemos do nosso formulario de cadastro
        {
            try
            {
                //Inicio do cadastro da fatura
                await _context.Conta.AddAsync(contaParaCadastro);
                await _context.SaveChangesAsync();
                //Fim do cadastro da fatura
            }
            catch (Exception e)
            {
                throw;
            }


            return Json("");//vai retornar para nossa tela se a fatura foi cadastrada com sucesso
        }
    }
}
