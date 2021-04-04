using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ApiPomar.Models
{
    public class Arvores
    {
        [Key]
        public int  ArvoreId { get; set; }
        public string Descricao { get; set; }
        public string Idade { get; set; }
        public string Especie { get; set; }
        
        
    }
}