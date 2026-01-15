using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResults;
using MovieApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{//11
 // Bu class, GetCastQuery isteğini karşılayan Query Handler’dır
 // MediatR kullanıldığı için IRequestHandler interface’ini implemente eder
    public class GetCastQueryHandler
        : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        // Veritabanı işlemleri için kullanılan DbContext
        // readonly → constructor’dan sonra değiştirilemez
        private readonly MovieContext _context;

        // MovieContext Dependency Injection ile buraya enjekte edilir
        public GetCastQueryHandler(MovieContext context)
        {
            _context = context;
        }

        // MediatR tarafından çağrılan ana metot
        // async Task<List<>> → asenkron olarak veri döndürür
        public async Task<List<GetCastQueryResult>> Handle(
            GetCastQuery request,
            CancellationToken cancellationToken)
        {
            // Cast tablosundaki tüm kayıtlar veritabanından çekilir
            // ToListAsync → sorgu burada çalışır (DB’ye gider)
            var values = await _context.Casts.ToListAsync();

            // Veritabanından gelen Cast entity’leri,
            // GetCastQueryResult DTO’suna dönüştürülür
            return values.Select(x => new GetCastQueryResult
            {
                Biography = x.Biography,
                CastId = x.CastId,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Overview = x.Overview,
                Surname = x.Surname,
                Title = x.Title
            })
            // LINQ Select sonucu IEnumerable döner,
            // bunu List’e çevirmek için ToList() kullanılır
            .ToList();
        }
    }
}
