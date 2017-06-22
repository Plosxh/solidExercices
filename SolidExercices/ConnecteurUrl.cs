using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SolidExercices
{
    class ConnecteurUrl : IConnecteurInterface
    {
        public string[] GetOperations()
        {
            String[] operationListe={};
            var httpClient = new HttpClient();
            var httpResponseMessage = httpClient.GetAsync("http://localhost:80/liste").Result;
            var result = httpResponseMessage.Content.ReadAsStringAsync().Result;
            int i=0;
            foreach (var operation in JsonConvert.DeserializeObject<List<string>>(result))
            {
                
                i++;
                operationListe[i] = operation;
            }
            return operationListe;
        }
    }
}
