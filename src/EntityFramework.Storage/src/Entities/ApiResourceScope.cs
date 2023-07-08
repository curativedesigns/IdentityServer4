
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ApiResourceScope : IEquatable<ApiResourceScope>
    {
        public int Id { get; set; }
        public string Scope { get; set; }

        public int ApiResourceId { get; set; }
        public ApiResource ApiResource { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ApiResourceScope);
        }

        public bool Equals(ApiResourceScope other)
        {
            return other != null &&
                   Scope == other.Scope;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Scope);
        }

        public static bool operator ==(ApiResourceScope left, ApiResourceScope right)
        {
            return EqualityComparer<ApiResourceScope>.Default.Equals(left, right);
        }

        public static bool operator !=(ApiResourceScope left, ApiResourceScope right)
        {
            return !(left == right);
        }
    }
}