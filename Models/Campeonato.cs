using System.Collections.Generic;

namespace copadefilmes_api.Models
{
    class Campeonato
    {
        public long id;
        public string name;
        public List<Filme> filmes;
        public List<Filme> campeoes;
    }
    
}