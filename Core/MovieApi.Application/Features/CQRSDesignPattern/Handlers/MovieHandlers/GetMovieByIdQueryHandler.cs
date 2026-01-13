using MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
        {
            var values = await _context.Movies.FindAsync(query.MovieId);
            return new GetMovieByIdQueryResult
            {
                MovieId = values.MovieId,
                Title = values.Title,
                CoverImageUrl = values.CoverImageUrl,
                Rating = values.Rating,
                Description = values.Description,
                Duration = values.Duration,
                ReleaseDate = values.ReleaseDate,
                CreatedYear = values.CreatedYear,
                Status = values.Status
            };
        }
    }
}
