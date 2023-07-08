
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using AutoMapper;
using IdentityServer4.EntityFramework.Entities;

namespace IdentityServer4.EntityFramework.Mappers
{
    /// <summary>
    ///     Defines entity/model mapping for persisted grants.
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class PersistedGrantMapperProfile : Profile
    {
        /// <summary>
        ///     <see cref="PersistedGrantMapperProfile">
        ///     </see>
        /// </summary>
        public PersistedGrantMapperProfile()
        {
            CreateMap<PersistedGrant, Models.PersistedGrant>(MemberList.Destination)
                .ReverseMap();
        }
    }
}