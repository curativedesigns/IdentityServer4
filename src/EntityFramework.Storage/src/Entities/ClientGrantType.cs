
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ClientGrantType : IEquatable<ClientGrantType>
    {
        public int Id { get; set; }
        public string GrantType { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClientGrantType);
        }

        public bool Equals(ClientGrantType other)
        {
            return other != null &&
                   GrantType == other.GrantType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GrantType);
        }

        public static bool operator ==(ClientGrantType left, ClientGrantType right)
        {
            return EqualityComparer<ClientGrantType>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientGrantType left, ClientGrantType right)
        {
            return !(left == right);
        }
    }
}