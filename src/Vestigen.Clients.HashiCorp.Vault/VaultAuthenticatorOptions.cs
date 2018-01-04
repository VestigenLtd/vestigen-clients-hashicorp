﻿using Microsoft.Extensions.Options;

namespace Vestigen.Clients.HashiCorp.Vault
{
    public class VaultAuthenticatorOptions : IOptions<VaultAuthenticatorOptions>
    {
        public static VaultAuthenticatorOptions Default = new VaultAuthenticatorOptions();

        public VaultAuthenticatorOptions()
        { }

        public VaultAuthenticatorOptions(IHashiCorpAuthenticatorHandler handler)
        {
            
        }

        public string Address { get; set; } = "https://localhost:8200";
        public string Token { get; set; }

        VaultAuthenticatorOptions IOptions<VaultAuthenticatorOptions>.Value => this;
    }

    public interface IHashiCorpAuthenticatorHandler
    {
    }
}