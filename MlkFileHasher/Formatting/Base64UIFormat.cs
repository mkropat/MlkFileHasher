using System;

namespace MlkFileHasher.Formatting
{
    public class Base64UIFormat : IHashUIFormat
    {
        public string Name { get; } = "Base64";

        public string Format(byte[] hash)
        {
            return Convert.ToBase64String(hash);
        }
    }
}
