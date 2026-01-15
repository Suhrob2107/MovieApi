using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands
{//2.5
    public class CreateTagCommand : IRequest
    {
        public string Title { get; set; } = string.Empty;
    }
}
