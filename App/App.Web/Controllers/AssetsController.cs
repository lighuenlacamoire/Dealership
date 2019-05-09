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

        #region [ View: Assets List]
        [Route("List")]
        public ActionResult List()
        {
            return View();
        }
        #endregion

        #region [ View: Create new asset]
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }
        #endregion

        #region [ Method: Get all assets ]
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
                PublicLog(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}