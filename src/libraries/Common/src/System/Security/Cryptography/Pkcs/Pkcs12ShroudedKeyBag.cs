// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Security.Cryptography.Pkcs
{
#if BUILDING_PKCS
    public
#else
    #pragma warning disable CA1510, CA1512
    internal
#endif
    sealed class Pkcs12ShroudedKeyBag : Pkcs12SafeBag
    {
        public Pkcs12ShroudedKeyBag(ReadOnlyMemory<byte> encryptedPkcs8PrivateKey, bool skipCopy = false)
            : base(Oids.Pkcs12ShroudedKeyBag, encryptedPkcs8PrivateKey, skipCopy)
        {
        }

        public ReadOnlyMemory<byte> EncryptedPkcs8PrivateKey => EncodedBagValue;
    }
}
