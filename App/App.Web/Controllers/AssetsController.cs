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
    [Route("[controller]")]
    public class AssetsController : BaseController
    {
        public AssetsController(IServices<AssetDto> assetsService)
        {
            _assetsService = assetsService;
        }

        public IServices<AssetDto> _assetsService { get; set; }

        [Route("List")]
        public ActionResult List()
        {
            return View();
        }

        [HttpGet]
        [Route("")]
        public ActionResult GetAssets()
        {
            try
            {
                var assets = _assetsService.List();

                return JsonReturn(assets);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}