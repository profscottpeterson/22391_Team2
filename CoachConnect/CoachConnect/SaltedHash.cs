// <copyright file="SaltedHash.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// An object used to generate an encrypted password.
    /// </summary>
    public class SaltedHash
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaltedHash"/> class.
        /// </summary>
        /// <param name="password">The desired password to encrypt.</param>
        public SaltedHash(string password)
        {
            var saltBytes = new byte[32];

            using (var provider = new RNGCryptoServiceProvider())
            {
                provider.GetNonZeroBytes(saltBytes);
            }

            this.Salt = Convert.ToBase64String(saltBytes);
            this.Hash = ComputeHash(this.Salt, password);
        }

        /// <summary>
        /// Gets the final encrypted version of the password
        /// </summary>
        public string Hash { get; private set; }

        /// <summary>
        /// Gets a random string to be appended in front of the password
        /// </summary>
        public string Salt { get; private set; }

        /// <summary>
        /// A method to calculate the hash based on the salt and entered password.
        /// </summary>
        /// <param name="salt">The salt to be applied to the final password.</param>
        /// <param name="password">The password entered by the user.</param>
        /// <returns>A hash value that represents the encrypted password.</returns>
        public static string ComputeHash(string salt, string password)
        {
            var saltBytes = Convert.FromBase64String(salt);
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 1000))
            {
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));
            }
        }

        /// <summary>
        /// A method to verify the salted hash is correct.
        /// </summary>
        /// <param name="salt">The salt used by the original password</param>
        /// <param name="hash">The final password to be verified </param>
        /// <param name="password">The unencrypted password entered by the user</param>
        /// <returns>Returns a boolean to determine whether the encrypted version of the entered password matchs a permanent location.</returns>
        public static bool Verify(string salt, string hash, string password)
        {
            return hash == ComputeHash(salt, password);
        }
    }
}
