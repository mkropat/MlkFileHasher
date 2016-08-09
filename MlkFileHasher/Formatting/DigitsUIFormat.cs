using System;
using System.Collections.Generic;
using System.Numerics;

namespace MlkFileHasher.Formatting
{
    public class DigitsUIFormat : IHashUIFormat
    {
        public string Name
        {
            get { return "Digits"; }
        }

        public string Format(byte[] hash)
        {
            var buf = new byte[hash.Length + 1];
            for (var i = 0; i < hash.Length; i++)
                buf[i] = hash[hash.Length - i - 1];
            return new BigInteger(buf).ToString("N0");
        }

        public IEqualityComparer<string> FormattedHashComparer
        {
            get { return StringComparer.InvariantCultureIgnoreCase; }
        }
    }
}
