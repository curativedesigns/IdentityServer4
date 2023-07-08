
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using AutoMapper;
using IdentityServer4.EntityFramework.Entities;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Mappers
{
    /// <summary>
    ///     Defines entity/model mapping for identity resources.
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class IdentityResourceMapperProfile : Profile
    {
        /// <summary>
        ///     <see cref="IdentityResourceMapperProfile" />
        /// </summary>
        public IdentityResourceMapperProfile()
        {
            CreateMap<IdentityResourceProperty, KeyValuePair<string, string>>()
                .ReverseMap();

            CreateMap<IdentityResource, Models.IdentityResource>(MemberList.Destination)
                .ConstructUsing(src => new Models.IdentityResource())
                .ReverseMap();

            CreateMap<IdentityResourceClaim, string>()
                .ConstructUsing(x => x.Type)
                .ReverseMap()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src));
        }
    }
}