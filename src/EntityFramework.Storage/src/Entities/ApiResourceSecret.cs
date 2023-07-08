
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ApiResourceSecret : Secret, IEquatable<ApiResourceSecret>
    {
        public int ApiResourceId { get; set; }
        public ApiResource ApiResource { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ApiResourceSecret);
        }

        public bool Equals(ApiResourceSecret other)
        {
            return other != null &&
                   Value == other.Value &&
                   Type == other.Type;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value, Type);
        }

        public static bool operator ==(ApiResourceSecret left, ApiResourceSecret right)
        {
            return EqualityComparer<ApiResourceSecret>.Default.Equals(left, right);
        }

        public static bool operator !=(ApiResourceSecret left, ApiResourceSecret right)
        {
            return !(left == right);
        }
    }
}