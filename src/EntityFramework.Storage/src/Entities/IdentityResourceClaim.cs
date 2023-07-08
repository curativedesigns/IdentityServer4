
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class IdentityResourceClaim : UserClaim, IEquatable<IdentityResourceClaim>
    {
        public int IdentityResourceId { get; set; }
        public IdentityResource IdentityResource { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as IdentityResourceClaim);
        }

        public bool Equals(IdentityResourceClaim other)
        {
            return other != null &&
                   Type == other.Type;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type);
        }

        public static bool operator ==(IdentityResourceClaim left, IdentityResourceClaim right)
        {
            return EqualityComparer<IdentityResourceClaim>.Default.Equals(left, right);
        }

        public static bool operator !=(IdentityResourceClaim left, IdentityResourceClaim right)
        {
            return !(left == right);
        }
    }
}