
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public class ClientPostLogoutRedirectUri : IEquatable<ClientPostLogoutRedirectUri>
    {
        public int Id { get; set; }
        public string PostLogoutRedirectUri { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClientPostLogoutRedirectUri);
        }

        public bool Equals(ClientPostLogoutRedirectUri other)
        {
            return other != null &&
                   PostLogoutRedirectUri == other.PostLogoutRedirectUri;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(PostLogoutRedirectUri);
        }

        public static bool operator ==(ClientPostLogoutRedirectUri left, ClientPostLogoutRedirectUri right)
        {
            return EqualityComparer<ClientPostLogoutRedirectUri>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientPostLogoutRedirectUri left, ClientPostLogoutRedirectUri right)
        {
            return !(left == right);
        }
    }
}