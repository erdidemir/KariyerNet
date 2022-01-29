using AutoMapper;
using KariyerNet.Application.Models.Authentications;
using KariyerNet.Domain.Entities.Authentications;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KariyerNet.Application.Features.Queries.Authentications.GetUser
{
    public class GetUserByEmailAndPasswordQueryHandler : IRequestHandler<GetUserByEmailAndPasswordQuery, UserModel>
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<Role> _roleManager;

        public GetUserByEmailAndPasswordQueryHandler(UserManager<User> userManager,
           IMapper mapper,
           RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
        }
        public async Task<UserModel> Handle(GetUserByEmailAndPasswordQuery request, CancellationToken cancellationToken)
        {
            var user = _userManager.Users.SingleOrDefault(u=> u.Email == request.Email);

            if (user == null)
                return null;

            var userModel = new UserModel();

            var userSigingResult = await _userManager.CheckPasswordAsync(user, request.Password);

            if(userSigingResult)
            {
                userModel = _mapper.Map<UserModel>(user);
                userModel.Roles = await _userManager.GetRolesAsync(user);
            }

            return userModel;
        }
    }
}
