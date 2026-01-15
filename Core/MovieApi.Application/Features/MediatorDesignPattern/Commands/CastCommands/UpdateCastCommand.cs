using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands
{ //2
    public class UpdateCastCommand : IRequest
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
