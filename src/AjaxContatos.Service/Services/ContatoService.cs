using AjaxContatos.Domain.Entities;
using AjaxContatos.Service.Services.Interfaces;
using AjaxContatos.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AutoMapper;

namespace AjaxContatos.Service.Services
{
    public class ContatoService : IContatoService
    {
        private readonly HttpClient client;
        public ContatoService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44304/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public Task AdicionarContato(ContatoViewModel contatoViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<ContatoViewModel> Atualizar(ContatoViewModel contatoViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ContatoViewModel> BuscarPorId(Guid id)
        {
            var contato = await client.GetStringAsync("api/Contato?id=" + id);
            var contatoDeserealizado = JsonConvert.DeserializeObject<ContatoViewModel>(contato);
            var teste = 1;
            return contatoDeserealizado;
        }

        public async Task<List<ContatoViewModel>> BuscarTodos()
        {
            var contatos = await client.GetStringAsync("api/Contato");
            return JsonConvert.DeserializeObject<List<ContatoViewModel>>(contatos);
        }

        public async Task DeletarContato(Guid id)
        {
            var contato = await client.GetStringAsync("api/Contato/Delete?id=" + id);
        }
    }
}
