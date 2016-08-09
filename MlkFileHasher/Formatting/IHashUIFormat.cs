using System.Collections.Generic;

namespace MlkFileHasher.Formatting
{
    public interface IHashUIFormat
    {
        string Name { get; }
        string Format(byte[] hash);
        IEqualityComparer<string> FormattedHashComparer { get; }
    }
}
