using App.Web.Models;
using App.Web.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace App.Web.Services
{
    //Assetserivce use the service interface to force it to implement the principal methods
    public class AssetsService : IServices<AssetDto>
    {
        private IAssetsService ApiClient { get; }
        //we will define the constructor where will inject and endpoint provider from the key on configuration file
        public AssetsService(string apiEndpoint)
        {
            try
            {
                ApiClient = RestService.For<IAssetsService>(apiEndpoint);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                throw;
            }
        }
        //every call to service will have a model intermediate the which one will handler  ..
        //...if we got error or problems into data process
        public AssetDto[] List() 
        {
            var response = ApiClient.GetAssets().Result;

            if (response.Success) return response.Data;
            else throw new Exception(response.Message);
        }
        public AssetDto Create(AssetDto newAsset)
        {
            var response = ApiClient.CreateAsset(newAsset).Result;
            if (response.Success) return response.Data;
            else throw new Exception(response.Message);
        }

        public AssetDto Update(AssetDto editassetsDto)
        {

            var response = ApiClient.UpdateAsset(editassetsDto).Result;
            if (response.Success) return response.Data;
            else throw new Exception(response.Message);

        }
    }
}
