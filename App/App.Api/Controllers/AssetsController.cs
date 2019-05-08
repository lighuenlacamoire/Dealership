using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Api.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Api.Models;

namespace App.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        // GET: api/Assets
        [HttpGet]
        public ServiceResponse<IEnumerable<AssetDto>> Get()
        {
            try
            {

                return new ServiceResponse<IEnumerable<AssetDto>> { Success = true, Data = new List<AssetDto>() };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return new ServiceResponse<IEnumerable<AssetDto>> { Success = false, Message = ex.Message };
            }
        }

    }
}
