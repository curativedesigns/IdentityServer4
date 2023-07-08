﻿
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using AutoMapper;
using IdentityServer4.EntityFramework.Entities;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Mappers
{
    /// <summary>
    ///     Defines entity/model mapping for scopes.
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class ScopeMapperProfile : Profile
    {
        /// <summary>
        ///     <see cref="ScopeMapperProfile" />
        /// </summary>
        public ScopeMapperProfile()
        {
            CreateMap<ApiScopeProperty, KeyValuePair<string, string>>()
                .ReverseMap();

            CreateMap<ApiScopeClaim, string>()
                .ConstructUsing(x => x.Type)
                .ReverseMap()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src));

            CreateMap<ApiScope, Models.ApiScope>(MemberList.Destination)
                .ConstructUsing(src => new Models.ApiScope())
                .ForMember(x => x.Properties, opts => opts.MapFrom(x => x.Properties))
                .ForMember(x => x.UserClaims, opts => opts.MapFrom(x => x.UserClaims))
                .ReverseMap();
        }
    }
}