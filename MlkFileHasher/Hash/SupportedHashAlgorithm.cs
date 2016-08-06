using System;

namespace MlkFileHasher.Hash
{
    public class SupportedHashAlgorithm
    {
        public string Name { get; set; }
        public Func<IHashAlgorithm> Factory { get; set; }
    }
}
