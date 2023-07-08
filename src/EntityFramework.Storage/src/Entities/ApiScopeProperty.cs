
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ApiScopeProperty : Property, IEquatable<ApiScopeProperty>
    {
        public int ScopeId { get; set; }
        public ApiScope Scope { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ApiScopeProperty);
        }

        public bool Equals(ApiScopeProperty other)
        {
            return other != null &&
                   Key == other.Key &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Key, Value);
        }

        public static bool operator ==(ApiScopeProperty left, ApiScopeProperty right)
        {
            return EqualityComparer<ApiScopeProperty>.Default.Equals(left, right);
        }

        public static bool operator !=(ApiScopeProperty left, ApiScopeProperty right)
        {
            return !(left == right);
        }
    }
}