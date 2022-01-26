﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace web
{
    public class Relatorio
    {
        private readonly Catalogo catalogo;

        public Relatorio(Catalogo catalogo)
        {
            this.catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var livro in catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"{livro.Codigo,-10}{livro.Nome,-40}{livro.Preco.ToString("C"),10}\r\n");
            }
        }
    }
}
