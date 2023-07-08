
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ApiResourceProperty : Property, IEquatable<ApiResourceProperty>
    {
        public int ApiResourceId { get; set; }
        public ApiResource ApiResource { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ApiResourceProperty);
        }

        public bool Equals(ApiResourceProperty other)
        {
            return other != null &&
                   Key == other.Key &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Key, Value);
        }

        public static bool operator ==(ApiResourceProperty left, ApiResourceProperty right)
        {
            return EqualityComparer<ApiResourceProperty>.Default.Equals(left, right);
        }

        public static bool operator !=(ApiResourceProperty left, ApiResourceProperty right)
        {
            return !(left == right);
        }
    }
}