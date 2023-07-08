
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ClientScope : IEquatable<ClientScope>
    {
        public int Id { get; set; }
        public string Scope { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClientScope);
        }

        public bool Equals(ClientScope other)
        {
            return other != null &&
                   Scope == other.Scope;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Scope);
        }

        public static bool operator ==(ClientScope left, ClientScope right)
        {
            return EqualityComparer<ClientScope>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientScope left, ClientScope right)
        {
            return !(left == right);
        }
    }
}