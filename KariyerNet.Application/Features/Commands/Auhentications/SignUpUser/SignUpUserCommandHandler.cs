using AutoMapper;
using KariyerNet.Domain.Entities.Authentications;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KariyerNet.Application.Features.Commands.Auhentications.SignUpUser
{
    public class SignUpUserCommandHandler : IRequestHandler<SignUpUserCommand, int>
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<User> _roleManager;

        public SignUpUserCommandHandler(UserManager<User> userManager,
            RoleManager<User> roleManager,
             IMapper mapper
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task<int> Handle(SignUpUserCommand request, CancellationToken cancellationToken)
        {
            var userEntity = _mapper.Map<User>(request);

            userEntity.UserName = request.Email;

            var userCreateResult = await _userManager.CreateAsync(userEntity, request.Password);

            if(userCreateResult.Succeeded)
            {
                var user = _userManager.Users.SingleOrDefault(u => u.Email == request.Email);

                return user.Id;
            }

           return 0;
        }
    }
}
