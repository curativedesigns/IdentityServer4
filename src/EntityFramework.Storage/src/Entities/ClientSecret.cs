
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ClientSecret : Secret, IEquatable<ClientSecret>
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClientSecret);
        }

        public bool Equals(ClientSecret other)
        {
            return other != null &&
                   Value == other.Value &&
                   Type == other.Type;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value, Type);
        }

        public static bool operator ==(ClientSecret left, ClientSecret right)
        {
            return EqualityComparer<ClientSecret>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientSecret left, ClientSecret right)
        {
            return !(left == right);
        }
    }
}