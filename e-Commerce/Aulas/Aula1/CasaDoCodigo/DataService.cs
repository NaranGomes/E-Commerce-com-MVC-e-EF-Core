﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CasaDoCodigo
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext contexto;

        public DataService(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void IncializaDB()
        {
            contexto.Database.EnsureCreated();
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject <List<Livro>>(json);
        }

       
    }
    public class Livro
    {        
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }

    }

}
