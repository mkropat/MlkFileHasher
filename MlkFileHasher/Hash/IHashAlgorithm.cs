using System;

namespace MlkFileHasher.Hash
{
    public interface IHashAlgorithm : IDisposable
    {
        void Process(byte[] buf, int count);
        void Done();
        byte[] Hash { get; }
    }
}
