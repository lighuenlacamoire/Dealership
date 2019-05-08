using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Web.Models;
using App.Web.Models.DTO;
using Refit;

namespace App.Web.Services
{
    //we will declare our service interface with principal methods like get a list, create, update...
    //..on this case with generic so will define entity per service
    public interface IServices<T>
    {
        T[] List();
        T Create(T dto);
        T Update(T dto);
    }
    public interface IAssetsService
    {
        //Methods
        [Get("/Assets")]
        Task<ServiceResponse<AssetDto[]>> GetAssets();
        
        [Post("/Assets")]
        Task<ServiceResponse<AssetDto>> CreateAsset(AssetDto newAsset);

        [Put("/Assets")]
        Task<ServiceResponse<AssetDto>> UpdateAsset(AssetDto editassetsDto);

    }
}