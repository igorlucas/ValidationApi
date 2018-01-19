using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ContaController : Controller
    {
        // GET: Conta
        public ActionResult Index()
        {
            return View();
        }

        // GET: Conta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Conta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conta/Create
        [HttpPost]
        public ActionResult Create(Conta entity)    
        {
            var client = new RestClient("http://localhost:62762/service/public/validation/email");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "fde21ce0-60a4-8e5f-a26e-467776741c21");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddObject(obj: entity);
            IRestResponse response = client.Execute(request);

            
                if (response.Content == "domínio invalido!")
                {
                    return RedirectToAction("Index");    //
                }
            TempData["Email"] = "O domínio do email não é válido";
            return View(entity);

        }

        // GET: Conta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Conta/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Conta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Conta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
