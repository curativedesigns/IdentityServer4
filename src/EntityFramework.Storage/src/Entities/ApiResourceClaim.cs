
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ApiResourceClaim : UserClaim, IEquatable<ApiResourceClaim>
    {
        public int ApiResourceId { get; set; }
        public ApiResource ApiResource { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ApiResourceClaim);
        }

        public bool Equals(ApiResourceClaim other)
        {
            return other != null &&
                   Type == other.Type;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type);
        }

        public static bool operator ==(ApiResourceClaim left, ApiResourceClaim right)
        {
            return EqualityComparer<ApiResourceClaim>.Default.Equals(left, right);
        }

        public static bool operator !=(ApiResourceClaim left, ApiResourceClaim right)
        {
            return !(left == right);
        }
    }
}