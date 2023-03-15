using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumindoApi.Entities.Services
{
    internal class AlunosServices
    {
        public async Task<Aluno> Integracao(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7136/aluno/{id}");
            var jsonString = await response.Content.ReadAsStringAsync();

            Aluno JsonObject = JsonConvert.DeserializeObject<Aluno>(jsonString);


            if(JsonObject != null)
            {
                return JsonObject;
            }
            else
            {
                return new Aluno
                {
                    Verificacao = true
                };
            }
            
        }
    }
}
