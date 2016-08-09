using System;
using System.Collections.Generic;

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

        public IEqualityComparer<string> FormattedHashComparer
        {
            get { return StringComparer.InvariantCultureIgnoreCase; }
        }
    }
}
