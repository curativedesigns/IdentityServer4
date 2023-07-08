
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ApiScopeClaim : UserClaim, IEquatable<ApiScopeClaim>
    {
        public int ScopeId { get; set; }
        public ApiScope Scope { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ApiScopeClaim);
        }

        public bool Equals(ApiScopeClaim other)
        {
            return other != null &&
                   Type == other.Type;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type);
        }

        public static bool operator ==(ApiScopeClaim left, ApiScopeClaim right)
        {
            return EqualityComparer<ApiScopeClaim>.Default.Equals(left, right);
        }

        public static bool operator !=(ApiScopeClaim left, ApiScopeClaim right)
        {
            return !(left == right);
        }
    }
}