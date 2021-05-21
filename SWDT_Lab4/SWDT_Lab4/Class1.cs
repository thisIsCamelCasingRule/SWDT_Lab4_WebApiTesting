using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Dropbox.Api;
using RestSharp.Authenticators;

namespace SWDT_Lab4
{
    public static class Class1
    {
        public static HttpStatusCode GetUpload() 
        {
            var client = new RestClient("https://content.dropboxapi.com");
            var request = new RestRequest("/2/files/upload", Method.POST);

            request.AddHeader("Authorization", "Bearer pEy9IvIraHAAAAAAAAAAAeOXpB4fktZ3rJcp69s1kcOljMbD2P42bgIxQ65k0MR7");
            request.AddHeader("Dropbox-API-Arg", "{\"path\": \"/Homework/math/Matrices.txt\",\"mode\": \"add\",\"autorename\": true,\"mute\": false,\"strict_conflict\": false}");
            request.AddHeader("Content-type", "application/octet-stream");
            var responseAccount = client.Execute(request);

            HttpStatusCode statusCode = responseAccount.StatusCode;

            //var fileString = responseAccount.Content;
            //Console.WriteLine(fileString);

            return statusCode;
        }

        public static HttpStatusCode GetFileMetadata()
        {
            var client = new RestClient("https://api.dropboxapi.com");
            var request = new RestRequest("2/files/get_metadata", Method.POST);

            request.AddJsonBody("{\"path\": \"/Homework/math\",\"include_media_info\": false,\"include_deleted\": false,\"include_has_explicit_shared_members\": false}");         
            request.AddHeader("Authorization", "Bearer pEy9IvIraHAAAAAAAAAAAeOXpB4fktZ3rJcp69s1kcOljMbD2P42bgIxQ65k0MR7");
            request.AddHeader("Content-type", "application/json");
            
            var responseAccount = client.Execute(request);
           
            HttpStatusCode statusCode = responseAccount.StatusCode;
            
            //var fileString = responseAccount.Content;
            //Console.WriteLine(fileString);

            return statusCode;
        }

        public static HttpStatusCode GetDelete()
        {
            var client = new RestClient("https://api.dropboxapi.com");
            var request = new RestRequest("2/files/delete_v2", Method.POST);

            request.AddJsonBody("{\"path\": \"/Homework/math/Matrices.txt\"}");
            request.AddHeader("Authorization", "Bearer pEy9IvIraHAAAAAAAAAAAeOXpB4fktZ3rJcp69s1kcOljMbD2P42bgIxQ65k0MR7");
            request.AddHeader("Content-type", "application/json");
            
            var responseAccount = client.Execute(request);
            HttpStatusCode statusCode = responseAccount.StatusCode;
            
            //var fileString = responseAccount.Content;
            //Console.WriteLine(fileString);

            return statusCode;
        }
    }
}
