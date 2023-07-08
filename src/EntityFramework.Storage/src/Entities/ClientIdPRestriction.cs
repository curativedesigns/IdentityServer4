
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ClientIdPRestriction : IEquatable<ClientIdPRestriction>
    {
        public int Id { get; set; }
        public string Provider { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClientIdPRestriction);
        }

        public bool Equals(ClientIdPRestriction other)
        {
            return other != null &&
                   Provider == other.Provider;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Provider);
        }

        public static bool operator ==(ClientIdPRestriction left, ClientIdPRestriction right)
        {
            return EqualityComparer<ClientIdPRestriction>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientIdPRestriction left, ClientIdPRestriction right)
        {
            return !(left == right);
        }
    }
}