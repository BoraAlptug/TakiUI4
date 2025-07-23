using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System.Text;
using TakiUI4.Models.Utilities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TakiUI4.DataAccess
{
    public interface IMainDataAccess
    {
        Task<ResponseModel<T>> GetRequestAsync<T>(string route)
            where T : class;
        Task<ResponseModel<TResponse>> PostRequestAsync<TRequest, TResponse>(string route, TRequest data)
          where TRequest : class
          where TResponse : class;
        Task<ResponseModel<T1>> PostRequestWithFileListAsync<T1>(
          string route,
          List<IFormFile> files,
          string fieldName,
          int fieldValue,
          string listName) where T1 : class;
        Task<ResponseModel<T1>> PostRequestWithFileAsync<T1>(
         string route,
         IFormFile file,
         string fieldName,
         int fieldValue,
         string fileName)
         where T1 : class;
        Task<ResponseModel<T>> GetRequestByIdAsync<T>(string getListRoute, T data)where T :class;
    }
    public class MainDataAccess : IMainDataAccess
    {
        private readonly HttpClient HttpClient;
        public MainDataAccess(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
        public async Task<ResponseModel<T>> GetRequestAsync<T>(string route) where T : class
        {
            var response = await HttpClient.GetAsync(route);
            var responseContent = await response.Content.ReadAsStringAsync();
            var responseModel = JsonConvert.DeserializeObject<ResponseModel<T>>(responseContent);
            return responseModel;
        }

        public async Task<ResponseModel<TResponse>> PostRequestAsync<TRequest, TResponse>(string route, TRequest data)
           where TRequest : class
           where TResponse : class
        {
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await HttpClient.PostAsync(route, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ResponseModel<TResponse>>(responseContent);
        }

        public async Task<ResponseModel<T1>> PostRequestWithFileListAsync<T1>(string route, List<IFormFile> files, string fieldName, int fieldValue, string listName) where T1 : class
        {
            using var formData = new MultipartFormDataContent();

            foreach (var file in files)
            {
                var fileStream = file.OpenReadStream();  // using kaldırıldı
                var streamContent = new StreamContent(fileStream);
                formData.Add(streamContent, listName, file.FileName);
            }

            formData.Add(new StringContent(fieldValue.ToString()), fieldName);

            var response = await HttpClient.PostAsync(route, formData);
            var responseContent = await response.Content.ReadAsStringAsync();
            var responseModel = JsonConvert.DeserializeObject<ResponseModel<T1>>(responseContent);
            return responseModel;
        }
        public async Task<ResponseModel<T1>> PostRequestWithFileAsync<T1>(
         string route,
         IFormFile file,
         string fieldName,
         int fieldValue,
         string fileName)
         where T1 : class
        {
            using var formData = new MultipartFormDataContent();

            var fileStream = file.OpenReadStream();
            var streamContent = new StreamContent(fileStream);
            formData.Add(streamContent, fileName, file.FileName); // fileName burada form alan adı

            formData.Add(new StringContent(fieldValue.ToString()), fieldName);

            var response = await HttpClient.PostAsync(route, formData);
            var responseContent = await response.Content.ReadAsStringAsync();
            var responseModel = JsonConvert.DeserializeObject<ResponseModel<T1>>(responseContent);
            return responseModel;
        }

        public async Task<ResponseModel<T>> GetRequestByIdAsync<T>(string route, T data) where T : class
        {
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await HttpClient.PostAsync(route, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            var responseModel = JsonConvert.DeserializeObject<ResponseModel<T>>(responseContent);
            return responseModel;
        }
    }

}
