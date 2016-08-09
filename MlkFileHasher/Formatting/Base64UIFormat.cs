using System;
using System.Collections.Generic;

namespace MlkFileHasher.Formatting
{
    public class Base64UIFormat : IHashUIFormat
    {
        public string Name { get; } = "Base64";

        public string Format(byte[] hash)
        {
            return Convert.ToBase64String(hash);
        }

        public IEqualityComparer<string> FormattedHashComparer
        {
            get { return StringComparer.InvariantCulture; }
        }
    }
}
