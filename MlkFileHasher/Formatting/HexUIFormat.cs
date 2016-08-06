using System;

namespace MlkFileHasher.Formatting
{
    public class HexUIFormat : IHashUIFormat
    {
        public string Name { get; } = "Hex";

        public string Format(byte[] hash)
        {
            return BitConverter.ToString(hash)
                .Replace("-", string.Empty)
                .ToLowerInvariant();
        }
    }

}
