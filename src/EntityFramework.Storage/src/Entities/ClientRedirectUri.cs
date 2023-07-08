
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ClientRedirectUri : IEquatable<ClientRedirectUri>
    {
        public int Id { get; set; }
        public string RedirectUri { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClientRedirectUri);
        }

        public bool Equals(ClientRedirectUri other)
        {
            return other != null &&
                   RedirectUri == other.RedirectUri;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RedirectUri);
        }

        public static bool operator ==(ClientRedirectUri left, ClientRedirectUri right)
        {
            return EqualityComparer<ClientRedirectUri>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientRedirectUri left, ClientRedirectUri right)
        {
            return !(left == right);
        }
    }
}