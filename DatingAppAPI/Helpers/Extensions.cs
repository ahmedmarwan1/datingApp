using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse respose, string message)
        {
            respose.Headers.Add("Application-Error", message);
            respose.Headers.Add("Access-Control-Expose-Headers","Application-Error");
            respose.Headers.Add("Access-Control-Allow-Origin","*");
        }

        public static void AddPagination(this HttpResponse response,
        int currentPage,int itemsPerPage, int totalItems,int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage,itemsPerPage,totalItems,totalPages);
            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader, camelCaseFormatter));
            response.Headers.Add("Access-Control-Expose-Headers","Pagination");
        }

        public static int CalculateAge(this DateTime theDatetime)
        {   
            var age = DateTime.Today.Year - theDatetime.Year;
            if(theDatetime.AddYears(age) > DateTime.Today)
                age--;
            return age; 
        }
    }
}