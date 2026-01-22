using Microsoft.AspNetCore.Identity;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.UserRegisterCommands;
using MovieApi.Persistance.Context;
using MovieApi.Persistance.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.UserRegisterHandlers
{
    public class CreateUserRegisterCommandHandler
    {
        private readonly MovieContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CreateUserRegisterCommandHandler(MovieContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task Handle(CreateUserRegisterCommand command)
        {
            AppUser user = new AppUser()
            {
                Name = command.Name,
                Surname = command.Surname,
                UserName = command.Username,
                Email = command.Email
            };
            var result = await _userManager.CreateAsync(user, command.Password);
            if (result.Succeeded)
            {
                // User created successfully
            }
            else
            {
                // Handle errors
            }
        }
    }
    
}
