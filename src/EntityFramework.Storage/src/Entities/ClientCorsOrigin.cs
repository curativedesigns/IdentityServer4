
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ClientCorsOrigin : IEquatable<ClientCorsOrigin>
    {
        public int Id { get; set; }
        public string Origin { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClientCorsOrigin);
        }

        public bool Equals(ClientCorsOrigin other)
        {
            return other != null &&
                   Origin == other.Origin;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Origin);
        }

        public static bool operator ==(ClientCorsOrigin left, ClientCorsOrigin right)
        {
            return EqualityComparer<ClientCorsOrigin>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientCorsOrigin left, ClientCorsOrigin right)
        {
            return !(left == right);
        }
    }
}