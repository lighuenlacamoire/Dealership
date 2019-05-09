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
                var list = new List<AssetDto>()
                {
                    new AssetDto {
                        Id = "276382634826482",
                        Name = "Scirocco",
                        Description = "Volkswagen Scirocco",                        
                        },

                    new AssetDto {
                        Id = "873985658534232",
                        Name = "Golf GTI",
                        Description = "Volkswagen Golf GTI",
                        },
                    new AssetDto {
                        Id = "83758764764576894",
                        Name = "Focus",
                        Description = "Ford Focus",
                        },

                    new AssetDto {
                        Id = "293424728974924324",
                        Name = "Mustang",
                        Description = "Ford Mustang",
                        },
                };

                return new ServiceResponse<IEnumerable<AssetDto>> { Success = true, Data = list };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return new ServiceResponse<IEnumerable<AssetDto>> { Success = false, Message = ex.Message };
            }
        }

    }
}
