using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{ //9
  // Bu class, RemoveCastCommand isteğini karşılayan Handler’dır
  // MediatR kullanıldığı için IRequestHandler interface’ini implemente eder
    public class RemoveCastCommandHandler : IRequestHandler<RemoveCastCommand>
    {
        // Veritabanı işlemleri için kullanılan DbContext
        // readonly → constructor’dan sonra değiştirilemez
        private readonly MovieContext _context;

        // Dependency Injection ile MovieContext buraya enjekte edilir
        public RemoveCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        // MediatR tarafından çağrılan ana metot
        // async Task → asenkron çalışır ve geriye değer döndürmez
        public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
        {
            // Gönderilen CastId’ye göre Cast tablosunda kayıt aranır
            // FindAsync → primary key üzerinden hızlı arama yapar
            var values = await _context.Casts.FindAsync(request.CastId);

            // Bulunan kayıt DbContext üzerinden silinmek üzere işaretlenir
            _context.Casts.Remove(values);

            // Yapılan değişiklikler veritabanına kaydedilir
            // SaveChangesAsync → async olduğu için thread bloklanmaz
            await _context.SaveChangesAsync();
        }
    }

}
