using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace MyFace.Helpers;

public class HashPassword{
    public static Tuple<string,byte[]> GenerateHashPassword(string password)
    {
        byte[] salt = new byte[128 / 8];
        using (var rngCsp = RandomNumberGenerator.Create())
        {
            rngCsp.GetNonZeroBytes(salt);
        }
        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));
        return new Tuple<string,byte[]> (hashed,salt);
    }

    public static string GenerateHashPasswordWithExistingSalt(string password,byte[] salt)
    {
        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));
        return hashed;
    }
}