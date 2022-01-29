using AutoMapper;
using KariyerNet.Application.Features.Commands.Auhentications.SignUpUser;
using KariyerNet.Application.Models.Authentications;
using KariyerNet.Domain.Entities.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNet.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Authentications

            CreateMap<User, SignUpUserCommand>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();

            #endregion
        }

    }
}
