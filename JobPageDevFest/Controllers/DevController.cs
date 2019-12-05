using JobPageDevFest.Models;
using System.Collections.Generic;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace JobPageDevFest.Controllers
{
    public class DevController : Controller
    {
        private string Erro { get; set; }
        // GET: Dev
        public ActionResult Index()
        {
            Erro = Erro ?? "false";
            ViewBag.Erro = Erro;
            return View();
        }

        public ActionResult Create(DadosCandidato dados)
        {
            if (ModelState.IsValid)
            {
                //        HttpPostedFileBase arquivo = Request.Files?[0];

                //        if (arquivo != null)
                //        {
                //            var curriculo = new Attachment(arquivo.InputStream, $"Curriculo Candidato {dados.Nome}.{arquivo.FileName.Split('.')[arquivo.FileName.Split('.').Length - 1]}");

                //            var dadosEmail = new DadosEmail()
                //            {
                //                Assunto = $"Currículo {dados.Nome}",
                //                Mensagem = $"E-mail do candidato: {dados.Email}",
                //                ListaAnexo = new List<Attachment>() { curriculo },
                //                Titulo = "VAGA TI - Envio de currículo",
                //                ListaDestinatarios = new List<string> { "ti@redeflex.com.br" }
                //            };


                //            new Email().EnviaEmail(TipoEmail.Integracao, "Interface cadastro de currículo", dadosEmail);
                //            Erro = "false";
                //        }
                //        else
                //        {
                //            Erro = "true";
                //        }
                return RedirectToAction("index");
            }
            else
                return View("index");
        }
    }
}