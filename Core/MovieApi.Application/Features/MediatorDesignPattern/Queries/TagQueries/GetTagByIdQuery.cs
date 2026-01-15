using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Results.TagResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.TagQueries
{//2.4
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public GetTagByIdQuery(int tagId)
        {
            TagId = tagId;
        }

        public int TagId { get; set; }
    }
}
