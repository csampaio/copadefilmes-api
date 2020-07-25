using  copadefilmes_api.Models;

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