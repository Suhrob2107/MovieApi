using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Dto.Dtos.MovieDtos
{
    public class ResultMovieDto
    {
        public int MovieId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CreatedYear { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
