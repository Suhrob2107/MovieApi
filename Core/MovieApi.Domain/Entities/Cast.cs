using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entities
{
    public class Cast
    {
        public int CastId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;    
        public string Surname { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Overview { get; set; } = string.Empty;
        public string Biography { get; set; } = string.Empty;
    }
}
