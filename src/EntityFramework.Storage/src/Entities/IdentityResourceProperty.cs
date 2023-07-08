
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class IdentityResourceProperty : Property, IEquatable<IdentityResourceProperty>
    {
        public int IdentityResourceId { get; set; }
        public IdentityResource IdentityResource { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as IdentityResourceProperty);
        }

        public bool Equals(IdentityResourceProperty other)
        {
            return other != null &&
                   Key == other.Key &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Key, Value);
        }

        public static bool operator ==(IdentityResourceProperty left, IdentityResourceProperty right)
        {
            return EqualityComparer<IdentityResourceProperty>.Default.Equals(left, right);
        }

        public static bool operator !=(IdentityResourceProperty left, IdentityResourceProperty right)
        {
            return !(left == right);
        }
    }
}