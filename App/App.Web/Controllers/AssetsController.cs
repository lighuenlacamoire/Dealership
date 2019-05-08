using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Web.Models.DTO;
using App.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class AssetsController : Controller
    {
        public AssetsController(IServices<AssetDto> assetsService)
        {
            _assetsService = assetsService;
        }

        public IServices<AssetDto> _assetsService { get; set; }

        // GET: Assets
        public ActionResult Index()
        {
            var assets = _assetsService.List();


            return View();
        }

        // GET: Assets/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Assets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Assets/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Assets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Assets/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Assets/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}