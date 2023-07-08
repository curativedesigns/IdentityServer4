
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ClientClaim : IEquatable<ClientClaim>
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClientClaim);
        }

        public bool Equals(ClientClaim other)
        {
            return other != null &&
                   Type == other.Type &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Value);
        }

        public static bool operator ==(ClientClaim left, ClientClaim right)
        {
            return EqualityComparer<ClientClaim>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientClaim left, ClientClaim right)
        {
            return !(left == right);
        }
    }
}