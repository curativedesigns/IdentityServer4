
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ClientProperty : Property, IEquatable<ClientProperty>
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClientProperty);
        }

        public bool Equals(ClientProperty other)
        {
            return other != null &&
                   Key == other.Key &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Key, Value);
        }

        public static bool operator ==(ClientProperty left, ClientProperty right)
        {
            return EqualityComparer<ClientProperty>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientProperty left, ClientProperty right)
        {
            return !(left == right);
        }
    }
}